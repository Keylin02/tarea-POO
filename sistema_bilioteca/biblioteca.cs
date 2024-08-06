using sistema_bilioteca;
using sistema_bilioteca.sistema_biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static sistema_bilioteca.Ibiblioteca;
using static sistema_bilioteca.libro;
using static sistema_bilioteca.prestamo;
using static sistema_bilioteca.usuario;

namespace sistema_biblioteca
{
    public class biblioteca : Ibiblioteca
    {
        private BibliotecaContext _context;

        public biblioteca()
        {
            _context = new BibliotecaContext();
        }


        public void agregarRevista(revista revista)
        {
            _context.revistas.Add(revista);
            _context.SaveChanges();
        }

        public void modificarRevista(string issn, revista revistaModificada)
        {
            var revista = _context.revistas.Find(issn);
            if (revista != null)
            {
                revista.titulo = revistaModificada.titulo;
                revista.editor = revistaModificada.editor;
                revista.annoPublicacion = revistaModificada.annoPublicacion;
                revista.numeroEdicion = revistaModificada.numeroEdicion;
                _context.SaveChanges();
            }
        }

        public void eliminarRevista(string issn)
        {
            var revista = _context.revistas.Find(issn);
            if (revista != null)
            {
                _context.revistas.Remove(revista);
                _context.SaveChanges();
            }
        }

        public revista buscarRevistaPorISSN(string issn)
        {
            return _context.revistas.Find(issn);
        }

        public List<revista> buscarRevistas(string criterio)
        {
            return _context.revistas
                .Where(r => r.titulo.Contains(criterio) || r.editor.Contains(criterio) || r.issn.Contains(criterio))
                .ToList();
        }

        public void agregarDVD(DVD dvd)
        {
            _context.DVDs.Add(dvd);
            _context.SaveChanges();
        }

        public void modificarDVD(string codigo, DVD dvdModificado)
        {
            var dvd = _context.DVDs.Find(codigo);
            if (dvd != null)
            {
                dvd.titulo = dvdModificado.titulo;
                dvd.director = dvdModificado.director;
                dvd.annoPublicacion = dvdModificado.annoPublicacion;
                dvd.duracion = dvdModificado.duracion;
                _context.SaveChanges();
            }
        }

        public void eliminarDVD(string codigo)
        {
            var dvd = _context.DVDs.Find(codigo);
            if (dvd != null)
            {
                _context.DVDs.Remove(dvd);
                _context.SaveChanges();
            }
        }

        public DVD buscarDVDPorCodigo(string codigo)
        {
            return _context.DVDs.Find(codigo);
        }

        public List<DVD> buscarDVDs(string criterio)
        {
            return _context.DVDs
                .Where(d => d.titulo.Contains(criterio) || d.director.Contains(criterio) || d.codigo.Contains(criterio))
                .ToList();
        }
    }
}








