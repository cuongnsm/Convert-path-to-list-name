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

namespace Convert_path_to_list_name
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void browserButton_Click(object sender, EventArgs e)
        {
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                folderPath.Text = folderDialog.SelectedPath;
            }
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(folderPath.Text.ToString()))
            {
                var directoryInfo = new DirectoryInfo(folderPath.Text.ToString());
                var listNames = directoryInfo.GetFiles().Select(n=>n.Name);
                string str = string.Empty;
                foreach (var s in listNames)
                {
                    str += string.Format("\n\"{0}\"", s);
                }
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveDialog.FileName, str);
                    MessageBox.Show("Done!", "Success");
                }
            }
            else
            {
                MessageBox.Show(string.Format("{0} is wrong path.", folderPath.Text.ToString()), "Error");
            }
        }
    }
}
