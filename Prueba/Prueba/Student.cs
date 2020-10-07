using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba
{
    class Student
    {
        public string id;
        public string name;

        public string getNameTwice()
        {
            return this.name + this.name;
        }
    }
}
