using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTK
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            titleView.Items.Clear();
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
                this.locationBox.Text = openFileDialog1.FileName;
                this.titleView.Items.Clear();
                Dictionary<string, string> titleDic = ParseDecTitleKeysBin(openFileDialog1.FileName);

                foreach (KeyValuePair<string, string> entry in myDic)
                {
                    
                }
            }
        }
    }
}
