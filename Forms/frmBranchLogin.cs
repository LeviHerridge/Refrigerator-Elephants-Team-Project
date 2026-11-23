namespace OOP_TEAM_PROJECT
{
    // Branch login form
    public class frmBranchLogin : Form
    {
        private string branchName;
        private TextBox txtUsername = new TextBox();
        private TextBox txtPassword = new TextBox();
        private Button btnLogIn = new Button();
        private Button btnCancel = new Button();
        private Label lblError = new Label();

        public frmBranchLogin(string branchName)
        {
            this.branchName = branchName;

            Text = branchName + " Branch Login";
            ClientSize = new Size(300, 220);
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;

            Label lblUser = new Label { Text = "Branch username:", Location = new Point(20, 20), AutoSize = true };
            txtUsername.Location = new Point(20, 40);
            txtUsername.Width = 250;

            Label lblPass = new Label { Text = "Branch password:", Location = new Point(20, 75), AutoSize = true };
            txtPassword.Location = new Point(20, 95);
            txtPassword.Width = 250;
            txtPassword.UseSystemPasswordChar = true;

            btnLogIn.Text = "Log In";
            btnLogIn.Location = new Point(20, 135);
            btnLogIn.Click += btnLogIn_Click;

            btnCancel.Text = "Cancel";
            btnCancel.Location = new Point(195, 135);
            btnCancel.DialogResult = DialogResult.Cancel;

            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(20, 175);
            lblError.AutoSize = true;

            AcceptButton = btnLogIn;
            CancelButton = btnCancel;

            Controls.AddRange(new Control[] { lblUser, txtUsername, lblPass, txtPassword, btnLogIn, btnCancel, lblError });
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            var login = Logins.Branches[branchName];   // only this branch's login works

            if (txtUsername.Text == login.User && txtPassword.Text == login.Pass)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                lblError.Text = "Invalid branch username or password.";
                txtPassword.Clear();
            }
        }
    }
}
