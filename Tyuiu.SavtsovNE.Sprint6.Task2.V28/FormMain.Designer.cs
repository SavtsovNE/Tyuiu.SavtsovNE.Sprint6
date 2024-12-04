
namespace Tyuiu.SavtsovNE.Sprint6.Task2.V28
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxVarA_LVA = new TextBox();
            textBoxVarB_LVA = new TextBox();
            buttonResult_LVA = new Button();
            dataGridViewFunction_LVA = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_LVA).BeginInit();
            SuspendLayout();
            // 
            // textBoxVarA_LVA
            // 
            textBoxVarA_LVA.Location = new Point(40, 37);
            textBoxVarA_LVA.Name = "textBoxVarA_LVA";
            textBoxVarA_LVA.Size = new Size(100, 23);
            textBoxVarA_LVA.TabIndex = 0;
            // 
            // textBoxVarB_LVA
            // 
            textBoxVarB_LVA.Location = new Point(40, 89);
            textBoxVarB_LVA.Name = "textBoxVarB_LVA";
            textBoxVarB_LVA.Size = new Size(100, 23);
            textBoxVarB_LVA.TabIndex = 1;
            // 
            // buttonResult_LVA
            // 
            buttonResult_LVA.Location = new Point(40, 129);
            buttonResult_LVA.Name = "buttonResult_LVA";
            buttonResult_LVA.Size = new Size(75, 23);
            buttonResult_LVA.TabIndex = 2;
            buttonResult_LVA.Text = "Справка";
            buttonResult_LVA.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFunction_LVA
            // 
            dataGridViewFunction_LVA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_LVA.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            dataGridViewFunction_LVA.Location = new Point(212, 47);
            dataGridViewFunction_LVA.Name = "dataGridViewFunction_LVA";
            dataGridViewFunction_LVA.Size = new Size(240, 150);
            dataGridViewFunction_LVA.TabIndex = 3;
            dataGridViewFunction_LVA.CellContentClick += dataGridViewFunction_LVA_CellContentClick;
            // 
            // X
            // 
            X.HeaderText = "Column1";
            X.Name = "X";
            // 
            // Y
            // 
            Y.HeaderText = "Column1";
            Y.Name = "Y";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewFunction_LVA);
            Controls.Add(buttonResult_LVA);
            Controls.Add(textBoxVarB_LVA);
            Controls.Add(textBoxVarA_LVA);
            Name = "FormMain";
            Text = "FormMain";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_LVA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox textBoxVarA_LVA;
        private TextBox textBoxVarB_LVA;
        private Button buttonResult_LVA;
        private DataGridView dataGridViewFunction_LVA;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}
