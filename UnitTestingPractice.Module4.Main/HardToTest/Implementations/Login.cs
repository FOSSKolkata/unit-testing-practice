using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestingPractice.Module4.Main.HardToTest.Implementations
{
    public class Login
    {
        private readonly User _user;

        public Login(User user)
        {
            _user = user;
        }

        public User GetUser()
        {
            return _user;
        }
    }
}
