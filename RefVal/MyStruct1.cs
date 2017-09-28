using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefVal
{
    struct MyStruct1
    {
        
        public int a;
        public int b;
        public int c;
        public int d;

        public MyStruct1(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public static bool operator ==(MyStruct1 structA, MyStruct1 structB)
        {
            if ((structA.a == structA.b) && (structA.b == structA.c) && (structA.c == structA.d))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(MyStruct1 structA, MyStruct1 structB)
        {
            if ((structA.a != structA.b) && (structA.b != structA.c) && (structA.c != structA.d))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
