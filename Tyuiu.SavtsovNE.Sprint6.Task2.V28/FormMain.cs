using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SavtsovNE.Sprint6.Task2.V28.Lib;

namespace Tyuiu.SavtsovNE.Sprint6.Task2.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonResult_LVA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxVarA_LVA.Text);
                int stopStep = Convert.ToInt32(textBoxVarB_LVA.Text);
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.checkedListBox1.Titles.Add("������ ������� ");
                this.checkedListBox1.ChartAreas[0].AxisX.Title = "��� X";
                this.checkedListBox1.ChartAreas[0].AxisY.Title = "��� Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_LVA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.checkedListBox1.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonReference_LVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 2 �������� ������� ������ �����-24-1 ������ ������ ����������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonResult_LVA_MouseEnter(object sender, EventArgs e)
        {
            buttonResult_LVA.BackColor = Color.Red;
        }

        private void buttonResult_LVA_MouseLeave(object sender, EventArgs e)
        {
            buttonResult_LVA.BackColor = Color.Green;

        }

        private void buttonResult_LVA_MouseDown(object sender, MouseEventArgs e)
        {
            buttonResult_LVA.BackColor = Color.Blue;
        }

        private void dataGridViewFunction_LVA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}