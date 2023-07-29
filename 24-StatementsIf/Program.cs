namespace _24_StatementsIf
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo");
            int i = 10, j = 20, h = 0;

            if(i < j)
            {
                Console.WriteLine("i es menos que la j");
            }

            if(j > i)
            {
                Console.WriteLine("i es mayor que j");
            }

            //LA SENTENCIA IF ESPERA UN VALOR BOOLEANO
            //if(i + 1)
            //{
            //    Console.WriteLine("i es menos que la j");
            //}

            //LA SENTENCIA IF ESPERA UN VALOR BOOLEANO
            //if(j + i)
            //{
            //    Console.WriteLine("i es mayor que j");
            //}

            if(isGreater(i, j))
            {
                Console.WriteLine("i es menos que la j");
            }

            if(isGreader(j, i))
            {
                Console.WriteLine("j es mayor que la i");
            }

        }

        public bool isGreater(int i, int j)
        {
            return i > j;
        }

    }
}