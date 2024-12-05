using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.SavtsovNE.Sprint6.Task6.V11.Lib;

namespace Tyuiu.SavtsovNE.Sprint6.Task6.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService service = new DataService( );
        string filePath;

        private void buttonFileInput_Click(object sender, EventArgs e)
        {
            if (openFileDialogTask.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialogTask.FileName;

                try
                {
                    // Чтение содержимого файла с использованием using
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        textBoxInput.Text = reader.ReadToEnd();
                    }
                    groupBoxInput.Text += " " + filePath;
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"Ошибка при чтении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Пожалуйста, выберите файл перед выполнением операции.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                textBoxOutput.Text = service.CollectTextFromFile("", filePath);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Файл не найден. Убедитесь, что путь к файлу корректен.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Ошибка при обработке файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла непредвиденная ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
