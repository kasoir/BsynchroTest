using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test1.Data;
using Test1.Models;

namespace Test1.Controllers
{
    [EnableCors]
    public class UsersController : Controller
    {
        private readonly IUserRepo _reporsitory;

        public UsersController(IUserRepo reporsitory)
        {
            _reporsitory = reporsitory;
        }

        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            IEnumerable<User> users = _reporsitory.GetUsers();

            return Ok(users);
        }

        [HttpPost]
        public ActionResult ConnectOldAccountToNew([FromForm] int customerId, int initialCredit)
        {
            try
            {             // connect new user with old one
                _reporsitory.ConnectOldAccountToNew(customerId, initialCredit);
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error creating new user record");
            }
        }
    }
}