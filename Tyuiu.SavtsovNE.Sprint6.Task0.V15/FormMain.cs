using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SavtsovNE.Sprint6.Task0.V15.Lib;

namespace Tyuiu.SavtsovNE.Sprint6.Task0.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void labelRes_KDR_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_KDR_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxRes_KDR.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_KDR.Text)));

            }
            catch
            {
                MessageBox.Show("�� ����� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_KDR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 0 �������� ������� ������ �����-24-1 ������ ������ ���������� ", "���������", MessageBoxButtons.OK);
        }

        private void textBoxVarX_KDR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }

}