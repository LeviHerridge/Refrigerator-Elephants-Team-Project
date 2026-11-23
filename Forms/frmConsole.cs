namespace OOP_TEAM_PROJECT
{
    // Admin console: one button per branch plus a Log Out button
    public class frmConsole : Form
    {
        public frmConsole()
        {
            Text = "Admin Console";
            ClientSize = new Size(300, 60 + Logins.Branches.Count * 40 + 60);
            StartPosition = FormStartPosition.CenterScreen;

            Label lblTitle = new Label { Text = "Open a branch:", Location = new Point(20, 20), AutoSize = true };
            Controls.Add(lblTitle);

            int y = 50;
            foreach (string branchName in Logins.Branches.Keys)
            {
                Button btnBranch = new Button
                {
                    Text = branchName,
                    Location = new Point(20, y),
                    Size = new Size(250, 30),
                    Tag = branchName
                };
                btnBranch.Click += btnBranch_Click;
                Controls.Add(btnBranch);
                y += 40;
            }

            Button btnLogOut = new Button
            {
                Text = "Log Out",
                Location = new Point(20, y + 10),
                Size = new Size(250, 30)
            };
            btnLogOut.Click += (s, e) => Close();   // closes console, returns to admin login
            Controls.Add(btnLogOut);
        }

        private void btnBranch_Click(object sender, EventArgs e)
        {
            string branchName = (string)((Button)sender).Tag;

            frmBranchLogin branchLogin = new frmBranchLogin(branchName);
            if (branchLogin.ShowDialog() == DialogResult.OK)   // only the right login opens the branch
            {
                frmBranch branch = new frmBranch(branchName);
                branch.ShowDialog();
            }
        }
    }
}
