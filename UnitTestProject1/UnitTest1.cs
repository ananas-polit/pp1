using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using pp1;


namespace UnitTestProject1
{
    [TestClass]

    public class UnitTest1
    {
        [TestMethod]
        public void Vhod()
        {
            string Login = "a";
            string Password = "ad";
            
            Vhod a = new Vhod();
            //bool result = a.Auth(Login, Password);
            bool result = a.Auth(Login, Password);

        }
        [TestMethod]
        public void Vhod1()
        {
            string Login = "aa";
            string Password = "aad";

            Vhod a = new Vhod();
            //bool result = a.Auth(Login, Password);
            bool result = a.Auth(Login, Password);

        }
    }
}
