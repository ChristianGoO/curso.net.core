namespace _25_OperadorTernario
{
    public class Program
    {

        public static void Main(string[] args)
        {

            //SENTENCIA IF
            bool condicion = true;
            if(condicion)
            {
                Console.WriteLine("resultado es verdadero");
            }
            else
            {
                Console.WriteLine("resultado es falso");
            }

            var resultado = condicion ? "verdadero" : "falso";
            Console.WriteLine("resultado es " + resultado);

            //EJECUTA LA SENTENCIA VERDADERA
            int x = 20, y = 10;
            var result = x > y ? "x es mayor que y": "x es menor que y";
            Console.WriteLine(result);
       
            //EEJCUTA LA SENTENCIA FALSA
            int x = 10, y = 100;
            var result = x > y ? "x es mayor que y": "x es menor que y";
            Console.WriteLine(result);

            //OPERADOR TERNARIO ANIDADO
            x = 10;
            y = 10;
            result = x >y ? (x % y == 0 ? "x es mayor que y" : "x es solo mayor que y") : 
            (x < y ? "x es menor que y" : (x == y ? "x es igual que y " : "no hay resultado"));
            Console.WriteLine(result);

            //OPERADOR TERNARIO CON METODOS
            var result = validarXmayorQueY(x, y) ? obtenerMensajeMayorX(): obtenerMensajeMenorX();
            Console.WriteLine(result);

        }

        public static bool validarXmayorQueY(int x, int y)
        {
            return x > y;
        }

        public static string obtenerMensajeMayorX()
        {
            Console.WriteLine("x es mayor que y");

        }

        public static string obtenerMensajeMenorX()
        {
            Console.WriteLine("x es menor que y");

        }
    }
}