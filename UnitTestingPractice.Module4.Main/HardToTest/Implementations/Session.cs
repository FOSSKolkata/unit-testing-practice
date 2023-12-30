using System;
using System.Collections.Generic;
using System.Linq;
using UnitTestingPractice.Module4.Main.HardToTest.Interfaces;

namespace UnitTestingPractice.Module4.Main.HardToTest.Implementations
{
    public class Session : ISession
    {
        private readonly Login _login;

        public Session(Login login)
        {
            _login = login;
        }

        public Login GetLogin()
        {
            return _login;
        }
    }
}
