using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinario.Classes
{
    internal class Consulta
    {
        public int ConsultaID { get; set; }
        public int AnimalID { get; set; }
        public DateTime Data { get; set; }
        public string Motivo { get; set; }

        //private Animal animal;
        //private Cliente cliente;
        public Consulta(DateTime data, string motivo, int animalID)
        {
            Data = data;
            Motivo = motivo;
            //this.animal = animal;
            //this.cliente = cliente;
            AnimalID = animalID;
        }
    }
}
