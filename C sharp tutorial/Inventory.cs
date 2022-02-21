using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_tutorial
{
    class Inventory
    {
        int[] array;
        public Inventory() {
            array = new int[5];
        }

        public void set(int index, int value) {
            array[index] = value;
        }

        public void delete(int index) {
            array[index] = 0;
        }

        public int max() {
            int biggest = Int32.MinValue;
            foreach (int num in array) {
                if (num > biggest) {
                    biggest = num;
                }
            }
            return biggest;
        }
    }
}
