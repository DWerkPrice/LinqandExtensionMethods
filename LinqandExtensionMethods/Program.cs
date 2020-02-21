using System;
using System.Linq;
using LinqandExtensionMethods;

using System.Text;


namespace LinqandExtensionMethods

    /*This is an example of how Extension methods
     * Method within a class that 
     * 1. Class must be marked static
     * 2. Method must be public and also static
     * 3. Method has to return value
     * 4. Method has to have a paramet of at least one item 
     *   in it and must have type that you can call method on.
     *   1st parameter must have "this" add in front of the type.
     *   You can have more than 1 parameter
     * 5. Inside b ody you can do whatever you want.
*/

{
    class Program
    {
        static void Main(string[] args) {
            int[] nbrs = { 866,656,957,529,170,
                586,783,384,890,884,
                418,285,217,987,596,
                895,893,550,808,222,
                928,679,588,625,517};
            var total = nbrs.Sum();
            Console.WriteLine($"Extension Method Hello on int returns: {total.Hello()}");
            Console.WriteLine($"Sum: {total}");
    
  // if you can do a foreach loop, you can use a .Sum() linq
            total = 0;
            foreach (int nbr in nbrs) {
                total += nbr;
            }
            Console.WriteLine($"Sum: {total}");


// only even numbers
            total = 0;
            foreach (int nbr in nbrs) {
                if (nbr % 2 == 0) {
                    total += nbr;
                }
            }
            Console.WriteLine($"Sum even: {total}");


            // lamda function is the stuff inside the Where
            var totalAllEvent = nbrs.Where(nbr => nbr % 2 == 0).Sum();
            Console.WriteLine($"Sum even: {totalAllEvent}");

            // even less than 500
            totalAllEvent = nbrs.Where(nbr => nbr % 2 == 0 && nbr < 500).Sum();
            Console.WriteLine($"Sum < 500: {totalAllEvent}");

            var maxNbr = nbrs.Max();
            Console.WriteLine($"Max number: {maxNbr}");


        }
    }
}
