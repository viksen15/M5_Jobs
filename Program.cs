using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5_JOBS {
    class Program {
        static void Main(string[] args) {
            Senior e = new Senior(7000);

            Console.WriteLine("{0}", e.getSueldoMensualBruto());

            Console.ReadKey();
        }
    }
}
