namespace OOP_TEAM_PROJECT
{
    // Admin login form (startup form)
    public class frmLogin : Form
    {
        private TextBox txtUsername = new TextBox();
        private TextBox txtPassword = new TextBox();
        private Button btnLogIn = new Button();
        private Button btnExit = new Button();
        private Label lblError = new Label();

        public frmLogin()
        {
            Text = "Olive Bakes Branches Login";
            ClientSize = new Size(300, 220);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;

            Label lblUser = new Label { Text = "Username:", Location = new Point(20, 20), AutoSize = true };
            txtUsername.Location = new Point(20, 40);
            txtUsername.Width = 250;

            Label lblPass = new Label { Text = "Password:", Location = new Point(20, 75), AutoSize = true };
            txtPassword.Location = new Point(20, 95);
            txtPassword.Width = 250;
            txtPassword.UseSystemPasswordChar = true;

            btnLogIn.Text = "Log In";
            btnLogIn.Location = new Point(20, 135);
            btnLogIn.Click += btnLogIn_Click;

            btnExit.Text = "Exit";
            btnExit.Location = new Point(195, 135);
            btnExit.Click += (s, e) => Application.Exit();

            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(20, 175);
            lblError.AutoSize = true;

            AcceptButton = btnLogIn;

            Controls.AddRange(new Control[] { lblUser, txtUsername, lblPass, txtPassword, btnLogIn, btnExit, lblError });
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == Logins.AdminUser && txtPassword.Text == Logins.AdminPass)
            {
                lblError.Text = "";
                txtUsername.Clear();
                txtPassword.Clear();

                Hide();
                frmConsole console = new frmConsole();
                console.ShowDialog();   // returns when the console is closed (Log Out)
                Show();                 // back to the admin login
                txtUsername.Focus();
            }
            else
            {
                lblError.Text = "Invalid username or password.";
                txtPassword.Clear();
            }
        }
    }
}
