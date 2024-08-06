using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_bilioteca
{
    internal class usuario
    {
        public class Usuario
        {
            [Key]
            public string numeroSocio { get; set; }
            public string nombre { get; set; }
            public string apellido { get; set; }
        }
    }
}
