namespace MeetingApp.Models
{
    public class Repository
    {
        private static List<UserInfo> _users = new();

        static Repository()
        {
            _users.Add(new UserInfo() { Name = "Mervan", Email="mer@asd.com", Phone="546", WillAttend = true});
            _users.Add(new UserInfo() { Name = "İso", Email="iso@asd.com", Phone="534", WillAttend = true});
            _users.Add(new UserInfo() { Name = "Can", Email="can@asd.com", Phone="539", WillAttend = true}); 
        }

        public static List<UserInfo> Users {
            get {
                return _users;
            }
        }

        public static void CreateUser(UserInfo user)
        {
            _users.Add(user);
        }
    }
}