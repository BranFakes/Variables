using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variables:");




            // DECLARING A integer:
            int score; // create an interger variable named, "score"
            score = 0; // assign 0 to score 

            Console.WriteLine(score); // accessing a variable

            Console.WriteLine("score"); // NOT accessing a variable


            // = means "to set the value" of in code

            score = score + 100; // add "+" to score. defeating an enemy for addional points
            Console.WriteLine(score); // accessing a variable (you need this line for # to appear)

            score = score + 100; //defeating an enemy for addional points
            Console.WriteLine(score); // accessing a variable (you need "Console.Writeline for # to appear)



            // -------------STRINGS------------------------------


            string userName;   // DECLARING a string variable named, "name or userName"
            userName = "Brandon"; // setting a string variable to something.. ex a name.
            Console.WriteLine(userName);
            userName = "Carlos";
            Console.WriteLine(userName);

            string firstName; 
            string lastName; 
            string fullName;
            
            firstName = "Brandon";
            lastName = "Vanbuskirk";
            fullName = firstName + lastName;

            //NEEDS THESE COMMANDS TO ALLOW A WRITELINE IN ANY PROGRAM!!
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(fullName);


            //-------------FLOATS-------------------------

            // FLOAT = "floating point" numbers = real numbers
            // 10000000000.00   
            // 100000.00000000000
            // 1.0000000000000


            float speed; // kph
            float distanceTravelled; // in kms
            speed = 100; // pointless due to 100.0f. it will be overwritten. "f" tells its a float. 100.0f = 100 float.
            speed = 100.0f; // kph
            distanceTravelled = 0.0f; // kms

            Console.WriteLine("Speedometer: " + speed);
            Console.WriteLine("odometer: " + distanceTravelled);


            // ------------------ INTS vs. FLOATS------------------
            int intTest; // bad naming
            float floatTest; // bad naming
            float floatTest2;
            intTest = 10 / 3; // 3 ???
            floatTest = 10 / 3; // 3.333 ???
            floatTest2 = 10.0f / 3.0f; // 3.333
            Console.WriteLine(intTest);
            Console.WriteLine(floatTest);
            Console.WriteLine(floatTest2);



            Console.ReadKey(true); // wait for keypress before exiting



        }
    }
}
