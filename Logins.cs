namespace OOP_TEAM_PROJECT
{
    // Hard-coded logins (fine for this project; real apps store hashed passwords in a database).
    internal static class Logins
    {
        // One admin login for the console
        public const string AdminUser = "admin";
        public const string AdminPass = "admin123";

        // One login for each branch: branch name -> (username, password)
        public static readonly Dictionary<string, (string User, string Pass)> Branches =
            new Dictionary<string, (string User, string Pass)>
            {
                { "Levi's-Branch", ("levi", "levi123") },
                { "Enyan's-Branch",   ("enyan",   "enyan123")},
                { "Dakota's-Branch", ("dakota", "dakota123")}
            };
    }
}
