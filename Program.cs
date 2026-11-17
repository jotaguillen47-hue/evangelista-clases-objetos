using System;

namespace TecnoPunto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creación de los tres productos solicitados
            Producto producto1 = CrearProducto(1);
            Producto producto2 = CrearProducto(2);
            Producto producto3 = CrearProducto(3);

            Console.WriteLine("\n=== INVENTARIO REGISTRADO ===");

            producto1.MostrarInfo();
            producto2.MostrarInfo();
            producto3.MostrarInfo();

            Console.ReadKey();
        }

        // Método para solicitar y validar los datos del producto
        static Producto CrearProducto(int numero)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine($"\nProducto #{numero}");

                    Console.Write("Código: ");
                    string codigo = Console.ReadLine();

                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();

                    double precio;
                    Console.Write("Precio: ");

                    // Valida que el precio sea numérico
                    while (!double.TryParse(Console.ReadLine(), out precio))
                    {
                        Console.Write("Entrada inválida. Ingrese un precio válido: ");
                    }

                    int cantidad;
                    Console.Write("Cantidad: ");

                    // Valida que la cantidad sea numérica
                    while (!int.TryParse(Console.ReadLine(), out cantidad))
                    {
                        Console.Write("Entrada inválida. Ingrese una cantidad válida: ");
                    }

                    return new Producto(codigo, nombre, precio, cantidad);
                }
                catch (Exception ex)
                {
                    // Muestra el mensaje de error y vuelve a solicitar los datos
                    Console.WriteLine("\nError: " + ex.Message);
                    Console.WriteLine("Por favor, intente nuevamente.\n");
                }
            }
        }
    }
}