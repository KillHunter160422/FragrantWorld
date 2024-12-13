namespace FragrantWorld
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            registrationName = new Label();
            reg_NameTextBox = new TextBox();
            registrationSurname = new Label();
            reg_SurnameTextBox = new TextBox();
            registrationPatronymic = new Label();
            reg_PatronymicTextBox = new TextBox();
            registrationLogin = new Label();
            reg_LoginTextBox = new TextBox();
            registrationPassword = new Label();
            reg_PasswordTextBox = new TextBox();
            registrationRePassword = new Label();
            reg_RePasswordTextBox = new TextBox();
            registrationButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.66194F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33674F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.00132F));
            tableLayoutPanel1.Controls.Add(registrationName, 1, 0);
            tableLayoutPanel1.Controls.Add(reg_NameTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(registrationSurname, 1, 2);
            tableLayoutPanel1.Controls.Add(reg_SurnameTextBox, 1, 3);
            tableLayoutPanel1.Controls.Add(registrationPatronymic, 1, 4);
            tableLayoutPanel1.Controls.Add(reg_PatronymicTextBox, 1, 5);
            tableLayoutPanel1.Controls.Add(registrationLogin, 1, 6);
            tableLayoutPanel1.Controls.Add(reg_LoginTextBox, 1, 7);
            tableLayoutPanel1.Controls.Add(registrationPassword, 1, 8);
            tableLayoutPanel1.Controls.Add(reg_PasswordTextBox, 1, 9);
            tableLayoutPanel1.Controls.Add(registrationRePassword, 1, 10);
            tableLayoutPanel1.Controls.Add(reg_RePasswordTextBox, 1, 11);
            tableLayoutPanel1.Controls.Add(registrationButton, 1, 12);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 13;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel1.Size = new Size(824, 463);
            tableLayoutPanel1.TabIndex = 80;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // registrationName
            // 
            registrationName.AutoSize = true;
            registrationName.Font = new Font("Comic Sans MS", 9F);
            registrationName.Location = new Point(329, 0);
            registrationName.Name = "registrationName";
            registrationName.Size = new Size(39, 20);
            registrationName.TabIndex = 73;
            registrationName.Text = "Имя";
            // 
            // reg_NameTextBox
            // 
            reg_NameTextBox.BackColor = SystemColors.Control;
            reg_NameTextBox.Location = new Point(329, 33);
            reg_NameTextBox.MaxLength = 32;
            reg_NameTextBox.Name = "reg_NameTextBox";
            reg_NameTextBox.Size = new Size(196, 28);
            reg_NameTextBox.TabIndex = 71;
            // 
            // registrationSurname
            // 
            registrationSurname.AutoSize = true;
            registrationSurname.Font = new Font("Comic Sans MS", 9F);
            registrationSurname.Location = new Point(329, 69);
            registrationSurname.Name = "registrationSurname";
            registrationSurname.Size = new Size(76, 20);
            registrationSurname.TabIndex = 74;
            registrationSurname.Text = "Фамилия";
            // 
            // reg_SurnameTextBox
            // 
            reg_SurnameTextBox.BackColor = SystemColors.Control;
            reg_SurnameTextBox.Location = new Point(329, 102);
            reg_SurnameTextBox.MaxLength = 32;
            reg_SurnameTextBox.Name = "reg_SurnameTextBox";
            reg_SurnameTextBox.Size = new Size(196, 28);
            reg_SurnameTextBox.TabIndex = 76;
            // 
            // registrationPatronymic
            // 
            registrationPatronymic.AutoSize = true;
            registrationPatronymic.Font = new Font("Comic Sans MS", 9F);
            registrationPatronymic.Location = new Point(329, 138);
            registrationPatronymic.Name = "registrationPatronymic";
            registrationPatronymic.Size = new Size(162, 20);
            registrationPatronymic.TabIndex = 75;
            registrationPatronymic.Text = "Отчество (если есть)";
            // 
            // reg_PatronymicTextBox
            // 
            reg_PatronymicTextBox.BackColor = SystemColors.Control;
            reg_PatronymicTextBox.Location = new Point(329, 171);
            reg_PatronymicTextBox.MaxLength = 32;
            reg_PatronymicTextBox.Name = "reg_PatronymicTextBox";
            reg_PatronymicTextBox.Size = new Size(196, 28);
            reg_PatronymicTextBox.TabIndex = 77;
            // 
            // registrationLogin
            // 
            registrationLogin.AutoSize = true;
            registrationLogin.Font = new Font("Comic Sans MS", 9F);
            registrationLogin.Location = new Point(329, 207);
            registrationLogin.Name = "registrationLogin";
            registrationLogin.Size = new Size(54, 20);
            registrationLogin.TabIndex = 78;
            registrationLogin.Text = "Логин";
            // 
            // reg_LoginTextBox
            // 
            reg_LoginTextBox.BackColor = SystemColors.Control;
            reg_LoginTextBox.Location = new Point(329, 240);
            reg_LoginTextBox.MaxLength = 32;
            reg_LoginTextBox.Name = "reg_LoginTextBox";
            reg_LoginTextBox.Size = new Size(196, 28);
            reg_LoginTextBox.TabIndex = 79;
            // 
            // registrationPassword
            // 
            registrationPassword.AutoSize = true;
            registrationPassword.Font = new Font("Comic Sans MS", 9F);
            registrationPassword.Location = new Point(329, 276);
            registrationPassword.Name = "registrationPassword";
            registrationPassword.Size = new Size(65, 20);
            registrationPassword.TabIndex = 72;
            registrationPassword.Text = "Пароль";
            // 
            // reg_PasswordTextBox
            // 
            reg_PasswordTextBox.BackColor = SystemColors.Control;
            reg_PasswordTextBox.Location = new Point(329, 309);
            reg_PasswordTextBox.MaxLength = 28;
            reg_PasswordTextBox.Name = "reg_PasswordTextBox";
            reg_PasswordTextBox.PasswordChar = '*';
            reg_PasswordTextBox.Size = new Size(196, 28);
            reg_PasswordTextBox.TabIndex = 67;
            reg_PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // registrationRePassword
            // 
            registrationRePassword.AutoSize = true;
            registrationRePassword.Font = new Font("Comic Sans MS", 9F);
            registrationRePassword.Location = new Point(329, 345);
            registrationRePassword.Name = "registrationRePassword";
            registrationRePassword.Size = new Size(149, 20);
            registrationRePassword.TabIndex = 70;
            registrationRePassword.Text = "Повторите пароль:";
            registrationRePassword.Click += registrationRePassword_Click;
            // 
            // reg_RePasswordTextBox
            // 
            reg_RePasswordTextBox.BackColor = SystemColors.Control;
            reg_RePasswordTextBox.Location = new Point(329, 378);
            reg_RePasswordTextBox.MaxLength = 28;
            reg_RePasswordTextBox.Name = "reg_RePasswordTextBox";
            reg_RePasswordTextBox.Size = new Size(196, 28);
            reg_RePasswordTextBox.TabIndex = 68;
            reg_RePasswordTextBox.UseSystemPasswordChar = true;
            // 
            // registrationButton
            // 
            registrationButton.BackColor = Color.DarkOrange;
            registrationButton.Location = new Point(329, 417);
            registrationButton.Name = "registrationButton";
            registrationButton.Size = new Size(197, 34);
            registrationButton.TabIndex = 69;
            registrationButton.Text = "Зарегистрироваться";
            registrationButton.UseVisualStyleBackColor = false;
            registrationButton.Click += registrationButton_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(824, 463);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Comic Sans MS", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(842, 510);
            Name = "RegistrationForm";
            Text = "Registration";
            Load += RegistrationForm_Load;
            Resize += RegistrationForm_Resize;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label registrationName;
        private Label registrationSurname;
        private Label registrationPatronymic;
        private TextBox reg_LoginTextBox;
        private Label registrationLogin;
        private TextBox reg_PatronymicTextBox;
        private TextBox reg_SurnameTextBox;
        private Label registrationPassword;
        private TextBox reg_NameTextBox;
        private Label registrationRePassword;
        private TextBox reg_RePasswordTextBox;
        private TextBox reg_PasswordTextBox;
        private Button registrationButton;
        private TableLayoutPanel tableLayoutPanel1;
    }
}