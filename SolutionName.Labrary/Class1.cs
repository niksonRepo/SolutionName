using System;

namespace SolutionName.BLL
{
    public class Class1: IClass1, IClass3
    {
        public string Name { get; set; }
        
        public string SurnameName { get; set; }

        public Class1()
        {

        }

        public Class1(string variable)
        {

        }

        public void MakeClassInstace()
        {
            //calculation or saving into database
        }

        public string GetName()
        {
            return "Jonh";
        }

        public void GetSurnameNameOfThePerson()
        {
        }

        public string GetNameOfThePerson()
        {
            return "";
        }
    }

    enum Level
    {
        Low = 1,
        Medium = 2,
        High = 3
    }

}
