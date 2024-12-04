namespace Tyuiu.SavtsovNE.Sprint6.Task0.V15
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
            textBoxVarX_KDR = new TextBox();
            buttonDone_KDR = new Button();
            textBoxRes_KDR = new TextBox();
            buttonHelp_KDR = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBoxVarX_KDR
            // 
            textBoxVarX_KDR.Location = new Point(12, 61);
            textBoxVarX_KDR.Name = "textBoxVarX_KDR";
            textBoxVarX_KDR.Size = new Size(100, 23);
            textBoxVarX_KDR.TabIndex = 0;
            // 
            // buttonDone_KDR
            // 
            buttonDone_KDR.Location = new Point(12, 90);
            buttonDone_KDR.Name = "buttonDone_KDR";
            buttonDone_KDR.Size = new Size(75, 23);
            buttonDone_KDR.TabIndex = 1;
            buttonDone_KDR.Text = "button1";
            buttonDone_KDR.UseVisualStyleBackColor = true;
            // 
            // textBoxRes_KDR
            // 
            textBoxRes_KDR.Location = new Point(12, 21);
            textBoxRes_KDR.Name = "textBoxRes_KDR";
            textBoxRes_KDR.Size = new Size(100, 23);
            textBoxRes_KDR.TabIndex = 2;
            // 
            // buttonHelp_KDR
            // 
            buttonHelp_KDR.Location = new Point(12, 141);
            buttonHelp_KDR.Name = "buttonHelp_KDR";
            buttonHelp_KDR.Size = new Size(75, 23);
            buttonHelp_KDR.TabIndex = 3;
            buttonHelp_KDR.Text = "button1";
            buttonHelp_KDR.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(228, 91);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(buttonHelp_KDR);
            Controls.Add(textBoxRes_KDR);
            Controls.Add(buttonDone_KDR);
            Controls.Add(textBoxVarX_KDR);
            Name = "FormMain";
            Text = "textBoxVarX_KDR";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxVarX_KDR;
        private Button buttonDone_KDR;
        private TextBox textBoxRes_KDR;
        private Button buttonHelp_KDR;
        private Label label1;
    }
}
