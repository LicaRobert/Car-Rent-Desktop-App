namespace RentCarDesktopApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.welcomeLabel2 = new System.Windows.Forms.Label();
            this.enterEscLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(33, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(321, 16);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome to Rent Car,your brand new solution";
            // 
            // welcomeLabel2
            // 
            this.welcomeLabel2.AutoSize = true;
            this.welcomeLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel2.Location = new System.Drawing.Point(1, 41);
            this.welcomeLabel2.Name = "welcomeLabel2";
            this.welcomeLabel2.Size = new System.Drawing.Size(400, 13);
            this.welcomeLabel2.TabIndex = 1;
            this.welcomeLabel2.Text = "to manage and control your company\'s data without missing anything.";
            // 
            // enterEscLabel
            // 
            this.enterEscLabel.AutoSize = true;
            this.enterEscLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterEscLabel.Location = new System.Drawing.Point(69, 225);
            this.enterEscLabel.Name = "enterEscLabel";
            this.enterEscLabel.Size = new System.Drawing.Size(269, 16);
            this.enterEscLabel.TabIndex = 2;
            this.enterEscLabel.Text = "Press Enter to continue or ESC to quit.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 261);
            this.Controls.Add(this.enterEscLabel);
            this.Controls.Add(this.welcomeLabel2);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label welcomeLabel2;
        private System.Windows.Forms.Label enterEscLabel;
    }
}

