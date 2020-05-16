namespace BootCamp.Chapter.Examples.DataAccess
{
    public class UsersRepository
    {
        private readonly UsersContext _context;

        public UsersRepository(UsersContext context)
        {
            _context = context;
        }

        public void Create(string name)
        {
            var user = new User()
            {
                Name = "User"
            };

            _context.Users.Add(user);
        }

        public User Get(long id) => _context.Users.Find(id);
    }
}
