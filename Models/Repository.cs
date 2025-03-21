

using MeetingApp.Models;

namespace Meetingapp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new();
        static Repository()
        {
            _users.Add(new UserInfo { Id = 1, Name = "Mehmet", Phone = "123456", Email = "abc@gmail.com", WillAttend = true });
            _users.Add(new UserInfo { Id = 2, Name = "Ali", Phone = "1234567", Email = "abcd@gmail.com", WillAttend = true });
            _users.Add(new UserInfo { Id = 3, Name = "Veli", Phone = "123456888", Email = "abcdef@gmail.com", WillAttend = false });
        }
        public static List<UserInfo> Users
        {
            get
            {
                return _users;
            }
        }

        public static void CreateUser(UserInfo user)
        {
            user.Id = _users.Count + 1;
            _users.Add(user);
        }

        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(i => i.Id == id);


        }
    }
}