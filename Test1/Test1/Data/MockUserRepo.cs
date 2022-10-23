using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test1.Models;

namespace Test1.Data
{
    public class MockUserRepo : IUserRepo
    {
        public void ConnectOldAccountToNew(int customerId, int initialCredit)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUsers()
        {
            var users = new List<User> {
                new User{
                    id=0,
                    customerId=0,name="Kasoir",surName="Abbas",balance=0.0,transactions = 0 
                }
            };
            return users;
        }
    }
}
