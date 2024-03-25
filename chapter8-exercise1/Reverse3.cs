using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter8_exercise1
{
    class Reverse3
    {
        int firstInt = 0;
        int middleInt = 0;
        int lastInt = 0;

        public Reverse3() {
            firstInt = 100;
            middleInt = 2;
            lastInt = 8;
        }

        /*public static void Main(string[] args) {
            Reverse3 rev3 = new Reverse3();
            rev3.display("Before", rev3.firstInt, rev3.middleInt, rev3.lastInt);
            rev3.reverse3(ref rev3.firstInt,ref rev3.middleInt,ref rev3.lastInt);
            rev3.display("After", rev3.firstInt, rev3.middleInt, rev3.lastInt);
            rev3.reverseN(rev3.firstInt, rev3.middleInt, rev3.lastInt, 8, 4, 3);
            rev3.display("After", rev3.firstInt, rev3.middleInt, rev3.lastInt);
        }*/

        public void reverse3(ref int first,ref int middle,ref int last) {
            int temp = first;
            first = last;
            last = temp;
            /*this.firstInt = last;
            this.lastInt = first;*/
        }

        void reverseN(params int[] values) {
            for (int count=0; count < (values.Length / 2); count++) {
                int temp = values[count];
                values[count] = values[values.Length - count - 1];
            }
            Console.WriteLine();
        }

        public void display(String text, int first, int middle, int last) {
            Console.WriteLine(text + " " + first + " " + middle + " " + last);
        }
    }
}
