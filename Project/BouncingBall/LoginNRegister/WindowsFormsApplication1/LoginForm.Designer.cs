namespace Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.LoginErrorMessage = new System.Windows.Forms.Label();
            this.InfoToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TrainButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(230, 118);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(202, 26);
            this.usernameTextBox.TabIndex = 0;
            this.InfoToolTip.SetToolTip(this.usernameTextBox, "Username should consist only\r\nof Alphanumeric characters\r\n or hyphen and be at le" +
        "ast 5 characters.\r\n");
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(230, 164);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(202, 26);
            this.passwordBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Потребителско име: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Парола: ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Forms.Properties.Resources.rtransparentbutton2;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(42, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Вход";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.Transparent;
            this.registerButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("registerButton.BackgroundImage")));
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.FlatAppearance.BorderSize = 0;
            this.registerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.registerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerButton.Location = new System.Drawing.Point(270, 234);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(200, 50);
            this.registerButton.TabIndex = 5;
            this.registerButton.Text = "Регистрация";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.button2_Click);
            this.registerButton.MouseEnter += new System.EventHandler(this.registerButton_MouseEnter);
            this.registerButton.MouseLeave += new System.EventHandler(this.registerButton_MouseLeave);
            // 
            // LoginErrorMessage
            // 
            this.LoginErrorMessage.AutoSize = true;
            this.LoginErrorMessage.BackColor = System.Drawing.Color.Transparent;
            this.LoginErrorMessage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.LoginErrorMessage.Location = new System.Drawing.Point(146, 202);
            this.LoginErrorMessage.Name = "LoginErrorMessage";
            this.LoginErrorMessage.Size = new System.Drawing.Size(285, 17);
            this.LoginErrorMessage.TabIndex = 6;
            this.LoginErrorMessage.Text = "Моля въведете потребителско име и парола*";
            this.LoginErrorMessage.Visible = false;
            this.LoginErrorMessage.Click += new System.EventHandler(this.LoginErrorMessage_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Forms.Properties.Resources.cooltext1932078896;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(510, 94);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // TrainButton
            // 
            this.TrainButton.BackColor = System.Drawing.Color.Transparent;
            this.TrainButton.BackgroundImage = global::Forms.Properties.Resources.rtransparentbutton2;
            this.TrainButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrainButton.FlatAppearance.BorderSize = 0;
            this.TrainButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.TrainButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.TrainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TrainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrainButton.Location = new System.Drawing.Point(42, 290);
            this.TrainButton.Name = "TrainButton";
            this.TrainButton.Size = new System.Drawing.Size(200, 50);
            this.TrainButton.TabIndex = 9;
            this.TrainButton.Text = "Тренировка";
            this.TrainButton.UseVisualStyleBackColor = false;
            this.TrainButton.Click += new System.EventHandler(this.TrainButton_Click);
            this.TrainButton.MouseEnter += new System.EventHandler(this.TrainButton_MouseEnter);
            this.TrainButton.MouseLeave += new System.EventHandler(this.TrainButton_MouseLeave);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.BackgroundImage = global::Forms.Properties.Resources.rtransparentbutton2;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(270, 290);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(200, 50);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.Text = "Изход";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::Forms.Properties.Resources.Wooow;
            this.ClientSize = new System.Drawing.Size(510, 345);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.TrainButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LoginErrorMessage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label LoginErrorMessage;
        private System.Windows.Forms.ToolTip InfoToolTip;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button TrainButton;
    }
}

