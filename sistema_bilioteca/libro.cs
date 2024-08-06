using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace sistema_bilioteca
{
    internal class libro
    {
        public class Libro
        {
            [Key]
            public string isbn { get; set; }
            public string titulo { get; set; }
            public string autor { get; set; }
            public int annoPublicacion { get; set; }
            public int numeroPaginas { get; set; }
        }
    }
}
