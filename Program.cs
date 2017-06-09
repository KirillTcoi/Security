using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security  
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList vzdanii = new ArrayList();


            Dog q1 = new Dog();
            Security.Skipper(vzdanii, q1);


            Squirrel q2 = new Squirrel();
            Security.Skipper(vzdanii, q2);


            Employer q3 = new Employer();
            Security.Skipper(vzdanii, q3);


            Student q4 = new Student();
            Security.Skipper(vzdanii, q4);

            foreach (var v in vzdanii)
                Console.WriteLine(v);
            Console.ReadKey();
        }
    }
}
