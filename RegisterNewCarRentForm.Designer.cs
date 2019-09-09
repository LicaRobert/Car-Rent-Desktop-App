namespace RentCarDesktopApp
{
    partial class RegisterNewCarRentForm
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
            this.clientIDTextBox = new System.Windows.Forms.TextBox();
            this.startDateTextBox = new System.Windows.Forms.TextBox();
            this.endDateTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.insertCarBtn = new System.Windows.Forms.Button();
            this.BackToMenuBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // carModelLabel
            // 
            this.carModelLabel.AutoSize = true;
            this.carModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carModelLabel.Location = new System.Drawing.Point(25, 22);
            this.carModelLabel.Name = "carModelLabel";
            this.carModelLabel.Size = new System.Drawing.Size(79, 16);
            this.carModelLabel.TabIndex = 0;
            this.carModelLabel.Text = "Car Model";
            // 
            // clientIDLabel
            // 
            this.clientIDLabel.AutoSize = true;
            this.clientIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientIDLabel.Location = new System.Drawing.Point(30, 66);
            this.clientIDLabel.Name = "clientIDLabel";
            this.clientIDLabel.Size = new System.Drawing.Size(70, 16);
            this.clientIDLabel.TabIndex = 1;
            this.clientIDLabel.Text = "Client ID ";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateLabel.Location = new System.Drawing.Point(24, 112);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(81, 16);
            this.startDateLabel.TabIndex = 2;
            this.startDateLabel.Text = "Start Date ";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateLabel.Location = new System.Drawing.Point(24, 155);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(76, 16);
            this.endDateLabel.TabIndex = 3;
            this.endDateLabel.Text = "End Date ";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(30, 199);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(38, 16);
            this.cityLabel.TabIndex = 4;
            this.cityLabel.Text = "City ";
            // 
            // carModelTextBox
            // 
            this.carModelTextBox.Location = new System.Drawing.Point(121, 18);
            this.carModelTextBox.Name = "carModelTextBox";
            this.carModelTextBox.Size = new System.Drawing.Size(100, 20);
            this.carModelTextBox.TabIndex = 5;
            // 
            // clientIDTextBox
            // 
            this.clientIDTextBox.Location = new System.Drawing.Point(121, 65);
            this.clientIDTextBox.Name = "clientIDTextBox";
            this.clientIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.clientIDTextBox.TabIndex = 6;
            this.clientIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClientIDTextBox_KeyPress);
            // 
            // startDateTextBox
            // 
            this.startDateTextBox.Location = new System.Drawing.Point(121, 111);
            this.startDateTextBox.Name = "startDateTextBox";
            this.startDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.startDateTextBox.TabIndex = 7;
            // 
            // endDateTextBox
            // 
            this.endDateTextBox.Location = new System.Drawing.Point(121, 154);
            this.endDateTextBox.Name = "endDateTextBox";
            this.endDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.endDateTextBox.TabIndex = 8;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(121, 199);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityTextBox.TabIndex = 9;
            // 
            // insertCarBtn
            // 
            this.insertCarBtn.Location = new System.Drawing.Point(223, 246);
            this.insertCarBtn.Name = "insertCarBtn";
            this.insertCarBtn.Size = new System.Drawing.Size(75, 23);
            this.insertCarBtn.TabIndex = 10;
            this.insertCarBtn.Text = "Register Car";
            this.insertCarBtn.UseVisualStyleBackColor = true;
            this.insertCarBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InsertCarBtn_MouseClick);
            // 
            // BackToMenuBtn
            // 
            this.BackToMenuBtn.Location = new System.Drawing.Point(12, 246);
            this.BackToMenuBtn.Name = "BackToMenuBtn";
            this.BackToMenuBtn.Size = new System.Drawing.Size(100, 23);
            this.BackToMenuBtn.TabIndex = 11;
            this.BackToMenuBtn.Text = "Back To Menu";
            this.BackToMenuBtn.UseVisualStyleBackColor = true;
            this.BackToMenuBtn.Click += new System.EventHandler(this.BackToMenuBtn_Click);
            // 
            // RegisterNewCarRentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 281);
            this.Controls.Add(this.BackToMenuBtn);
            this.Controls.Add(this.insertCarBtn);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.endDateTextBox);
            this.Controls.Add(this.startDateTextBox);
            this.Controls.Add(this.clientIDTextBox);
            this.Controls.Add(this.carModelTextBox);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.clientIDLabel);
            this.Controls.Add(this.carModelLabel);
            this.Name = "RegisterNewCarRentForm";
            this.Text = "Register New Car ";
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
        private System.Windows.Forms.TextBox clientIDTextBox;
        private System.Windows.Forms.TextBox startDateTextBox;
        private System.Windows.Forms.TextBox endDateTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Button insertCarBtn;
        private System.Windows.Forms.Button BackToMenuBtn;
    }
}