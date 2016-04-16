using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DTK
{
    public partial class Main : Form
    {
        private const string _3dsDbPath = "3dsreleases.xml";
        private const string _FunKeyCIAPath = "FunKeyCIA.py";

        public Main()
        {
            InitializeComponent();
            titleView.Items.Clear();
            countLabel.Text = "0 items loaded.";

            if (!File.Exists(_3dsDbPath))
            {
                Console.WriteLine("3DS titles database not found! Downloading...");
                Download3DSDatabase();
            }

            if (!File.Exists(_FunKeyCIAPath))
            {
                MessageBox.Show("Could not find FunKeyCIA.py. Downloading from CDN will not work");
            }

        }


        private static void Download3DSDatabase()
        {
            const string dbAddress = @"http://3dsdb.com/xml.php";
            using (var client = new WebClient())
            {
                try
                {
                    client.DownloadFile(dbAddress, _3dsDbPath);
                }
                catch (WebException ex)
                {
                    MessageBox.Show("Could not download the 3ds database. Error: " + ex.Message);
                }
            }

            Console.WriteLine("3DS database downloaded!");
        }

        private static List<Nintendo3DSRelease> ParseTicketsFrom3dsDb(List<Nintendo3DSRelease> parsedTickets)
        {
            Console.WriteLine("Checking Title IDs against 3dsdb.com database");
            var xmlFile = XElement.Load(_3dsDbPath);
            List<Nintendo3DSRelease> foundTitles = new List<Nintendo3DSRelease>();


            foreach (XElement titleInfo in xmlFile.Nodes())
            {
                Func<string, string> titleData = tag => titleInfo.Element(tag).Value.Trim();
                var titleId = titleData("titleid");
                

                var matchedTitles =
                    parsedTickets.Where(ticket => string.Compare(ticket.TitleId, titleId, StringComparison.OrdinalIgnoreCase) == 0)
                        .ToList();

                foreach (var title in matchedTitles)
                {
                    var publisher = titleData("publisher");
                    var titlename = titleData("name");
                    var region = titleData("region");
                    var serial = titleData("serial");

                    string type;

                    switch (int.Parse(titleData("type")))
                    {
                        case 1:
                            type = "3DS Game";
                            break;
                        case 2:
                            type = "3DS Demo";
                            break;
                        case 3:
                            type = "3DSWare";
                            break;
                        case 4:
                            type = "EShop";
                            break;
                        default:
                            type = "Unknown";
                            break;
                    }

                    var sizeInMegabytes = Convert.ToInt32(decimal.Parse(titleData("trimmedsize")) / (int)Math.Pow(2, 20));

                    var foundTicket = new Nintendo3DSRelease(
                        titlename,
                        publisher,
                        region,
                        type,
                        serial,
                        titleId,
                        title.TitleKey,
                        sizeInMegabytes);

                    foundTitles.Add(foundTicket);
                }
            }

            return foundTitles;
        }

        private static Dictionary<string, string> ParseDecTitleKeysBin(String DecryptedTitleKeysPath)
        {
            var ticketsDictionary = new Dictionary<string, string>();

            using (var reader = new BinaryReader(new FileStream(DecryptedTitleKeysPath, FileMode.Open, FileAccess.Read)))
            {
                var numberOfKeys = new FileInfo(DecryptedTitleKeysPath).Length / 32;

                reader.ReadBytes(16); // seek in

                for (var entry = 0; entry < numberOfKeys; entry++)
                {
                    reader.ReadBytes(8); // skip 8 bytes
                    var titleId = BitConverter.ToString(reader.ReadBytes(8)).Replace("-", string.Empty);
                    var titleKey = BitConverter.ToString(reader.ReadBytes(16)).Replace("-", string.Empty);

                    // var pair = BitConverter.ToString(titleId) + ": " + BitConverter.ToString(titleKey);
                    // tickets.Add(pair);
                    ticketsDictionary[titleId] = titleKey;
                }
            }

            return ticketsDictionary;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            // Displays an OpenFileDialog so the user can select a Cursor.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "BIN files|*.bin";
            openFileDialog1.Title = "Select a decTitleKeys.bin File";

            // Show the Dialog.
            // If the user clicked OK in the dialog and
            // a .CUR file was selected, open it.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Assign the cursor in the Stream to the Form's Cursor property.
                if (openFileDialog1.SafeFileName.Contains("encTitleKeys"))
                {
                    isEncrypted.Checked = true;
                }
                this.locationBox.Text = openFileDialog1.FileName;
                this.titleView.Items.Clear();
                Dictionary<string, string> titleDic = ParseDecTitleKeysBin(openFileDialog1.FileName);
                List<Nintendo3DSRelease> titleList = new List<Nintendo3DSRelease>();

                foreach (KeyValuePair<string, string> entry in titleDic)
                {
                    titleList.Add(new Nintendo3DSRelease(entry.Key, entry.Value));
                }

                List<Nintendo3DSRelease> parsedTitles = ParseTicketsFrom3dsDb(titleList);
                countLabel.Text = parsedTitles.Count.ToString() + " titles loaded.";
                foreach (Nintendo3DSRelease entry in parsedTitles)
                {
                    string[] row = { entry.Name, entry.TitleId, entry.TitleKey, entry.Region, entry.SizeInMegabytes+"MB", entry.Type, entry.Publisher, entry.Serial};
                    var newEntry = new ListViewItem(row);
                    this.titleView.Items.Add(newEntry);
                }
            }
        }

        private void titleView_ItemActivate(object sender, EventArgs e)
        {
            if (isEncrypted.Checked)
            {
                foreach (ListViewItem item in this.titleView.SelectedItems)
                {
                    //MessageBox.Show(item.SubItems[1].Text);
                    var strCmdText = "/k python FunKeyCIA.py -title " + item.SubItems[1].Text + " -key " + item.SubItems[2].Text;
                    System.Diagnostics.Process.Start("CMD.exe", strCmdText);
                }
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            titleView.TopItem = titleView.FindItemWithText(searchBox.Text, true, 0, true);
        }

        private void isEncrypted_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void countLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
