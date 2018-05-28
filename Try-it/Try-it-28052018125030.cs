using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
class MyClass {
    static void Main(string[] args) {
        String s = Console.ReadLine();
            var x = (from a in s
                    select char.IsLower(a)?
                        char.ToUpper(a):char.ToLower(a)).ToArray();
            Console.WriteLine(new string(x));
            Console.ReadKey();
    }
}