using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmpleados
{
    internal class Empleado
    {
        // Variables miembro de la clase Empleado
        private string nombre;
        private int numeroEmpleado;
        private decimal salario;
        private bool activo; // Estado del empleado (activo o inactivo)

        //Anexe un constructor para evitar el error que se me ocasionaba 
        //debido a que salia que el constructor no contenia 3 parametros , por lo tanto
        // al no observar un constructor especifico de empleado lo que hice fue modificar un poco el codigo y crear un constructor en base a 4 parametros
        public Empleado(string Nombre, int NumeroEmpleado, decimal Salario, bool Activo)
        {
            nombre = Nombre;
            numeroEmpleado = NumeroEmpleado;
            salario = Salario;
            activo = Activo;
        }

        // Metodo para mostrar los detalles del empleado
        public void MostrarDetalles()
        {
            string estado = (activo) ? "Activo" : "Inactivo";
            Console.WriteLine($"Nombre: {nombre}, Numero de Empleado: {numeroEmpleado}, Salario: {salario:C}, Estado: {estado}");
        }

        // Metodo para obtener el numero de empleado
        public int ObtenerNumeroEmpleado()
            {
                return this.numeroEmpleado;
            }

        // Metodo para cambiar el estado del empleado

        public void CambiarEstado(int nuevoEstado)
        {
            if (nuevoEstado == 1)
            {
                activo = true; // Activar empleado
                Console.WriteLine("Empleado Activado.");
            }
            else if (nuevoEstado == 0)
            {
                 activo = false; // Desactivar empleado
                Console.WriteLine(" Empleado desactivado.");
            }
            else
            {
                Console.WriteLine("Estado no valido.");
            }
        }

    }
}
