using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTech_Shop
{
    // Creando la clase que representa clientes creando la clase 
    public class Cliente
    {
        // Atributos del cliente
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }

        // Constructor para inicializar los datos
        public Cliente(int idCliente, string nombre, string telefono, string correo, string direccion)
        {
            IdCliente = idCliente;
            Nombre = nombre;
            Telefono = telefono;
            Correo = correo;
            Direccion = direccion;
        }

        // Método ToString para mostrar el nombre
        public override string ToString()
        {
            return Nombre;
        }
    }
}
