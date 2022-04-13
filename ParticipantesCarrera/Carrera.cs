using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticipantesCarrera
{
    internal class Carrera
    {
        public string Nombre { get; set; }
        public int Id { get; set; }
        public List<Participante> Participantes { get; set; }

        public Carrera(string nombre, int id, List<Participante> participantes)
        {
            Nombre = nombre;
            Id = id;
            Participantes = participantes;
        }

    }
}
