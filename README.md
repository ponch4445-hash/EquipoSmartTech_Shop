📦 Sistema de Gestión de Órdenes – SmartTech Shop

👥 Equipo

Equipo:

Integrantes:
•	Alfonso Hernández Magaña (Desarrollador Backend / Lógica)
•	Johan Suárez de la Cruz (Frontend)
•	Christian Antonio Romero Olvera (Base de Datos)

🧠 1. Descripción del Proyecto

Este proyecto consiste en el desarrollo de un sistema de gestión de órdenes para una tienda (SmartTech Shop), el cual permite registrar, calcular y administrar pedidos de clientes.

El sistema facilita:
•	Registro de clientes
•	Creación de órdenes
•	Cálculo automático del total
•	Almacenamiento de datos
•	Visualización en interfaz gráfica

🛠️ 2. Tecnologías Utilizadas
•	Lenguaje: C# (.NET)
•	Tipo de aplicación: Windows Forms
•	Base de datos: SQLite / SQL Server LocalDB
•	IDE: Visual Studio
•	Control de versiones: Git + GitHub

⚙️ 3. Características Principales
•	CRUD completo (Crear, Leer, Actualizar, Eliminar)
•	Interfaz gráfica amigable (Forms)
•	Manejo de colecciones:
o	List
o	Queue
o	Stack
•	Programación Orientada a Objetos (POO):
o	Clases (Cliente, Orden)
o	Encapsulamiento
o	Herencia (opcional)
o	Polimorfismo
•	Cálculo automático de totales (Cantidad * Precio)
•	Uso de DataGridView para mostrar información
•	Conexión a base de datos

🧩 4. Estructura del Sistema

📌 Clase Cliente

Representa la información de los clientes:
public class Cliente
{
    public int IdCliente { get; set; }
    public string Nombre { get; set; }
    public string Telefono { get; set; }
    public string Correo { get; set; }
    public string Direccion { get; set; }

    public Cliente(int idCliente, string nombre, string telefono, string correo, string direccion)
    {
        IdCliente = idCliente;
        Nombre = nombre;
        Telefono = telefono;
        Correo = correo;
        Direccion = direccion;
    }

    public override string ToString()
    {
        return Nombre;
    }
}
 
📌 Clase Orden

Gestiona las órdenes realizadas por los clientes:
public class Orden
{
    public int IdOrden { get; set; }
    public int IdCliente { get; set; }
    public string Descripcion { get; set; }
    public int Cantidad { get; set; }
    public decimal Precio { get; set; }
    public decimal Total { get; set; }
    public DateTime Fecha { get; set; }

    public void CalcularTotal()
    {
        Total = Cantidad * Precio;
    }
}

🖥️ 5. Funcionalidades del Sistema
•	Seleccionar cliente desde lista desplegable
•	Ingresar:
o	Descripción
o	Cantidad
o	Precio
•	Calcular total automáticamente
•	Guardar orden en base de datos
•	Limpiar formulario
•	Regresar al menú principal

▶️ 6. Instalación y Ejecución
1.	Clonar el repositorio:
git clone https://github.com/tuusuario/tuproyecto.git
2.	Abrir el proyecto en Visual Studio
3.	Compilar el proyecto
4.	Ejecutar:
ProyectoEquipoX.exe
5.	Asegurarse de que la base de datos esté en la carpeta:
/database

🗂️ 7. Estructura del Proyecto
ProyectoEquipoX/
│
├── src/              # Código fuente
├── database/         # Base de datos
├── build/Release/    # Ejecutable
├── docs/             # Documentación
├── tests/            # Pruebas
└── README.md

🧪 8. Casos de Prueba
#Caso de prueba 1
Entrada:
Acción del usuario: Registrar un nuevo cliente.
Datos:” Paula”, Tel=”5512345678  “, Correo=” paula @gmail.com“ direccion:unitec
Salida Esperada:
Registro agregado y visible en DataGrid.
#Caso de prueba 2
Entrada:
Acción del usuario: ingresar orden
Cliente. Paula, Cantidad:2, Descripcion: Computadora nueva
Precio: $30,000, Fecha:09/04/2026, Estado: en proceso
Salida Esperada:
El sistema guarde la orden correctamente
#Caso de prueba 3
Entrada:
Acción del usuario: Limpiar campos clientes
Nombre: Antonio, Telefono:5511223344, Correo:Toñito@gmail.com
Dirección: Campo marte
Salida Esperada:
Al momento de introducir los datos del cliente y se quiere ingresar uno nuevo se procede presionar el botón limpiar y se borran todos los campos que se ocuparon, no lanza ningún aviso

📊 9. Contribuciones Individuales
•	Johan Suárez: 15% – Lógica del sistema y clases
•	Alfonso Hernández Magaña: 70% – Interfaz
•	Christian Antonio Romero Olvera: 15% – Base de datos

🚀 10. Mejoras Futuras
•	Implementar login de usuarios
•	Reportes en PDF
•	Conexión en red (multiusuario)
•	API Web

 
