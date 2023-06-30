using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {

            byte b1 = 255;
            //byte b2 = -128;
            sbyte sb1 = -128;
            sbyte sb2 = 127;

            Console.WriteLine("{0} su minimo {1} y maximo {2}", b1.GetType(), System.Byte.MinValue, System.Byte.MaxValue);
            Console.WriteLine("{0} su minimo {1} y maximo {2}", sb1.GetType(), System.SByte.MinValue, System.SByte.MaxValue);

            //---------------------------------------------------------------------------------------------------------------------
            short s1 = -32768;
            short s2 = 32767;
            //short s3 = 35000;//Compile-time error: Constant value '35000' cannot be converted to a 'short'

            ushort us1 = 65535;
            //ushort us2 = -32000;

            Console.WriteLine("{0} su minimo {1} y maximo {2}", s1.GetType(), System.Int16.MinValue, System.Int16.MaxValue);
            Console.WriteLine("{0} su minimo {1} y maximo {2}", us1.GetType(), System.UInt16.MinValue, System.UInt16.MaxValue);

            //----------------------------------------------------------------------------------------------------------------------
            int i = -2147483648;
            int j = 2147483647;
            //int k = 4294967295; //Compile-time error: Cannot implicitly convert type 'uint' to 'int'.

            uint ui1 = 4294967295;
            //uint ui2 = -1;

            Console.WriteLine("{0} su minimo {1} y maximo {2}", 1.GetType(), System.Int32.MinValue, System.Int32.MaxValue);
            Console.WriteLine("{0} su minimo {1} y maximo {2}", ui1.GetType(), System.UInt32.MinValue, System.UInt32.MaxValue);

            //----------------------------------------------------------------------------------------------------------------------
            int hex = 0x2F;
            int binary = 0b_0010_1111;

            Console.WriteLine(hex);
            Console.WriteLine(binary);

            //---------------------------------------------------------------------------------------------------------------------
            long l1 = -9223372036854775808;
            long l2 = 9223372036854775807;

            ulong ul1 = 18223372036854775808ul;
            ulong ul2 = 18223372036854775808UL;

            Console.WriteLine("{0} su minimo {1} y maximo {2}", l1.GetType(), System.Int64.MinValue, System.Int64.MaxValue);
            Console.WriteLine("{0} su minimo {1} y maximo {2}", ul1.GetType(), System.UInt64.MinValue, System.UInt64.MaxValue);

            //------------------------------------------------------------------------------------------------------------------------

            float f1 = 123456.5F;
            float f2 = 1.123456f;

            Console.WriteLine("{0} su minimo {1} y maximo {2}", f1.GetType(), System.Single.MinValue, System.Single.MaxValue);

            //------------------------------------------------------------------------------------------------------------------------
            double d1 = 12345678912345.5d;
            double d2 = 1.123456789123456d;

            Console.WriteLine("{0} su minimo {1} y maximo {2}", d1.GetType(), System.Double.MinValue, System.Double.MaxValue);

            //------------------------------------------------------------------------------------------------------------------------
            decimal de1 = 123456789123456789123456789.5m;
            decimal de2 = 1.1234567891345679123456789123m;

            Console.WriteLine("{0} su minimo {1} y maximo {2}", de1.GetType(), System.Decimal.MinValue, System.Decimal.MaxValue);

            //------------------------------------------------------------------------------------------------------------------------
            double d = 0.12e2;
            Console.WriteLine(d);  // 12;

            float f = 123.45e-2f;
            Console.WriteLine(f);  // 1.2345

            decimal m = 1.2e6m;
            Console.WriteLine(m);

        }
    }
}
