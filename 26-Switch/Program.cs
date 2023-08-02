namespace _26_Switch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //EL SWITCH CON UNA VARIABLE
            int x = 100;
            switch(x)
            {
                case 5:
                    Console.WriteLine("el valor de x es 5");
                    break;
                case 10:
                    Console.WriteLine("el valor de x es 10");
                    break;
                case 15:
                    Console.WriteLine("el valor de x es 15");
                    break;
                default:
                    Console.WriteLine("el valor de x es desconocido");
                    break;
            }

            //EL SWITCH CON UNA EXPRESION
            x = 125;
            switch(x % 2)
            {
                case 0:
                    Console.WriteLine($"{x} el valor de x es par");
                    break;
                case 1:
                    Console.WriteLine($"{x} el valor de x es inpar");
                    break;
            }

                    

            
        }
    }
}
