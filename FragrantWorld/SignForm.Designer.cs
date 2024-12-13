namespace FragrantWorld
{
    partial class SignForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            sign_LoginLbl = new Label();
            sign_LoginTextBox = new TextBox();
            sign_PasswordLbl = new Label();
            sign_PasswordTextBox = new TextBox();
            sign_ForgotLinkLbl = new LinkLabel();
            button1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.66F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27F));
            tableLayoutPanel1.Controls.Add(sign_LoginLbl, 1, 1);
            tableLayoutPanel1.Controls.Add(sign_LoginTextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(sign_PasswordLbl, 1, 3);
            tableLayoutPanel1.Controls.Add(sign_PasswordTextBox, 1, 4);
            tableLayoutPanel1.Controls.Add(sign_ForgotLinkLbl, 1, 5);
            tableLayoutPanel1.Controls.Add(button1, 1, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // sign_LoginLbl
            // 
            sign_LoginLbl.AutoSize = true;
            sign_LoginLbl.Location = new Point(320, 130);
            sign_LoginLbl.Name = "sign_LoginLbl";
            sign_LoginLbl.Size = new Size(58, 20);
            sign_LoginLbl.TabIndex = 0;
            sign_LoginLbl.Text = "Логин:";
            // 
            // sign_LoginTextBox
            // 
            sign_LoginTextBox.BackColor = Color.FromArgb(204, 102, 0);
            sign_LoginTextBox.Location = new Point(320, 163);
            sign_LoginTextBox.MaxLength = 32;
            sign_LoginTextBox.Name = "sign_LoginTextBox";
            sign_LoginTextBox.Size = new Size(196, 28);
            sign_LoginTextBox.TabIndex = 1;
            // 
            // sign_PasswordLbl
            // 
            sign_PasswordLbl.AutoSize = true;
            sign_PasswordLbl.Location = new Point(320, 190);
            sign_PasswordLbl.Name = "sign_PasswordLbl";
            sign_PasswordLbl.Size = new Size(69, 20);
            sign_PasswordLbl.TabIndex = 2;
            sign_PasswordLbl.Text = "Пароль:";
            // 
            // sign_PasswordTextBox
            // 
            sign_PasswordTextBox.BackColor = Color.FromArgb(204, 102, 0);
            sign_PasswordTextBox.Location = new Point(320, 223);
            sign_PasswordTextBox.Name = "sign_PasswordTextBox";
            sign_PasswordTextBox.Size = new Size(196, 28);
            sign_PasswordTextBox.TabIndex = 3;
            // 
            // sign_ForgotLinkLbl
            // 
            sign_ForgotLinkLbl.ActiveLinkColor = Color.RosyBrown;
            sign_ForgotLinkLbl.AutoSize = true;
            sign_ForgotLinkLbl.BackColor = Color.White;
            sign_ForgotLinkLbl.DisabledLinkColor = Color.White;
            sign_ForgotLinkLbl.LinkBehavior = LinkBehavior.NeverUnderline;
            sign_ForgotLinkLbl.LinkColor = Color.FromArgb(204, 102, 0);
            sign_ForgotLinkLbl.Location = new Point(320, 250);
            sign_ForgotLinkLbl.Name = "sign_ForgotLinkLbl";
            sign_ForgotLinkLbl.Size = new Size(130, 20);
            sign_ForgotLinkLbl.TabIndex = 4;
            sign_ForgotLinkLbl.TabStop = true;
            sign_ForgotLinkLbl.Text = "Забыли пароль?";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(204, 102, 0);
            button1.Location = new Point(320, 283);
            button1.Name = "button1";
            button1.Size = new Size(196, 33);
            button1.TabIndex = 5;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // SignForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SignForm";
            Text = "Sign";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label sign_LoginLbl;
        private TextBox sign_LoginTextBox;
        private TextBox sign_PasswordTextBox;
        private Label sign_PasswordLbl;
        private LinkLabel sign_ForgotLinkLbl;
        private Button button1;
    }
}