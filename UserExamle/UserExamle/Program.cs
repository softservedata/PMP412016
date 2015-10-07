using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UserExamle.Data;

namespace UserExamle
{
    class Program
    {
        static void Main(string[] args)
        {
            //User user = new User("11", "22", "33", "44", "55");
            //IUser user = new User()
            IUser user = User.get()
                .setLogin("11")
                .setFirsname("22")
                .setLastname("33")
                .setPassword("44")
                .setEmail("55");
            //Console.WriteLine("login=" + user.login);
            Console.WriteLine("login=" + user.getLogin());
            //
            //By by = new By("aa");
            By by = By.getById("aa");
            Console.WriteLine("End");
        }
    }
}
