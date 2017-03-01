using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace DLinkedList {
    class main {
        static void Main(string[] args) {
            DLinkedList<int> test = new DLinkedList<int>(123);
            test.add(456);
            test.add(789);
            test.remove(456);
            Console.ReadKey();
            checked { int a = 1; }
        }
    }
}
