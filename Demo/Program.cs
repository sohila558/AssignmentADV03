using AssignmentADV03;

namespace Demo
{

    // Step 01 : Create new Datatype (Delegate)
    public delegate int StringFuncDelegate(string s);
    // New Delegate (Class): Reference (Pointer) can refer to Function or more (Pointer of Functions)
    // These Function must have the same Signature of the delegate : int (String)
    // Regardless Function Name, Parameters Name or Access Modifier

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Delegate Overview
            // Delegat : Feature C#

            // C# Pure OOP

            // Functoinal Programming
            // Event-Driven Programming

            // Java : Pure OOP
            // DP  
            #endregion

            #region DelegateEX01

            // Step 02 : Use Delegate
            //StringFuncDelegate X = StringFunctions.GetCountOfUpperCaseChars;

            //int Count = X.Invoke("Hello World");
            //Console.WriteLine(Count);

            //StringFuncDelegate X = new StringFuncDelegate(StringFunctions.GetCountOfUpperCaseChars);
            //StringFuncDelegate X = StringFunctions.GetCountOfUpperCaseChars; // Syntax Sugar
            //X += StringFunctions.GetCountOfLowerCaseChars;


            ////int Count = X.Invoke("Hello World");
            //int Count = X("Hello World");
            //Console.WriteLine(Count); 
            #endregion







        }
    }
}
