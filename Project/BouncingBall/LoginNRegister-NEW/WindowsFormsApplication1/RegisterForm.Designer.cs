namespace Forms
{
    partial class RegisterForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.InfoToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.repeatedPasswordBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.registerBufferPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerBufferPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.SkyBlue;
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(69)))), ((int)(((byte)(87)))));
            this.usernameTextBox.Location = new System.Drawing.Point(53, 52);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(335, 26);
            this.usernameTextBox.TabIndex = 0;
            this.InfoToolTip.SetToolTip(this.usernameTextBox, "Потрбителското име трябва да\r\n бъде между 5 и 64 символа и \r\nда е в буквено - циф" +
        "рен формат");
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.Color.SkyBlue;
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(69)))), ((int)(((byte)(87)))));
            this.passwordBox.Location = new System.Drawing.Point(53, 114);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(335, 26);
            this.passwordBox.TabIndex = 1;
            this.InfoToolTip.SetToolTip(this.passwordBox, "Паролата трябва да бъде \r\nмежду 5 и 64 символа");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCyan;
            this.label1.Location = new System.Drawing.Point(52, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Потребителско име";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightCyan;
            this.label2.Location = new System.Drawing.Point(49, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Парола";
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.Transparent;
            this.registerButton.BackgroundImage = global::Forms.Properties.Resources.Button2;
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.FlatAppearance.BorderSize = 0;
            this.registerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.registerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerButton.ForeColor = System.Drawing.Color.LightCyan;
            this.registerButton.Location = new System.Drawing.Point(126, 461);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(210, 55);
            this.registerButton.TabIndex = 7;
            this.registerButton.TabStop = false;
            this.registerButton.Text = "Регистрация";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            this.registerButton.MouseEnter += new System.EventHandler(this.registerButton_MouseEnter);
            this.registerButton.MouseLeave += new System.EventHandler(this.registerButton_MouseLeave);
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.SkyBlue;
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(69)))), ((int)(((byte)(87)))));
            this.emailTextBox.Location = new System.Drawing.Point(53, 248);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(335, 26);
            this.emailTextBox.TabIndex = 4;
            this.InfoToolTip.SetToolTip(this.emailTextBox, "Невалиден имейл");
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BackColor = System.Drawing.Color.SkyBlue;
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(69)))), ((int)(((byte)(87)))));
            this.firstNameTextBox.Location = new System.Drawing.Point(53, 315);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(338, 26);
            this.firstNameTextBox.TabIndex = 5;
            this.InfoToolTip.SetToolTip(this.firstNameTextBox, "Името трябва да бъде в\r\nбуквено - цифрен формат");
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BackColor = System.Drawing.Color.SkyBlue;
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(69)))), ((int)(((byte)(87)))));
            this.lastNameTextBox.Location = new System.Drawing.Point(53, 381);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(338, 26);
            this.lastNameTextBox.TabIndex = 6;
            this.InfoToolTip.SetToolTip(this.lastNameTextBox, "Името трябва да бъде в\r\nбуквено - цифрен формат");
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightCyan;
            this.label3.Location = new System.Drawing.Point(49, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Имейл";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(394, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(394, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "*";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(29, 425);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(385, 21);
            this.errorLabel.TabIndex = 13;
            this.errorLabel.Text = "Полетата маркирани със звезда (*) са задължителни";
            this.errorLabel.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightCyan;
            this.label7.Location = new System.Drawing.Point(49, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Име";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightCyan;
            this.label8.Location = new System.Drawing.Point(49, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Фамилия";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(394, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.LightCyan;
            this.label10.Location = new System.Drawing.Point(49, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(209, 24);
            this.label10.TabIndex = 19;
            this.label10.Text = "Потвърдете паролата";
            // 
            // repeatedPasswordBox
            // 
            this.repeatedPasswordBox.BackColor = System.Drawing.Color.SkyBlue;
            this.repeatedPasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repeatedPasswordBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(69)))), ((int)(((byte)(87)))));
            this.repeatedPasswordBox.Location = new System.Drawing.Point(53, 183);
            this.repeatedPasswordBox.Name = "repeatedPasswordBox";
            this.repeatedPasswordBox.PasswordChar = '*';
            this.repeatedPasswordBox.Size = new System.Drawing.Size(335, 26);
            this.repeatedPasswordBox.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(394, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "*";
            // 
            // registerBufferPicBox
            // 
            this.registerBufferPicBox.BackColor = System.Drawing.Color.Transparent;
            this.registerBufferPicBox.Image = ((System.Drawing.Image)(resources.GetObject("registerBufferPicBox.Image")));
            this.registerBufferPicBox.Location = new System.Drawing.Point(217, 425);
            this.registerBufferPicBox.Name = "registerBufferPicBox";
            this.registerBufferPicBox.Size = new System.Drawing.Size(24, 25);
            this.registerBufferPicBox.TabIndex = 22;
            this.registerBufferPicBox.TabStop = false;
            this.registerBufferPicBox.Visible = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(447, 523);
            this.Controls.Add(this.registerBufferPicBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.repeatedPasswordBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerBufferPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.ToolTip InfoToolTip;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox repeatedPasswordBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox registerBufferPicBox;
    }
}

