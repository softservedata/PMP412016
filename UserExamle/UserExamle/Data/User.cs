using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserExamle.Data
{
    class User : IUser
    {
        private string login;
        private string firsname;
        private string lastname;
        private string password;
        private string email;

        //public User(string login, string firsname, string lastname, string password, string email)
        //{
        //    this.login = login;
        //    this.firsname = firsname;
        //    this.lastname = lastname;
        //    this.password = password;
        //    this.email = email;
        //}
        
        private User()
        { }

        public static User get()
        {
            return new User();
        }

        // setters - - - - - - - - - - - - - - - - - - - -

        public User setLogin(string login)
        {
            this.login = login;
            return this;
        }

        public User setFirsname(string firsname)
        {
            this.firsname = firsname;
            return this;
        }

        public User setLastname(string lastname)
        {
            this.lastname = lastname;
            return this;
        }

        public User setPassword(string password)
        {
            this.password = password;
            return this;
        }

        public User setEmail(string email)
        {
            this.email = email;
            return this;
        }
        // getters - - - - - - - - - - - - - - - - - - - -

        public string getLogin()
        {
            return login;
        }

        public string getFirsname()
        {
            return firsname;
        }

        public string getLastname()
        {
            return lastname;
        }

        public string getPassword()
        {
            return password;
        }

        public string getEmail()
        {
            return email;
        }
    }
}
