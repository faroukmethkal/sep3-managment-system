namespace BlazorSep3LoginExample.model
{
    public class LoginUser
    {
        public string username { get; set; }
        public string password { get; set; }

        public override string ToString()
        {
            return $@"Username: {username} Password: {password} has been returned from spring";
        }
    }
}