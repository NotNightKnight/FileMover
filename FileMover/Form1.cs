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

namespace FileMover
{
    public partial class Form1 : Form
    {
        private readonly string txtPath = "./paths.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(!File.Exists(txtPath))
            {
                File.Create(txtPath);
            }
            else
            {
                konumlarıYükleToolStripMenuItem_Click(sender, e);
            }
        }

        private void konumlarıKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] paths = new string[3];
            
            paths[0] = labelPathSource.Text;
            paths[1] = labelPathTarget1.Text;
            paths[2] = labelPathTarget2.Text;

            File.WriteAllLines(txtPath, paths);
        }

        private void konumlarıYükleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] paths = new string[3];

            paths = File.ReadAllLines(txtPath);

            labelPathSource.Text = paths[0];
            labelPathTarget1.Text = paths[1];
            labelPathTarget2.Text = paths[2];
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string myMessage = "Mehmet Baran Özboyacı tarafından yapılmıştır.";

            MessageBox.Show(myMessage);
        }

        private void buttonPathSource_Click(object sender, EventArgs e)
        {
            using(var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    labelPathSource.Text = fbd.SelectedPath;
                }
            }
        }

        private void buttonPathTarget1_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    labelPathTarget1.Text = fbd.SelectedPath;
                }
            }
        }

        private void buttonPathTarget2_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    labelPathTarget2.Text = fbd.SelectedPath;
                }
            }
        }

        private void checkBoxTarget2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxTarget2.Checked)
            {
                groupBoxTarget2.Visible = true;
            }
            else 
            { 
                groupBoxTarget2.Visible = false; 
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            CopyFiles(labelPathTarget1.Text);
            
            if(checkBoxTarget2.Checked)
            {
                CopyFiles(labelPathTarget2.Text);
            }

            labelInfo.Text = "Dosyalar başarılı şekilde kopyalandı.";
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            buttonCopy_Click(sender, e);
            DeleteFiles(labelPathSource.Text);

            labelInfo.Text = "Dosyalar başarılı şekilde taşındı.";
        }

        private void CopyFiles(string pathTarget)
        {
            string[] filePaths = Directory.GetFiles(labelPathSource.Text);

            foreach (string path in filePaths)
            {
                string newPath = pathTarget;
                string fileName = "\\" + path.Split('\\').Last();

                string year = fileName.Split('-')[0];
                string number = '\\' + fileName.Split('-')[1];

                newPath = newPath + year + number;

                if (!Directory.Exists(pathTarget + year))
                {
                    Directory.CreateDirectory(pathTarget + year + '\\');
                }
                if (!Directory.Exists(pathTarget + year + number))
                {
                    Directory.CreateDirectory(pathTarget + year + number + '\\');
                }

                File.Copy(labelPathSource.Text + fileName, newPath + fileName, true);
            }
        }

        private void DeleteFiles(string pathSource)
        {
            string[] filePaths = Directory.GetFiles(pathSource);

            foreach(string path in filePaths)
            {
                File.Delete(path);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            konumlarıKaydetToolStripMenuItem_Click(sender, e);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            labelInfo.Text = "";
        }
    }
}
