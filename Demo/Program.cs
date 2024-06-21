using System.Drawing;
using System.Runtime.InteropServices;

namespace Demo
{
    class point 
    {
        public int X;
        public int Y;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            #region Commments
            // Single line Comment
            /**
             * Multi
             * line
             *Comment 
             */ 
            #endregion

            #region Varible Declaretions
            int Id = 10;
            //PascalCase = fristName
            //camelCase = fristName
            //Kabab-case = frist-name [Anglurs Files Naming ]
            //snake_case = frist_name
            Console.WriteLine(Id);
            #endregion

            #region ValueType
            int x;
            x = 3;
            int y = 4;
            y = x;
            Console.WriteLine(y);
            x++;
            Console.WriteLine(x);
            #endregion

            #region CodeValue Type
            int x;
            // CLR will UnInitialized 4 Bytes at Stack 
            //int : C# KeyWord
            x = 5;

            Int32 y = 10;
            // CLR will UnInitialized 4 Bytes at Stack 
            //int32 : BCL
            y = x; //5
            x++;  //6
            Console.WriteLine(y);
            Console.WriteLine(x);

            #endregion

            #region Reference Type
            
            Point P1;
            /// Declare for references of type 'point', references to Null
            /// This References 'p1' can  refer to an object from type 'point' or anther type 'Inhereting from point
            /// CLR will allocate 4 Byts for thr References at Stack
            /// CLR will allocate 0 Byts for thr References atHeap
            
            P1 = new Point();
            ///1.Allocate required Number of bytes in Heap
            ///2.Initialized allocated of it Bytes with Defulte Value of its DataType
            ///3.Call user Defined Constructor of Exsist
            ///4.Assign the references with allocated object
            Console.WriteLine(P1.X);
            Console.WriteLine(P1.Y);

            Point P2 = new Point();
            P2 = P1;
            P2.X = 10;

            Console.WriteLine(P1.X);
            #endregion

            
            #region Fractions and Discard
            float X = 25.5f;
            double Y = 2.5;
            decimal Z = 555.66M;


            //Discard => just for reabability
            long Number = 100_000_000_000;

            Console.WriteLine(Number);

            #endregion
            #region Implict casting VS Explict Casting
            ///int x = 10;
            /// long y =/*long*/ x;// Implict Casting
            ///Console.WriteLine(y);//10

            ///long x = 8 ;
            /// x = 445555527552454;


            ///int y = x.GetType() == typeof(int) ? (int)x : 0;// Explict Casting [unsafe casting] 

            ///   Console.WriteLine(y); 

            ///  checked
            /// {
            ///  int y = /*int*/ x;// Explict Casting [unsafe casting] 

            /// unchecked
            ///  {
            ///  Console.WriteLine(y); 
            /// }
            //// }
            ///int x = 5;
            ///double y = x;
            /// Console.WriteLine(y);


            /// double x = 5.5;
            ///int y = x; // explicit casting
            /// Console.WriteLine(y);//5

            #endregion


            #region Covert
            //[Convert: is A Class containing set f methods used for casting from datatype to anther ]
            Console.Write("please enter your name");
            string name = Console.ReadLine() ?? "NA";

            Console.Write("please enter your age");
            int Age = Convert.ToInt32 (Console.ReadLine());

            Console.Write("please enter your salary");
            decimal Salary = Convert.ToDecimal(Console.ReadLine());

            Console.Clear();
            Console.Beep(324,3000);
            Console.WriteLine("your name is" + name);
            Console.WriteLine("your Age is" + Age);
            Console.WriteLine("your salary is" + Salary);

            #endregion

            #region Parse
            //[Parse: is A Class containing set f methods used for casting from String to the coller datatype]
            Console.Write("please enter your name");
            string name = Console.ReadLine() ?? "NA";

            Console.Write("please enter your age");
            int Age = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("please enter your salary");
            decimal Salary = Decimal.Parse(Console.ReadLine() ?? "0");

            Console.Clear();
            Console.Beep(324, 3000);
            Console.WriteLine("your name is" + name);
            Console.WriteLine("your Age is" + Age);
            Console.WriteLine("your salary is" + Salary);


            #endregion

            /// string x = "10",
            /// x = "ahmed";
            ///int y = int.Parse(x);
            ///Console.WriteLine(y);

           /// string x = "true";
            ///x = "Hamada";
           /// bool flag = Convert.ToBoolean(x);
            ///Console.WriteLine(flag); // true


        }
    }
}
