namespace _24_StatementsIf
{
    class Program
    {

        static void Main(string[] args)
        {

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

            //DECLARACIONES IF-ELSE-IF
            i = 10;
            j = 20;

            if(i == j)
            {
                Console.WriteLine("i es igual a j");
            }
            else if (i > j)
            {
                Console.WriteLine("i is greater than j");
            }
            else if (i < j)
            {
                Console.WriteLine("i is less than j");
            }

            //DECLARACIONES IF-ELSE-IF-ELSE
            i = 20;
            j = 20;

            if(i > j)
            {
                Console.WriteLine("i es mayor a j");
            }
            if(i < j)
            {
                Console.WriteLine("i es menor a j");
            }
            else 
            {
                Console.WriteLine("i es igual a j");
            }

            //DECLARACIONES IF-ELSE-IF ANIDADAS
            i = 10;
            j = 20;

            if(i != j)
            {
                if(i < j)
                {
                    Console.WriteLine("i es menor a j");
                }
                else if (i > j)
                {
                    Console.WriteLine("i es mayor a j");
                }
            }
            else
            {
                Console.WriteLine("i es igual a j");
            }

            //EJERCICIO DE QUE NUMERO ES MAYOR
            determinarQuienEsMayor();

            //EJERCICIO DE QUE NUMERO ES MENOR
            determinarQuienEsMenor();

            //EJERCICIO DE QUE NUMERO ES MAYOR MEDIO MENOR
            determinarMayorMedioMenor();

        }

        public bool isGreater(int i, int j)
        {
            return i > j;
        }

        public static void determinarQuienEsMayor()
        {
            int a = 8;
            int b = 6;
            int c = 9;

            if(a > b)
            {
                if(a > c)
                {
                    Console.WriteLine("a es mayor");
                }       
                else 
                {
                    Console.WriteLine("c es mayor");
                }
            }
            else
            {
                if(b > c)
                {
                    Console.WriteLine("b es mayor");
                }
                else
                {
                    Console.WriteLine("c es mayor");
                }
            }
        }

        public static void determinarQuienEsMenor()
        {
            int a = 5;
            int b = 6;
            int c = 4;

            if(a < b)
            {
                if(a < c)
                {
                    Console.WriteLine("a es menor");
                }       
                else 
                {
                    Console.WriteLine("c es menor");
                }
            }
            else
            {
                if(b < c)
                {
                    Console.WriteLine("b es menor");
                }
                else
                {
                    Console.WriteLine("c es menor");
                }
            }

        }

        public static void determinarMayorMedioMenor()
        {
            int a = 1;
            int b = 2;
            int c = 3;

            if(a > b)
            {
                if(a > c)
                {
                    if(b > c)
                    {
                        Console.WriteLine("a es mayor");
                        Console.WriteLine("b es medio");
                        Console.WriteLine("c es menor");
                    }   
                    else 
                    {
                            Console.WriteLine("a es mayor");
                            Console.WriteLine("c es medio");
                            Console.WriteLine("b es menor");
                    }       
                }       
                else
                {                        
                    Console.WriteLine("c es mayor");
                    Console.WriteLine("a es medio");
                    Console.WriteLine("b es menor");
                }
            }
            else
            {
                if(b > c)
                {
                    if (a > c)
                    {
                        Console.WriteLine("b es mayor");
                        Console.WriteLine("a es medio");
                        Console.WriteLine("c es menor");
                    }
                    else
                    {
                        Console.WriteLine("b es mayor");
                        Console.WriteLine("c es medio");
                        Console.WriteLine("a es menor");
                    }
                }
                else
                {
                        Console.WriteLine("a es mayor");
                        Console.WriteLine("b es medio");
                        Console.WriteLine("c es menor");
                }
            }


        }

    }
}