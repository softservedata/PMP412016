using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserExamle.Data
{
    class By
    {
        string field;

        //public By(string id)
        //{ 
        //    this.field = id;
        //}

        //public By(string name)
        //{
        //    this.field = name;
        //}

        private By(string field)
        {
            this.field = field;
        }

        public static By getById(string id)
        { 
            // CODE
            return new By(id);
        }

        public static By getByName(string name)
        {
            // CODE
            return new By(name);
        }
    }
}
