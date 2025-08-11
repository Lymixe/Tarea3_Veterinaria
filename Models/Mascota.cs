using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Tarea3_Veterianria.Models
{
    public class Mascota
    {
        public string? nombreM { get; set; }

        public string? tipoM { get; set; }

        public string? razaM { get; set; }

        public string? sexoM { get; set; }

        public string? nombreD { get; set; }

         [EmailAddress]
        public string? email { get; set; } 

    }
}