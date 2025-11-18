internal class Program
{
    private static void Main(string[] args)
    {
        Arbol arbolito = new Arbol();
        Nodo raiz = new Nodo();
        int opc=0;

        do
        {
            Console.WriteLine("[Menu de opciones para arboles]");
            Console.WriteLine("[1. Creacion del arbol]");
            Console.WriteLine("[2. Recorrido en preorden]");
            Console.WriteLine("[3. Opcion pendite]");
            Console.WriteLine("[4. Opcion pendite]");
            Console.WriteLine("[5. Opcion pendite]");
            Console.WriteLine("[6. Opcion pendite]");
            Console.WriteLine("[7. Opcion pendite]");
            Console.WriteLine("[8. Salir del programa]");
            opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    arbolito.crear_arbol(raiz);
                    break;
                case 2:
                    Console.WriteLine("[Recorrido en preorden]");
                    arbolito.preorden(raiz);
                    break;
                case 8:
                    Console.WriteLine("[Saliendo del programa]");
                    break;
                default:
                    Console.WriteLine("[Opcion no valida]");
                    break;
            }
        } while (opc != 8);
    }
}