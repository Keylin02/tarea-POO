using sistema_bilioteca.sistema_biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static sistema_bilioteca.libro;
using static sistema_bilioteca.Usuario;

namespace sistema_bilioteca
{
    internal class Ibiblioteca
    {


        void agregarRevista(revista revista);
        void modificarRevista(string issn, revista revistaModificada);
        void eliminarRevista(string issn);
        revista buscarRevistaPorISSN(string issn);
        List<revista> buscarRevistas(string criterio);

        
        void agregarDVD(DVD dvd);
        void modificarDVD(string codigo, DVD dvdModificado);
        void eliminarDVD(string codigo);
        DVD buscarDVDPorCodigo(string codigo);
        List<DVD> buscarDVDs(string criterio);
    }
}
    


