namespace FormHomework
{
    partial class Form1
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
            BakuButton = new Button();
            LondonButton = new Button();
            SuspendLayout();
            // 
            // BakuButton
            // 
            BakuButton.BackColor = SystemColors.ButtonShadow;
            BakuButton.ForeColor = Color.Yellow;
            BakuButton.Location = new Point(203, 91);
            BakuButton.Name = "BakuButton";
            BakuButton.Size = new Size(94, 60);
            BakuButton.TabIndex = 0;
            BakuButton.Text = "BAKU";
            BakuButton.UseVisualStyleBackColor = false;
            BakuButton.Click += button1_Click;
            // 
            // LondonButton
            // 
            LondonButton.BackColor = SystemColors.AppWorkspace;
            LondonButton.Location = new Point(465, 89);
            LondonButton.Name = "LondonButton";
            LondonButton.Size = new Size(94, 60);
            LondonButton.TabIndex = 1;
            LondonButton.Text = "LONDON";
            LondonButton.UseVisualStyleBackColor = false;
            LondonButton.Click += LondonButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(LondonButton);
            Controls.Add(BakuButton);
            ForeColor = Color.Red;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BakuButton;
        private Button LondonButton;
    }
}