namespace RentCarDesktopApp
{
    partial class RegisterNewCustomerForm
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
            this.clientNameLabel = new System.Windows.Forms.Label();
            this.birthDateLabel = new System.Windows.Forms.Label();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.clientNameTextBox = new System.Windows.Forms.TextBox();
            this.registerCustomerBtn = new System.Windows.Forms.Button();
            this.locationLabel = new System.Windows.Forms.Label();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.ZIPCodeTextBox = new System.Windows.Forms.TextBox();
            this.birthDateTextBox = new System.Windows.Forms.TextBox();
            this.BackToMenuBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clientNameLabel
            // 
            this.clientNameLabel.AutoSize = true;
            this.clientNameLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientNameLabel.Location = new System.Drawing.Point(25, 47);
            this.clientNameLabel.Name = "clientNameLabel";
            this.clientNameLabel.Size = new System.Drawing.Size(97, 16);
            this.clientNameLabel.TabIndex = 1;
            this.clientNameLabel.Text = "Client Name";
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDateLabel.Location = new System.Drawing.Point(25, 90);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Size = new System.Drawing.Size(84, 16);
            this.birthDateLabel.TabIndex = 2;
            this.birthDateLabel.Text = "Birth Date";
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipCodeLabel.Location = new System.Drawing.Point(25, 164);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(76, 16);
            this.zipCodeLabel.TabIndex = 3;
            this.zipCodeLabel.Text = "ZIP Code";
            // 
            // clientNameTextBox
            // 
            this.clientNameTextBox.Location = new System.Drawing.Point(125, 47);
            this.clientNameTextBox.Name = "clientNameTextBox";
            this.clientNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.clientNameTextBox.TabIndex = 6;
            // 
            // registerCustomerBtn
            // 
            this.registerCustomerBtn.Location = new System.Drawing.Point(227, 246);
            this.registerCustomerBtn.Name = "registerCustomerBtn";
            this.registerCustomerBtn.Size = new System.Drawing.Size(75, 23);
            this.registerCustomerBtn.TabIndex = 8;
            this.registerCustomerBtn.Text = "Register";
            this.registerCustomerBtn.UseVisualStyleBackColor = true;
            this.registerCustomerBtn.Click += new System.EventHandler(this.RegisterCustomerBtn_Click);
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.Location = new System.Drawing.Point(29, 126);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(72, 16);
            this.locationLabel.TabIndex = 9;
            this.locationLabel.Text = "Location";
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(125, 126);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(100, 20);
            this.locationTextBox.TabIndex = 10;
            // 
            // ZIPCodeTextBox
            // 
            this.ZIPCodeTextBox.Location = new System.Drawing.Point(125, 164);
            this.ZIPCodeTextBox.Name = "ZIPCodeTextBox";
            this.ZIPCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.ZIPCodeTextBox.TabIndex = 11;
            this.ZIPCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ZIPCodeTextBox_KeyPress);
            // 
            // birthDateTextBox
            // 
            this.birthDateTextBox.Location = new System.Drawing.Point(125, 90);
            this.birthDateTextBox.Name = "birthDateTextBox";
            this.birthDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.birthDateTextBox.TabIndex = 12;
            // 
            // BackToMenuBtn
            // 
            this.BackToMenuBtn.Location = new System.Drawing.Point(12, 246);
            this.BackToMenuBtn.Name = "BackToMenuBtn";
            this.BackToMenuBtn.Size = new System.Drawing.Size(97, 23);
            this.BackToMenuBtn.TabIndex = 13;
            this.BackToMenuBtn.Text = "Back To Menu";
            this.BackToMenuBtn.UseVisualStyleBackColor = true;
            this.BackToMenuBtn.Click += new System.EventHandler(this.BackToMenuBtn_Click);
            // 
            // RegisterNewCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 281);
            this.Controls.Add(this.BackToMenuBtn);
            this.Controls.Add(this.birthDateTextBox);
            this.Controls.Add(this.ZIPCodeTextBox);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.registerCustomerBtn);
            this.Controls.Add(this.clientNameTextBox);
            this.Controls.Add(this.zipCodeLabel);
            this.Controls.Add(this.birthDateLabel);
            this.Controls.Add(this.clientNameLabel);
            this.Name = "RegisterNewCustomerForm";
            this.Text = "Register New Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label clientNameLabel;
        private System.Windows.Forms.Label birthDateLabel;
        private System.Windows.Forms.Label zipCodeLabel;
        private System.Windows.Forms.Button registerCustomerBtn;
        private System.Windows.Forms.Label locationLabel;
        public System.Windows.Forms.TextBox locationTextBox;
        public System.Windows.Forms.TextBox clientNameTextBox;
        private System.Windows.Forms.TextBox ZIPCodeTextBox;
        private System.Windows.Forms.TextBox birthDateTextBox;
        private System.Windows.Forms.Button BackToMenuBtn;
    }
}