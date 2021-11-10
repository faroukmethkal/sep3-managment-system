namespace BlazorSep3.model
{
    public class Account
    {
        public string username { get; set; }
        public string password { get; set; }

        public string Token { get; set; }

        public string Role { get; set; }

        public override string ToString()
        {
            return $@"Username: {username} Password: {password} has been returned from spring";
        }
    }
}