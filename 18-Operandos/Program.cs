namespace _18_Operandos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //OPERACIONES ARITMETICAS
            int x = 5 + 5;
            int y = x + 5;
            int z = y + x;

            //int w = 10L + 500000000000000;
            long w = 10L + 500000000000000;
            long a = 100000L * 100000L;

            double d = 4.5d;
            float f = 3.5f + (float)d;
            string greet = "hello" + "world";
            Console.WriteLine("x: {0}", x);
            Console.WriteLine("y: {0}", y);
            Console.WriteLine("z: {0}", z);
            Console.WriteLine("f: {0}", f);
            Console.WriteLine("greet: {0}", greet);


            //OPERACIONES ARITMETCAS CON MODULO
            int resultado = 10 % 2;
            Console.WriteLine(resultado);

            //OPERACION UNARIAS
            int b = 5;
            b++;
            int c = b++;
            int e = ++b;
            Console.WriteLine(b);
            Console.WriteLine(c);


            //OPERACION ABREVIADAS 
            int h = 10;
            h += 5;     ///--------->    h = h + 5;
            Console.WriteLine(h);
            h -= 5;     ///--------->    h = h - 5;
            Console.WriteLine(h);
            h *= 5;     ///--------->    h = h * 5;
            Console.WriteLine(h);
            h /= 5;     ///--------->    h = h / 5;
            Console.WriteLine(h);


            //OPERACION  DE ASIGNACION NULA 
            string str = null;
            str ??= "hola mundo";

            Console.WriteLine(str);

            //OPERADORES DE COMPARACION
            bool resultado1 = false;
            int j = 10;
            int i = 5;

            resultado1 = j < i;
            resultado1 = j > i;
            resultado1 = j >= i;
            resultado1 = j <= i;
            resultado1 = j == i;
            resultado1 = j != i;

            //OPERACION DE NAGACION
            bool bvar = false;
            Console.WriteLine(!false);
            Console.WriteLine(!true);
            Console.WriteLine(!bvar);
            Console.WriteLine(!false);
            Console.WriteLine(!(5 > 3));

            //OPERACION LOGICA AND
            bool resultado2 = false;
            resultado2 = OperadorTrue() || OperadorFalse();
            if (resultado2)
                Console.WriteLine(true);

            resultado2 = OperadorTrue() || OperadorFalse();
            if (resultado2)
                Console.WriteLine(true);

            resultado2 = OperadorTrue() || OperadorFalse();
            if (resultado2)
                Console.WriteLine(true);

            resultado2 = OperadorTrue() || OperadorFalse();
            if (resultado2)
                Console.WriteLine(true);


            List<string> list = new List<string>();
            list.Any(cadena => cadena.Length >= 0);


            List<int> listInt = new List<int>();
            listInt.Any(entero => entero == 0);


            List<Estudiante> listEstudiante = new List<Estudiante>();
            listEstudiante.Any(Estudiante => Estudiante.nombre == "JUAN");



            int a1 = 5 + 3 * 3;
            float b1 = 5 + 3 * 3 / 2;
            int c1 = (5 + 3) * 3 / 2;
            int d1 = (3 * 3) * (3 / 3 + 5);

            Console.WriteLine($"a = {a1}");
            Console.WriteLine($"b = {b1}");
            Console.WriteLine($"c = {c1}");
            Console.WriteLine($"d = {d1}");


        }

        private static bool OperadorTrue()
        {
            return true;
        }

        private static bool OperadorFalse()
        {
            return false;
        }
    }

    internal class Estudiante
    {
        public string nombre { get; set; }
    }
}