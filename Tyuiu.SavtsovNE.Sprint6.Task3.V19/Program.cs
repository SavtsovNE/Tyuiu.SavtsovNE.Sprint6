using Tyuiu.SavtsovNE.Sprint6.Task3.V19.Lib;
namespace Tyuiu.SavtsovNE.Sprint6.Task3.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix =
            {
                {4,  32, -20,  27,  21},
                {17, 15, -1, -2, -1},
                {-3, 18, 12, -10, 29},
                {7, -15, 2, -8, 12},
                {-10, 25, 5, 27, 21}
            };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int colums = matrix.Length / rows;

            dataGridViewMatrix_PDA.ColumnCount = colums;
            dataGridViewMatrix_PDA.RowCount = rows;

            for (int i = 0; i < colums; i++)
            {
                dataGridViewMatrix_PDA.Columns[i].Width = 35;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    dataGridViewMatrix_PDA.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }

        private void buttonDown_PDA_Click(object sender, EventArgs e)
        {
            int[,] res = ds.Calculate(matrix);
            int row = res.GetUpperBound(0) + 1;
            int colum = res.Length / row;
            dataGridViewResult_PDA.ColumnCount = colum;
            dataGridViewResult_PDA.RowCount = row;
            for (int i = 0; i < colum; i++)
            {
                dataGridViewResult_PDA.Columns[i].Width = 35;
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < colum; j++)
                {
                    dataGridViewResult_PDA.Rows[i].Cells[j].Value = res[i, j];
                }
            }
        }

        private void buttonQuestion_PDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Савцов Никита Евгеньевич Ибксб-24-1");
        }
    }
}