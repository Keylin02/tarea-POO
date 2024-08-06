using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_bilioteca
{
    internal class DVD
    {
        public class DVD
        {
            [Key]
            public string codigo { get; set; }
            public string titulo { get; set; }
            public string director { get; set; }
            public int annoPublicacion { get; set; }
            public int duracion { get; set; } 
        }
    }
}

