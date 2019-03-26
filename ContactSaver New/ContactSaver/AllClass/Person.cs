using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactSaver
{
  public  class Person
    {
     public   string name,age;
      public  Person(String Name,string age)
        {
            Name = name;
            this.age = age;
        }

    public  string getAge()
        {
            return age;
        }
    }
}
