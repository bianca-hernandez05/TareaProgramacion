namespace GestionEmpleados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplicacion de Gestion de Empleados");

           // Crear una lista para almacenar empleados

            List<Empleado> listaEmpleados = new List<Empleado>();

           //Agregar empleados de ejemplo a la lista
           // los valores que no poseian boleanos , los escribi en true para que tuviera 4 parametros
           //como en el constructor que creamos en la clase Empleado //

            listaEmpleados.Add (new Empleado("Juan", 101, 30000, true));
            listaEmpleados.Add(new Empleado ("Maria", 102, 35000, true));
            listaEmpleados.Add(new Empleado("Pedro", 103, 32000, false)); //Empleado inactivo

            //Mostrar los detalles de cada empleado

            foreach (var empleado in listaEmpleados)
            {
                empleado.MostrarDetalles();
            }

            //Cambiar el estado de un empleado por su numero de empleado
            int numeroEmpleadoCambiarEstado = 103; // numero de empleado a cambiar de estado
            Empleado empleadoCambiarEstado = BuscarEmpleado(listaEmpleados, numeroEmpleadoCambiarEstado);

            if (empleadoCambiarEstado != null)
            {
                //Cambiar el estado a activo (1) o inactivo (0)
                empleadoCambiarEstado.CambiarEstado(1);
                empleadoCambiarEstado.MostrarDetalles();
            }
            else
            {
                Console.WriteLine($"Empleado con numero {numeroEmpleadoCambiarEstado} no encontrado.");
            }

            //Metodo para buscar un empleado por su numero de empleado
            static Empleado BuscarEmpleado(List<Empleado> empleados, int numeroEmpleado )
            {
                foreach (var empleado in empleados)
                {
                    if (empleado.ObtenerNumeroEmpleado() == numeroEmpleado)
                    {
                        return empleado;
                    }
                }
                return null; // Retorna null si no se encuentra ningun empleado con ese numero
            }
           
        }
    }
}
