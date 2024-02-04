namespace MeetingApp.Models
{
    public class Repository
    {
        private static List<UserInfo> _users = new();

        static Repository()
        {
            _users.Add(new UserInfo() { Id=Guid.NewGuid(), Name = "Mervan", Email="mer@asd.com", Phone="546", WillAttend = true});
            _users.Add(new UserInfo() { Id=Guid.NewGuid(), Name = "İso", Email="iso@asd.com", Phone="534", WillAttend = true});
            _users.Add(new UserInfo() { Id=Guid.NewGuid(), Name = "Can", Email="can@asd.com", Phone="539", WillAttend = true}); 
        }

        public static List<UserInfo> Users {
            get {
                return _users;
            }
        }

        public static void CreateUser(UserInfo user)
        {
            // user.Id = Users.Count + 1;
            user.Id = Guid.NewGuid();
            _users.Add(user);
        }

        public static UserInfo? GetById(Guid id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }
}