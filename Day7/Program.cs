namespace Day7
{
    internal class Program
    {

        static bool sumArray(out int multy, out int sum, params int[] arr) {
             multy = 0;
             sum = 0;

            if (arr.Length <= 1 ) {
                multy = 0;
                sum = 0;
                return false;

            }
               else if (arr.Length < 3)
            { 
               multy = arr[0] * arr[1];
               sum = arr.Length == 2? sum=0: sum = arr[2];
               return true;
                       
            }
            else {
                for (int i = 2; i < arr.Length; i++) {
                    sum += arr[i];
                }
                multy = arr[0] * arr[1];

                return true;
            }

        }
   
        static void Main(string[] args)
        {
            int mul =0;
            int sub=0;

            sumArray(out mul,out sub, 1, 4, 2, 5, 7, 8);

            Console.WriteLine($" the multiplication : {mul}");
            Console.WriteLine($" the submition : {sub}");

            sumArray(out mul, out sub, 1, 4, 2);

            Console.WriteLine($" the multiplication : {mul}");
            Console.WriteLine($" the submition : {sub}");

            sumArray(out mul, out sub, 1, 4);

            Console.WriteLine($" the multiplication : {mul}");
            Console.WriteLine($" the submition : {sub}");




        }
    }
}
