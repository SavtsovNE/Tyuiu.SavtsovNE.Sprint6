using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SavtsovNE.Sprint6.Task7.V1.Lib;
using System.IO;

namespace Tyuiu.SavtsovNE.Sprint6.Task7.V1
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService( );
        static string path;
        static int coll;
        static int rows;
        public static int[,] mtr(string path)
        {
            string data = File.ReadAllText(path);
            data = data.Replace('\n', '\r');
            string[] lines = data.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            coll = lines[0].Split(';').Length;


            int[,] arr = new int[rows, coll];
            for (int r = 0; r < rows; r++)
            {
                string[] linr = lines[r].Split(';');
                for (int c = 0; c < coll; c++)
                {
                    arr[r, c] = Convert.ToInt32(linr[c]);
                }
            }
            return arr;
        }
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonDone_SAA.Enabled = false;
            buttonSave_SAA.Enabled = false;
        }
        private void buttonOpen_SAA_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            path = openFileDialogTask.FileName;
            int[,] arr = new int[rows, coll];
            arr = mtr(path);
            dataGridViewIn.ColumnCount = coll;
            dataGridViewOut.ColumnCount = coll;
            dataGridViewIn.RowCount = rows;
            dataGridViewOut.RowCount = rows;
            for (int i = 0; i < coll; i++)
            {
                dataGridViewIn.Columns[i].Width = 25;
                dataGridViewOut.Columns[i].Width = 25;
            }
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < coll; c++)
                {
                    dataGridViewIn.Rows[r].Cells[c].Value = arr[r, c];
                }
            }
            buttonDone_SAA.Enabled = true;
        }

        private void buttonDone_SAA_Click(object sender, EventArgs e)
        {
            int[,] arr = new int[rows, coll];
            arr = ds.GetMatrix(path);
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < coll; c++)
                {
                    dataGridViewOut.Rows[r].Cells[c].Value = arr[r, c];
                }
            }
            buttonSave_SAA.Enabled = true;
        }

        private void buttonSave_SAA_Click(object sender, EventArgs e)
        {
            saveFileDialogResult.FileName = "OutPutTask7.csv";
            saveFileDialogResult.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogResult.ShowDialog();

            string path1 = saveFileDialogResult.FileName;
            FileInfo fi = new FileInfo(path1);
            bool fe = fi.Exists;
            if (fe)
            {
                File.Delete(path1);
            }
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < coll; j++)
                {
                    if (j != coll - 1)
                    {
                        str = str + dataGridViewOut.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path1, str + Environment.NewLine);
                str = "";
            }

        }

        private void buttonHelp_SAA_Click(object sender, EventArgs e)
        {
            FormAbout fa = new FormAbout();
            fa.ShowDialog();
        }
    }
}