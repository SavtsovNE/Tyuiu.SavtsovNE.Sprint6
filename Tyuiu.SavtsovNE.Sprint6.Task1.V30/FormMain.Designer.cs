namespace Tyuiu.SavtsovNE.Sprint6.Task1.V30
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
            textBoxStartValue_SRR = new TextBox();
            textBoxStopValue_SRR = new TextBox();
            buttonDone_SRR = new Button();
            textBoxResult_SRR = new TextBox();
            buttonInfo_SRR = new Button();
            SuspendLayout();
            // 
            // textBoxStartValue_SRR
            // 
            textBoxStartValue_SRR.Location = new Point(31, 13);
            textBoxStartValue_SRR.Name = "textBoxStartValue_SRR";
            textBoxStartValue_SRR.Size = new Size(278, 23);
            textBoxStartValue_SRR.TabIndex = 0;
            // 
            // textBoxStopValue_SRR
            // 
            textBoxStopValue_SRR.Location = new Point(36, 53);
            textBoxStopValue_SRR.Name = "textBoxStopValue_SRR";
            textBoxStopValue_SRR.Size = new Size(273, 23);
            textBoxStopValue_SRR.TabIndex = 1;
            // 
            // buttonDone_SRR
            // 
            buttonDone_SRR.Location = new Point(36, 168);
            buttonDone_SRR.Name = "buttonDone_SRR";
            buttonDone_SRR.Size = new Size(75, 23);
            buttonDone_SRR.TabIndex = 2;
            buttonDone_SRR.Text = "button1";
            buttonDone_SRR.UseVisualStyleBackColor = true;
            // 
            // textBoxResult_SRR
            // 
            textBoxResult_SRR.Location = new Point(39, 92);
            textBoxResult_SRR.Name = "textBoxResult_SRR";
            textBoxResult_SRR.Size = new Size(270, 23);
            textBoxResult_SRR.TabIndex = 3;
            // 
            // buttonInfo_SRR
            // 
            buttonInfo_SRR.Location = new Point(36, 208);
            buttonInfo_SRR.Name = "buttonInfo_SRR";
            buttonInfo_SRR.Size = new Size(75, 23);
            buttonInfo_SRR.TabIndex = 4;
            buttonInfo_SRR.Text = "button1";
            buttonInfo_SRR.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonInfo_SRR);
            Controls.Add(textBoxResult_SRR);
            Controls.Add(buttonDone_SRR);
            Controls.Add(textBoxStopValue_SRR);
            Controls.Add(textBoxStartValue_SRR);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxStartValue_SRR;
        private TextBox textBoxStopValue_SRR;
        private Button buttonDone_SRR;
        private TextBox textBoxResult_SRR;
        private Button buttonInfo_SRR;
    }
}
