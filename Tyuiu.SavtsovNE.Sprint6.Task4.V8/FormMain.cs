using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Tyuiu.SavtsovNE.Sprint6.Task4.V8.Lib;

namespace Tyuiu.SavtsovNE.Sprint6.Task4.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_ZYV_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_ZYV.Text);
                int stopStep = Convert.ToInt32(textBoxFinish_ZYV.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                //this.chartFunction.Titles.Add("График функций sin(x)");

                this.chartFunction_ZYV.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFunction_ZYV.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxRezult_ZYV.Text = "";

                chartFunction_ZYV.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_ZYV.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxRezult_ZYV.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }


            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxRezult_ZYV.Text);

                DialogResult dialogResult = MessageBox.Show("Фаил" + path + "сохранен успешно! \n открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_ZYV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task4.V8. Выполнила студентка группы ПКТБ 23-2, Захарова Юлиана", "Сообщение");
        }
    }
}