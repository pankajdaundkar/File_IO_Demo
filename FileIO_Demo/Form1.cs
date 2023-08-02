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

namespace FileIO_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butcreatefolder_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\DP4-2-Aug";
                if (Directory.Exists(path))
                {
                    MessageBox.Show("Folder is alredy exists");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("Folder Created");
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butcreatefile_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\DP4-2-Aug\doc1.txt";
                if (File.Exists(path))
                {
                    MessageBox.Show("File is alredy exists");
                }
                else
                {
                    File.Create(path);
                    MessageBox.Show("File Created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnwritefile_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\DP4-2-Aug\Product.dat";

                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                BinaryWriter binaryWriter = new BinaryWriter(fileStream);
                binaryWriter.Write(Convert.ToInt32(txtproid.Text));
                binaryWriter.Write(txtproname.Text);
                binaryWriter.Write(Convert.ToDouble(txtpropri.Text));
                binaryWriter.Close();
                fileStream.Close();
                MessageBox.Show("Done");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnread_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\DP4-2-Aug\Product.dat";

                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(fileStream);
                txtproid.Text=(binaryReader.ReadInt32().ToString());
                txtproname.Text= (binaryReader.ReadString());
                txtpropri.Text = binaryReader.ReadDouble().ToString();
                binaryReader.Close();
                fileStream.Close();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
