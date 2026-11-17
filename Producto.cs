using System;

namespace TecnoPunto
{
    // Clase que representa un producto del inventario
    class Producto
    {
        private string nombre;
        private double precio;
        private int cantidad;

        public string Codigo { get; set; }

        // Valida que el nombre no esté vacío
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("El nombre no puede estar vacío.");

                nombre = value;
            }
        }

        // Valida que el precio sea mayor que cero
        public double Precio
        {
            get { return precio; }
            set
            {
                if (value <= 0)
                    throw new Exception("El precio debe ser mayor que cero.");

                precio = value;
            }
        }

        // Valida que la cantidad no sea negativa
        public int Cantidad
        {
            get { return cantidad; }
            set
            {
                if (value < 0)
                    throw new Exception("La cantidad no puede ser negativa.");

                cantidad = value;
            }
        }

        // Calcula automáticamente el valor total del inventario
        public double ValorTotal
        {
            get { return Precio * Cantidad; }
        }

        // Constructor de la clase Producto
        public Producto(string codigo, string nombre, double precio, int cantidad)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }

        // Muestra la información del producto
        public void MostrarInfo()
        {
            Console.WriteLine("\n--------------------------");
            Console.WriteLine($"Código: {Codigo}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Precio: {Precio}");
            Console.WriteLine($"Cantidad: {Cantidad}");
            Console.WriteLine($"Valor Total: {ValorTotal}");
        }
    }
}