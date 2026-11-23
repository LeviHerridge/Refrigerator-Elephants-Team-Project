using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;


namespace OOP_TEAM_PROJECT
{
    // Placeholder branch form (opens only after a correct branch login)
    public class frmBranch : Form
    {
        public frmBranch(string branchName)
        {
            Text = branchName + " Branch";
            ClientSize = new Size(300, 120);
            StartPosition = FormStartPosition.CenterParent;
            string exePath = string.Empty;
            
            if (branchName == "Levi's-Branch")
            {
                exePath = @"C:\Users\levih\source\repos\OOP-TEAM-PROJECT\Levi's-Branch\OOP-Project-Bakery-POS-System.exe";
            }
            else if (branchName == "Enyan's-Branch")
            {
                exePath = @"C:\Users\levih\source\repos\OOP-TEAM-PROJECT\Enyan's-Branch\OOP-Project-Bakery-POS-System.exe";
            }
            else if (branchName == "Dakota's-Branch")
            {
                 exePath = @"C:\Users\levih\source\repos\OOP-TEAM-PROJECT\Dakota's-Branch\OOP-Project-Bakery-POS-System.exe";
            }

            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = exePath,
                    Arguments = "--flag value",
                    UseShellExecute = false,
                    CreateNoWindow = false
                };

                using Process? process = Process.Start(startInfo);
                process?.WaitForExit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening branch directory: " + ex.Message);
            }
            Close();
        }
    }
}