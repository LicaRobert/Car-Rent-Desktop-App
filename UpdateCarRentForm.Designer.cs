namespace RentCarDesktopApp
{
    partial class UpdateCarRentForm
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
            this.carModelLabel = new System.Windows.Forms.Label();
            this.clientIDLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.carModelTextBox = new System.Windows.Forms.TextBox();
            this.endDateTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.startDateTextBox = new System.Windows.Forms.TextBox();
            this.ClientIDTextBox = new System.Windows.Forms.TextBox();
            this.backToMenuBtn = new System.Windows.Forms.Button();
            this.updateCarBtn = new System.Windows.Forms.Button();
            this.carRentIDLabel = new System.Windows.Forms.Label();
            this.carRentIDTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // carModelLabel
            // 
            this.carModelLabel.AutoSize = true;
            this.carModelLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carModelLabel.Location = new System.Drawing.Point(27, 67);
            this.carModelLabel.Name = "carModelLabel";
            this.carModelLabel.Size = new System.Drawing.Size(82, 16);
            this.carModelLabel.TabIndex = 0;
            this.carModelLabel.Text = "Car Model";
            // 
            // clientIDLabel
            // 
            this.clientIDLabel.AutoSize = true;
            this.clientIDLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientIDLabel.Location = new System.Drawing.Point(27, 103);
            this.clientIDLabel.Name = "clientIDLabel";
            this.clientIDLabel.Size = new System.Drawing.Size(73, 16);
            this.clientIDLabel.TabIndex = 1;
            this.clientIDLabel.Text = "Client ID";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateLabel.Location = new System.Drawing.Point(27, 136);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(88, 16);
            this.startDateLabel.TabIndex = 2;
            this.startDateLabel.Text = "Start Date";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateLabel.Location = new System.Drawing.Point(27, 167);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(76, 16);
            this.endDateLabel.TabIndex = 3;
            this.endDateLabel.Text = "End Date";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(27, 200);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(38, 16);
            this.cityLabel.TabIndex = 4;
            this.cityLabel.Text = "City";
            // 
            // carModelTextBox
            // 
            this.carModelTextBox.Location = new System.Drawing.Point(127, 63);
            this.carModelTextBox.Name = "carModelTextBox";
            this.carModelTextBox.Size = new System.Drawing.Size(100, 20);
            this.carModelTextBox.TabIndex = 5;
            // 
            // endDateTextBox
            // 
            this.endDateTextBox.Location = new System.Drawing.Point(127, 167);
            this.endDateTextBox.Name = "endDateTextBox";
            this.endDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.endDateTextBox.TabIndex = 6;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(127, 196);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityTextBox.TabIndex = 7;
            // 
            // startDateTextBox
            // 
            this.startDateTextBox.Location = new System.Drawing.Point(127, 136);
            this.startDateTextBox.Name = "startDateTextBox";
            this.startDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.startDateTextBox.TabIndex = 8;
            // 
            // ClientIDTextBox
            // 
            this.ClientIDTextBox.Location = new System.Drawing.Point(127, 99);
            this.ClientIDTextBox.Name = "ClientIDTextBox";
            this.ClientIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClientIDTextBox.TabIndex = 9;
            // 
            // backToMenuBtn
            // 
            this.backToMenuBtn.Location = new System.Drawing.Point(19, 246);
            this.backToMenuBtn.Name = "backToMenuBtn";
            this.backToMenuBtn.Size = new System.Drawing.Size(102, 23);
            this.backToMenuBtn.TabIndex = 10;
            this.backToMenuBtn.Text = "Back To Menu";
            this.backToMenuBtn.UseVisualStyleBackColor = true;
            this.backToMenuBtn.Click += new System.EventHandler(this.BackToMenuBtn_Click);
            // 
            // updateCarBtn
            // 
            this.updateCarBtn.Location = new System.Drawing.Point(213, 246);
            this.updateCarBtn.Name = "updateCarBtn";
            this.updateCarBtn.Size = new System.Drawing.Size(75, 23);
            this.updateCarBtn.TabIndex = 11;
            this.updateCarBtn.Text = "Update Car";
            this.updateCarBtn.UseVisualStyleBackColor = true;
            this.updateCarBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UpdateCarBtn_MouseClick);
            // 
            // carRentIDLabel
            // 
            this.carRentIDLabel.AutoSize = true;
            this.carRentIDLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carRentIDLabel.Location = new System.Drawing.Point(27, 28);
            this.carRentIDLabel.Name = "carRentIDLabel";
            this.carRentIDLabel.Size = new System.Drawing.Size(95, 16);
            this.carRentIDLabel.TabIndex = 12;
            this.carRentIDLabel.Text = "Car Rent ID";
            // 
            // carRentIDTextBox
            // 
            this.carRentIDTextBox.Location = new System.Drawing.Point(128, 24);
            this.carRentIDTextBox.Name = "carRentIDTextBox";
            this.carRentIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.carRentIDTextBox.TabIndex = 13;
            // 
            // UpdateCarRentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 281);
            this.Controls.Add(this.carRentIDTextBox);
            this.Controls.Add(this.carRentIDLabel);
            this.Controls.Add(this.updateCarBtn);
            this.Controls.Add(this.backToMenuBtn);
            this.Controls.Add(this.ClientIDTextBox);
            this.Controls.Add(this.startDateTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.endDateTextBox);
            this.Controls.Add(this.carModelTextBox);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.clientIDLabel);
            this.Controls.Add(this.carModelLabel);
            this.Name = "UpdateCarRentForm";
            this.Text = "Update Car Rent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label carModelLabel;
        private System.Windows.Forms.Label clientIDLabel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox carModelTextBox;
        private System.Windows.Forms.TextBox endDateTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox startDateTextBox;
        private System.Windows.Forms.TextBox ClientIDTextBox;
        private System.Windows.Forms.Button backToMenuBtn;
        private System.Windows.Forms.Button updateCarBtn;
        private System.Windows.Forms.Label carRentIDLabel;
        private System.Windows.Forms.TextBox carRentIDTextBox;
    }
}