using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson6
{
    class Class1
    {
        // PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++
        private int _integerNumber;
        private string _stringVariable;
        private double _doubleNumber = 0.0d;


        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++
        public int IntegerNumber
        {
            get
            {
                return this._integerNumber; // returns value of instance variable
            }

            set
            {
                Console.WriteLine("Setting value");
                this._integerNumber = value * 2; // sets our instance variable
            }
        }

        public string StringVariable
        {
            get
            {
                return this._stringVariable; // Read-Only property
            }
        }

        public double DoubleNumber
        {
            get
            {
                return this._doubleNumber;
            }

            set
            {
                this._doubleNumber = value;
            }
        }



        // CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public Class1(string theString)
        {
            this._stringVariable = theString;
        }


        // PUBLIC METHODS +++++++++++++++++++++++++++++++++++++++++++++++++
        public void show()
        {
            Console.Write("\n");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("IntegerNumber : {0}", this._integerNumber);
            Console.WriteLine("StringVariable: {0}", this._stringVariable);
            Console.WriteLine("DoubleNumber  : {0}", this._doubleNumber);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++");
            Console.Write("\n");
        }
    }
}