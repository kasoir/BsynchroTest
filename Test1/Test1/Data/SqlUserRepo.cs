using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test1.Models;

namespace Test1.Data
{
    public class SqlUserRepo : IUserRepo
    {
        private readonly UserContext _context;

        public SqlUserRepo(UserContext context)
        {
            _context = context;
        }

        public void ConnectOldAccountToNew(int customerId, int initialCredit)
        {
            User user = new User();
            user.id = customerId;
            user.transactions = initialCredit;
            user.name = "AnyName";
            user.surName = "Test";
            user.balance = 0.0;
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public IEnumerable<User> GetUsers()
        {
            return _context.Users.ToList();
        }
    }
}
