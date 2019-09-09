namespace RentCarDesktopApp
{
    partial class UpdateCustomerForm
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
            this.clientIDLabel = new System.Windows.Forms.Label();
            this.clientNameLabel = new System.Windows.Forms.Label();
            this.birthDateLabel = new System.Windows.Forms.Label();
            this.ZIPCodeLabel = new System.Windows.Forms.Label();
            this.ZIPCodeTextBox = new System.Windows.Forms.TextBox();
            this.birthDateTextBox = new System.Windows.Forms.TextBox();
            this.clientNameTextBox = new System.Windows.Forms.TextBox();
            this.clientIDTextBox = new System.Windows.Forms.TextBox();
            this.updateCustomerBtn = new System.Windows.Forms.Button();
            this.locationLabel = new System.Windows.Forms.Label();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.backToMenuBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clientIDLabel
            // 
            this.clientIDLabel.AutoSize = true;
            this.clientIDLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientIDLabel.Location = new System.Drawing.Point(28, 27);
            this.clientIDLabel.Name = "clientIDLabel";
            this.clientIDLabel.Size = new System.Drawing.Size(73, 16);
            this.clientIDLabel.TabIndex = 0;
            this.clientIDLabel.Text = "Client ID";
            // 
            // clientNameLabel
            // 
            this.clientNameLabel.AutoSize = true;
            this.clientNameLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientNameLabel.Location = new System.Drawing.Point(28, 66);
            this.clientNameLabel.Name = "clientNameLabel";
            this.clientNameLabel.Size = new System.Drawing.Size(97, 16);
            this.clientNameLabel.TabIndex = 1;
            this.clientNameLabel.Text = "Client Name";
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDateLabel.Location = new System.Drawing.Point(28, 110);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Size = new System.Drawing.Size(84, 16);
            this.birthDateLabel.TabIndex = 2;
            this.birthDateLabel.Text = "Birth Date";
            // 
            // ZIPCodeLabel
            // 
            this.ZIPCodeLabel.AutoSize = true;
            this.ZIPCodeLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZIPCodeLabel.Location = new System.Drawing.Point(29, 195);
            this.ZIPCodeLabel.Name = "ZIPCodeLabel";
            this.ZIPCodeLabel.Size = new System.Drawing.Size(76, 16);
            this.ZIPCodeLabel.TabIndex = 3;
            this.ZIPCodeLabel.Text = "ZIP Code";
            // 
            // ZIPCodeTextBox
            // 
            this.ZIPCodeTextBox.Location = new System.Drawing.Point(131, 195);
            this.ZIPCodeTextBox.Name = "ZIPCodeTextBox";
            this.ZIPCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.ZIPCodeTextBox.TabIndex = 4;
            this.ZIPCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ZIPCodeTextBox_KeyPress);
            // 
            // birthDateTextBox
            // 
            this.birthDateTextBox.Location = new System.Drawing.Point(130, 110);
            this.birthDateTextBox.Name = "birthDateTextBox";
            this.birthDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.birthDateTextBox.TabIndex = 5;
            // 
            // clientNameTextBox
            // 
            this.clientNameTextBox.Location = new System.Drawing.Point(131, 66);
            this.clientNameTextBox.Name = "clientNameTextBox";
            this.clientNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.clientNameTextBox.TabIndex = 6;
            // 
            // clientIDTextBox
            // 
            this.clientIDTextBox.Location = new System.Drawing.Point(130, 25);
            this.clientIDTextBox.Name = "clientIDTextBox";
            this.clientIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.clientIDTextBox.TabIndex = 7;
            // 
            // updateCustomerBtn
            // 
            this.updateCustomerBtn.Location = new System.Drawing.Point(207, 246);
            this.updateCustomerBtn.Name = "updateCustomerBtn";
            this.updateCustomerBtn.Size = new System.Drawing.Size(75, 23);
            this.updateCustomerBtn.TabIndex = 8;
            this.updateCustomerBtn.Text = "Update";
            this.updateCustomerBtn.UseVisualStyleBackColor = true;
            this.updateCustomerBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UpdateCustomerBtn_MouseClick);
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.Location = new System.Drawing.Point(29, 155);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(72, 16);
            this.locationLabel.TabIndex = 9;
            this.locationLabel.Text = "Location";
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(130, 151);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(100, 20);
            this.locationTextBox.TabIndex = 10;
            // 
            // backToMenuBtn
            // 
            this.backToMenuBtn.Location = new System.Drawing.Point(12, 246);
            this.backToMenuBtn.Name = "backToMenuBtn";
            this.backToMenuBtn.Size = new System.Drawing.Size(100, 23);
            this.backToMenuBtn.TabIndex = 11;
            this.backToMenuBtn.Text = "Back To Menu";
            this.backToMenuBtn.UseVisualStyleBackColor = true;
            this.backToMenuBtn.Click += new System.EventHandler(this.BackToMenuBtn_Click);
            // 
            // UpdateCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 281);
            this.Controls.Add(this.backToMenuBtn);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.updateCustomerBtn);
            this.Controls.Add(this.clientIDTextBox);
            this.Controls.Add(this.clientNameTextBox);
            this.Controls.Add(this.birthDateTextBox);
            this.Controls.Add(this.ZIPCodeTextBox);
            this.Controls.Add(this.ZIPCodeLabel);
            this.Controls.Add(this.birthDateLabel);
            this.Controls.Add(this.clientNameLabel);
            this.Controls.Add(this.clientIDLabel);
            this.Name = "UpdateCustomerForm";
            this.Text = "Update Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clientIDLabel;
        private System.Windows.Forms.Label clientNameLabel;
        private System.Windows.Forms.Label birthDateLabel;
        private System.Windows.Forms.Label ZIPCodeLabel;
        private System.Windows.Forms.TextBox ZIPCodeTextBox;
        private System.Windows.Forms.TextBox birthDateTextBox;
        private System.Windows.Forms.TextBox clientNameTextBox;
        private System.Windows.Forms.TextBox clientIDTextBox;
        private System.Windows.Forms.Button updateCustomerBtn;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.Button backToMenuBtn;
    }
}