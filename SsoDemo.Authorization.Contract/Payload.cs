namespace SsoDemo.Authorization.Contract
{
    public class Payload
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public string SystemRole { get; set; }
    }
}
