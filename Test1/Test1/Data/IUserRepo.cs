using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test1.Models;

namespace Test1.Data
{
    public interface IUserRepo
    {
        IEnumerable<User> GetUsers();
        void ConnectOldAccountToNew(int customerId, int initialCredit);
    }
}
