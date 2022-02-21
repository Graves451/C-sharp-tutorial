using System;
using System.Collections;
using System.Text;

namespace C_sharp_tutorial
{
    class HashtableExample
    {
        Hashtable hash;
        public HashtableExample() {
            hash = new Hashtable();
        }
        public void add(string index, int value) {
            hash.Add(index, value);
        }
        public bool contains(int value) {
            return hash.ContainsValue(value);
        }

    }
}
