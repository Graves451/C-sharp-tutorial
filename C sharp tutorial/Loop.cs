using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_tutorial
{
    class Loop {
        public void ForLoop(int num) {
            for (int a = 0; a < num; a++) {
                Console.WriteLine(a);
            }
        }
        public void WhileLoop(int num) {
            int a = 0;
            while (a < num) {
                Console.WriteLine(a);
                a++;
            }
        }
    }
}
