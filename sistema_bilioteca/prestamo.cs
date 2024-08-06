using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static sistema_bilioteca.libro;
using static sistema_bilioteca.usuario;

namespace sistema_bilioteca
{
    internal class prestamo
    {
        public class Prestamo
        {
            [Key]
            public int id { get; set; }
            [ForeignKey("Libro")]
            public string isbn { get; set; }
            [ForeignKey("Usuario")]
            public string numeroSocio { get; set; }
            public DateTime fechaPrestamo { get; set; }
            public DateTime? fechaDevolucion { get; set; }

            public virtual Libro libro { get; set; }
            public virtual Usuario usuario { get; set; }
        }
    }
}
