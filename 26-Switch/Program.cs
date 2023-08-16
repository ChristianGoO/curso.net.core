namespace _26_Switch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //EL SWITCH CON UNA VARIABLE
            int x = 100;
            switch (x)
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
            switch (x % 2)
            {
                case 0:
                    Console.WriteLine($"{x} el valor de x es par");
                    break;
                case 1:
                    Console.WriteLine($"{x} el valor de x es inpar");
                    break;
            }

            //EL SWITCH CON UNA CADENA
            string tipoSentencia = "switch";
            switch (tipoSentencia)
            {
                case "if.else":
                    Console.WriteLine("if...else");
                    break;
                case "ternary":
                    Console.WriteLine("Ternary operator");
                    breal;
                case "switch":
                    Console.WriteLine("Sentencia switch");
                    break;
            }

            //COMBINACION DE CASOS CON SENTENCIA SWITCH
            x = 5;
            switch (x)
            {
                case 1:
                    Console.WriteLine("x = 1");
                    break;
                case 2:
                    Console.WriteLine("x = 2");
                    break;
                case 4:
                    Console.WriteLine("entrando al caso 4");
                    break;
                case 5:
                    Console.WriteLine("x = 5 o x = 4"   );
                    break;
                default:
                    Console.WriteLine("x > 5");
                    break;

            }

            //SWITCH CON RETURN
            x = 125;
            Console.WriteLine(esImpar(x) ? "es impar" : "es par");

            //SWITCH SIN CASE
            //x = 1;
            //switch(x)
            //{
            //    case 0 :
            //        Console.WriteLine($"{x} es valor par");
            //        break;
            //    case 1 :
            //        Console.WriteLine($"{x} es valor impar");
            //        break;
            //    case 2 :
            //        Console.WriteLine($"{x} es valor par");
            //        break;
            //    default :
            //        Console.WriteLine($"{x} es valor impar");
            //        break;
            //}

            //SWITCH ANIDADOS
            int j = 5;
            switch (j)
            {
                case 5:
                    Console.WriteLine($"el valor de j es {j}");
                    switch (j - 1)
                    {
                        case 4:
                            Console.WriteLine(4);
                            switch (j - 2)
                            {
                                case 3:
                                    Console.WriteLine(3);
                                    break;
                            }
                            break;
                    }
                    break;

                case 10:
                    Console.WriteLine(10);
                    break;

                case 15:
                    Console.WriteLine(15);
                    break;

                default :
                    Console.WriteLine(100);
                    break;

            }

            switch(obtenerValor())
            {
                case 0: 
                    Console.WriteLine(("el valor es 0"));
                    break;
                case 1: 
                    Console.WriteLine(("el valor es 1"));
                    break;
            }

            MenuCajero();

            Console.ReadLine();

        }

        static bool esImpar(int x)
        {
            switch (x % 2)
            {
                case 0:
                    return false;
                case 1:
                    return true;

            }
            return false;
        }

        static int obtenerValor()
        {
            Random rnd = new Random();
            return rnd.Next(0, 1);
        }

        static void MenuCajero()
        {
            Console.WriteLine("Introduzca la tarjeta");
            int numerotarjeta = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca el NIP");
            int nip = int.Parse(Console.ReadLine());

            Console.WriteLine("Seleccione la operacion que desea realizar");
            Console.WriteLine("1. retirar efectivo");
            Console.WriteLine("2. consultar saldo");
            Console.WriteLine("3. Incrementar linea de credito");
            Console.WriteLine("4. compra de tiempode aire");
            Console.WriteLine("5. salir");

            int opcion = int.Parse(Console.ReadLine());

            switch(opcion)
            {
                case 1:
                    RetirarDinero();
                    break;
                case 2:
                    consultarDinero();
                    break;
                case 3:
                    incrementarDinero();
                    break;
                case 4:
                    comprarTiemporAire();
                    break;
                case 5:
                    salir();
                    break;
            }

        }

        public static RetirarDinero()
        {
            Console.WriteLine("Retirar dinero");
        }

        public static consultarDinero()
        {
            Console.WriteLine("consultarDinero ");
        }

        public static incrementarDinero()
        {
            Console.WriteLine("incrementarDinero");
        }

        public static comprarTiemporAire()
        {
            Console.WriteLine("comprarTiemporAire");
        }

        public static salir()
        {
            Console.WriteLine("salir");
        }

    }
}
