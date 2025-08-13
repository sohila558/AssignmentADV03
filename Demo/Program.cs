using AssignmentADV03;
using static Demo.SortingAlgorithms;

namespace Demo
{

    // Step 01 : Create new Datatype (Delegate)
    public delegate int StringFuncDelegate(string s);
    // New Delegate (Class): Reference (Pointer) can refer to Function or more (Pointer of Functions)
    // These Function must have the same Signature of the delegate : int (String)
    // Regardless Function Name, Parameters Name or Access Modifier

    internal class Program
    {
        public static void PrintArray<T>(T[] values)
        {
            Console.WriteLine();
            foreach (T item in values)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine();
        }

        public static List<int> FindOddNumber (List<int> list)
        {
            List<int> Result = new List<int> ();

            if (list?.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 != 0)
                    {
                        Result.Add (list[i]);
                    }
                }
            }
            return Result;
        }

        public static void PrintList<T>(List<T> values)
        {
            Console.WriteLine();
            foreach (T item in values)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

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

            #region DelegateEX02
            //int[] Numbers = { 9, 8, 7, 1, 2, 3, 6, 5, 4 };

            //PrintArray(Numbers);

            ////SortingAlgorithms.BubbleSortAscending(Numbers); // Sorting Ascending

            //SortingFuncDelegate X = SortingConditions.CompareGreater;
            //SortingAlgorithms.BubbleSort(Numbers, X); // Sorting Descending 
            #endregion

            #region DelegateEX03
            //PrintArray(Numbers);

            // string[] Names = { "Ahmed", "Ali", "Mariam", "Mahmoud", "Amr", "Mona", "Khaled" };

            //List<int> Numbers = Enumerable.Range(1, 100).ToList();

            //List<int> OddNumbers = FindOddNumber(Numbers);

            //PrintList(OddNumbers); 
            #endregion

            #region Built-in Delegate
            // Built-in Delegate

            // Predicate - Func - Action

            // Predicate

            // ConditionFuncDelegate<int> X = ConditionFunction.CheckEven;

            // Predicate<int> predicate = ConditionFunction.CheckEven;

            // bool r = predicate.Invoke(1);

            // Console.WriteLine(r);

            // Func

            //Func<bool> Func = Fun01;

            // Action<string> action = Print;
            // action.Invoke(); 
            #endregion

            #region Anonymos Method - Lambda Expression
            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Anonymous Method

            //Func<int, bool> func = delegate (int X) { return X % 2 == 0; };

            //FindElements(Numbers, func);
            //FindElements(Numbers, delegate (int X) { return X % 2 == 0; });

            //Func<int, bool> func = ConditionsFunction.CheckEven;
            //func(1);

            // Lambda Expression

            // Func<int, bool> func = X => X % 2 == 0 
            #endregion





        }
        //public static int Fun01()
        //{
        //    return 1;
        //}
    }
}
