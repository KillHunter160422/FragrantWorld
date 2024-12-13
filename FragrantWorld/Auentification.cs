namespace FragrantWorld
{
    public partial class FW_Autorization : Form
    {
        public FW_Autorization()
        {
            InitializeComponent();
        }

        private void Sign_Click(object sender, EventArgs e)
        {
        }

        private void FW_Autorization_Load(object sender, EventArgs e)
        {
            Sign.BackColor = Color.FromArgb(204, 102, 0);
            Registration.BackColor = Color.FromArgb(204, 102, 0);
            SignInGuest.LinkColor = Color.FromArgb(204, 102, 0);
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            RegistrationForm registration = new RegistrationForm();
            registration.Show();
            this.Hide();
        }
    }
}
