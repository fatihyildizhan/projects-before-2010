namespace vs2015webapi
{
    public class PersonForgotPassword
    {
        //   public string Email { get; set; }
        public string username { get; set; }
        public string newPassword { get; set; }
        public int code { get; set; }
    }

    public class PersonEmail
    {
        public string email { get; set; }
    }
}
