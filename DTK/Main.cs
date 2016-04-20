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
        private const string _keyDbPath = "db.ebin";
        private const string _configPath = "config.xml";
        private static string aaa = "***REMOVED***";
        private static string _FunKeyCIAPath = "FunKeyCIA.py";
        private static string _pythonPath = "python";
        private List<Nintendo3DSRelease> loadedTitles = new List<Nintendo3DSRelease>();

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
            if (File.Exists(_configPath))
            {
                Config loadedConfig = ParseConfig();
                _pythonPath = loadedConfig.PythonPath;
                _FunKeyCIAPath = loadedConfig.FunKeyCIAPath;
            } else
            {
                Config cfg = new Config();
                System.Xml.Serialization.XmlSerializer writer =
                    new System.Xml.Serialization.XmlSerializer(typeof(Config));

                System.IO.FileStream file = System.IO.File.Create(_configPath);

                writer.Serialize(file, cfg);
                file.Close();
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

        private static void DownloadKeyDatabase()
        {
            string dbAddress = Base64Decode(aaa);
            using (var client = new WebClient())
            {
                try
                {
                    client.DownloadFile(dbAddress, _keyDbPath);
                }
                catch (WebException ex)
                {
                    MessageBox.Show("Could not download the key database. Error: " + ex.Message);
                }
            }

            MessageBox.Show("Key database downloaded!");
        }

        private void LoadDB(string path, string safe_path)
        {
            if (safe_path.Contains("enc"))
            {
                isEncrypted.Checked = true;
            }
            else if (safe_path.Contains(".ebin"))
            {
                isEncrypted.Checked = true;
            }
            this.locationBox.Text = path;
            this.titleView.Items.Clear();
            Dictionary<string, string> titleDic = ParseDecTitleKeysBin(path);
            List<Nintendo3DSRelease> titleList = new List<Nintendo3DSRelease>();

            foreach (KeyValuePair<string, string> entry in titleDic)
            {
                titleList.Add(new Nintendo3DSRelease(entry.Key, entry.Value));
            }

            List<Nintendo3DSRelease> parsedTitles = ParseTicketsFrom3dsDb(titleList);
            loadedTitles = parsedTitles;
            countLabel.Text = parsedTitles.Count.ToString() + " titles loaded.";
            foreach (Nintendo3DSRelease entry in parsedTitles)
            {
                string[] row = { entry.Name, entry.TitleId, entry.TitleKey, entry.Region, entry.SizeInMegabytes + "MB", entry.Type, entry.Publisher, entry.Serial };
                var newEntry = new ListViewItem(row);
                this.titleView.Items.Add(newEntry);
            }
        }

        private void LoadKeyDatabase()
        {
            if (!File.Exists(_keyDbPath))
            {
                Console.WriteLine("Key database not found! Downloading...");
                DownloadKeyDatabase();
            }
            LoadDB(_keyDbPath, _keyDbPath);
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        private static Config ParseConfig()
        {
            Console.WriteLine("Loading config...");
            System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(Config));
            System.IO.StreamReader file = new System.IO.StreamReader(_configPath);
            Config cfg = (Config)reader.Deserialize(file);
            file.Close();
            return cfg;
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

        private void browseButton_Click(object sender, EventArgs e)
        {
            // Displays an OpenFileDialog so the user can select a Cursor.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "BIN files|*.bin|EBIN files|*.ebin|DBIN files|*.dbin|All files|*.*";
            openFileDialog1.Title = "Select a title key database file";

            // Show the Dialog.
            // If the user clicked OK in the dialog and
            // a .CUR file was selected, open it.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LoadDB(openFileDialog1.FileName, openFileDialog1.SafeFileName);
            }
        }

        private void titleView_ItemActivate(object sender, EventArgs e)
        {
            if (isEncrypted.Checked)
            {
                foreach (ListViewItem item in this.titleView.SelectedItems)
                {
                    var strCmdText = "/k "+ _pythonPath + " " + _FunKeyCIAPath + " -title " + item.SubItems[1].Text + " -key " + item.SubItems[2].Text;
                    System.Diagnostics.Process.Start("CMD.exe", strCmdText);
                }
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            titleView.Items.Clear();
            var searchTexts = searchBox.Text.ToLower().Split(' ');
            foreach (Nintendo3DSRelease entry in loadedTitles)
            {
                var searchCount = 0;
                foreach (string searchText in searchTexts)
                {
                    if (entry.Name.ToLower().Contains(searchText) | entry.TitleKey.ToLower().Contains(searchText) | entry.TitleId.ToLower().Contains(searchText) | entry.Region.ToLower().Contains(searchText) | (entry.SizeInMegabytes.ToString().ToLower() + "MB").Contains(searchText) | entry.Type.ToLower().Contains(searchText) | entry.Publisher.ToLower().Contains(searchText) | entry.Serial.ToLower().Contains(searchText))
                    {
                        searchCount++;
                    }
                }
                if (searchCount >= searchTexts.Length)
                {
                    string[] row = { entry.Name, entry.TitleId, entry.TitleKey, entry.Region, entry.SizeInMegabytes + "MB", entry.Type, entry.Publisher, entry.Serial };
                    var newEntry = new ListViewItem(row);
                    this.titleView.Items.Add(newEntry);
                }
            }
            titleView.Refresh();
            titleView.Update();
        }

        private void isEncrypted_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void countLabel_Click(object sender, EventArgs e)
        {

        }

        private void loadKeyDB_Click(object sender, EventArgs e)
        {
            LoadKeyDatabase();
        }
    }
}
