using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionName.BLL
{
    public class Class3
    {
        Class2 class2 = new Class2();

        public void GetClass2 ()
        {
            class2.Name = "Peter";
            class2.SurnameName = "Sven";
            class2.MakeClassInstace();
            class2.GetName();
        }
    }
}
