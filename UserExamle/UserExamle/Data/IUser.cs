using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserExamle.Data
{
    interface IUser
    {
        string getLogin();

        string getFirsname();

        string getLastname();
 
        string getPassword();

        string getEmail();
    }
}
