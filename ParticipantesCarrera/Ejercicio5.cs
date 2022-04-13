using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticipantesCarrera
{
    internal class Ejercicio5
    {

        public static void Ejecutar()
        {
            List<Participante> participantes = new List<Participante>();
                while (true)
                {
                    Participante p = LeerParticipante();
                    if (p == null)
                        break;
                    else
                        participantes.Add(p);
                }
            Console.ReadKey();
        }
        private static Participante LeerParticipante()
        {
            Console.WriteLine("Cargando nuevo partcipante...");
            Console.Write("Numero: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero < 0) {
                return null;
            }
            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Fecha de Nacimiento: ");
            DateTime fecha = DateTime.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            int altura = int.Parse(Console.ReadLine());
            Console.Write("Puesto: ");
            int puesto = int.Parse(Console.ReadLine());
            return new Participante(numero,nombre,apellido,fecha,altura,puesto);
        }
    }
}
