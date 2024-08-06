using sistema_bilioteca;
using sistema_bilioteca.sistema_biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static sistema_bilioteca.libro;
using static sistema_bilioteca.usuario;

namespace sistema_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ibiblioteca biblioteca = new biblioteca();

            while (true)
            {
                Console.WriteLine("Seleccione una opción: ");
                Console.WriteLine("1. Agregar Libro");
                Console.WriteLine("2. Modificar Libro");
                Console.WriteLine("3. Eliminar Libro");
                Console.WriteLine("4. Buscar Libro");
                Console.WriteLine("5. Agregar Usuario");
                Console.WriteLine("6. Modificar Usuario");
                Console.WriteLine("7. Eliminar Usuario");
                Console.WriteLine("8. Prestar Libro");
                Console.WriteLine("9. Devolver Libro");
                Console.WriteLine("10. Agregar Revista");
                Console.WriteLine("11. Modificar Revista");
                Console.WriteLine("12. Eliminar Revista");
                Console.WriteLine("13. Buscar Revista");
                Console.WriteLine("14. Agregar DVD");
                Console.WriteLine("15. Modificar DVD");
                Console.WriteLine("16. Eliminar DVD");
                Console.WriteLine("17. Buscar DVD");
                Console.WriteLine("18. Salir");

                var opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AgregarLibro(biblioteca);
                        break;
                    case "2":
                        ModificarLibro(biblioteca);
                        break;
                    case "3":
                        EliminarLibro(biblioteca);
                        break;
                    case "4":
                        BuscarLibro(biblioteca);
                        break;
                    case "5":
                        AgregarUsuario(biblioteca);
                        break;
                    case "6":
                        ModificarUsuario(biblioteca);
                        break;
                    case "7":
                        EliminarUsuario(biblioteca);
                        break;
                    case "8":
                        PrestarLibro(biblioteca);
                        break;
                    case "9":
                        DevolverLibro(biblioteca);
                        break;
                    case "10":
                        agregarRevista(biblioteca);
                        break;
                    case "11":
                        modificarRevista(biblioteca);
                        break;
                    case "12":
                        eliminarRevista(biblioteca);
                        break;
                    case "13":
                        buscarRevista(biblioteca);
                        break;
                    case "14":
                        agregarDVD(biblioteca);
                        break;
                    case "15":
                        modificarDVD(biblioteca);
                        break;
                    case "16":
                        eliminarDVD(biblioteca);
                        break;
                    case "17":
                        buscarDVD(biblioteca);
                        break;
                    case "18":
                        return;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        static void AgregarLibro(Ibiblioteca biblioteca)
        {
            Console.Write("Título: ");
            var titulo = Console.ReadLine();
            Console.Write("Autor: ");
            var autor = Console.ReadLine();
            Console.Write("ISBN: ");
            var isbn = Console.ReadLine();
            Console.Write("Año de Publicación: ");
            int.TryParse(Console.ReadLine(), out int annoPublicacion);
            Console.Write("Número de Páginas: ");
            int.TryParse(Console.ReadLine(), out int numeroPaginas);

            Libro libro = new Libro
            {
                isbn = isbn,
                titulo = titulo,
                autor = autor,
                annoPublicacion = annoPublicacion,
                numeroPaginas = numeroPaginas
            };

            biblioteca.agregarLibro(libro);
        }

        static void modificarLibro(Ibiblioteca biblioteca)
        {
            Console.Write("ISBN del libro a modificar: ");
            var isbn = Console.ReadLine();

            Console.Write("Nuevo Título: ");
            var titulo = Console.ReadLine();
            Console.Write("Nuevo Autor: ");
            var autor = Console.ReadLine();
            Console.Write("Nuevo Año de Publicación: ");
            int.TryParse(Console.ReadLine(), out int annoPublicacion);
            Console.Write("Nuevo Número de Páginas: ");
            int.TryParse(Console.ReadLine(), out int numeroPaginas);

            Libro libroModificado = new Libro
            {
                titulo = titulo,
                autor = autor,
                annoPublicacion = annoPublicacion,
                numeroPaginas = numeroPaginas
            };

            biblioteca.modificarLibro(isbn, libroModificado);
        }

        static void EliminarLibro(Ibiblioteca biblioteca)
        {
            Console.Write("ISBN del libro a eliminar: ");
            var isbn = Console.ReadLine();

            biblioteca.eliminarLibro(isbn);
        }

        static void buscarLibro(Ibiblioteca biblioteca)
        {
            Console.Write("Criterio de búsqueda: ");
            var criterio = Console.ReadLine();

            var libros = biblioteca.buscarLibros(criterio);

            foreach (var libro in libros)
            {
                Console.WriteLine($"Título: {libro.titulo}, Autor: {libro.autor}, ISBN: {libro.isbn}, Año de Publicación: {libro.annoPublicacion}, Número de Páginas: {libro.numeroPaginas}");
            }
        }

        static void agregarUsuario(Ibiblioteca biblioteca)
        {
            Console.Write("Número de Socio: ");
            var numeroSocio = Console.ReadLine();
            Console.Write("Nombre: ");
            var nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            var apellido = Console.ReadLine();

            Usuario usuario = new Usuario
            {
                numeroSocio = numeroSocio,
                nombre = nombre,
                apellido = apellido
            };

            biblioteca.agregarUsuario(usuario);
        }

        static void ModificarUsuario(Ibiblioteca biblioteca)
        {
            Console.Write("Número de Socio del usuario a modificar: ");
            var numeroSocio = Console.ReadLine();

            Console.Write("Nuevo Nombre: ");
            var nombre = Console.ReadLine();
            Console.Write("Nuevo Apellido: ");
            var apellido = Console.ReadLine();

            Usuario usuarioModificado = new Usuario
            {
                nombre = nombre,
                apellido = apellido
            };

            biblioteca.modificarUsuario(numeroSocio, usuarioModificado);
        }

        static void EliminarUsuario(Ibiblioteca biblioteca)
        {
            Console.Write("Número de Socio del usuario a eliminar: ");
            var numeroSocio = Console.ReadLine();

            biblioteca.eliminarUsuario(numeroSocio);
        }

        static void PrestarLibro(Ibiblioteca biblioteca)
        {
            Console.Write("ISBN del libro a prestar: ");
            var isbn = Console.ReadLine();
            Console.Write("Número de Socio: ");
            var numeroSocio = Console.ReadLine();

            biblioteca.prestarLibro(isbn, numeroSocio);
        }

        static void DevolverLibro(Ibiblioteca biblioteca)
        {
            Console.Write("ISBN del libro a devolver: ");
            var isbn = Console.ReadLine();
            Console.Write("Número de Socio: ");
            var numeroSocio = Console.ReadLine();

            biblioteca.devolverLibro(isbn, numeroSocio);
        }

        static void agregarRevista(Ibiblioteca biblioteca)
        {
            Console.Write("Título: ");
            var titulo = Console.ReadLine();
            Console.Write("Editor: ");
            var editor = Console.ReadLine();
            Console.Write("ISSN: ");
            var issn = Console.ReadLine();
            Console.Write("Año de Publicación: ");
            int.TryParse(Console.ReadLine(), out int annoPublicacion);
            Console.Write("Número de Edición: ");
            int.TryParse(Console.ReadLine(), out int numeroEdicion);

            revista revista = new revista
            {
                issn = issn,
                titulo = titulo,
                editor = editor,
                annoPublicacion = annoPublicacion,
                numeroEdicion = numeroEdicion
            };

            biblioteca.agregarRevista(revista);
        }

        public void modificarRevista(string issn, revista revistaModificada)
        {
            var revista = _context.revistas.Find(issn);
            if (revista != null)
            {
                revista.titulo = revistaModificada.titulo;
                revista.editorial = revistaModificada.editorial;
                revista.annoPublicacion = revistaModificada.annoPublicacion;
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

        public void agregarDVD(DVD dvd)
        {
            _context.DVDs.Add(dvd);
            _context.SaveChanges();
        }

        public void modificarDVD(string DVD, DVD dvdModificado)
        {
            var dvd = _context.DVDs.Find(DVD);
            if (dvd != null)
            {
                dvd.titulo = dvdModificado.titulo;
                dvd.director = dvdModificado.director;
                dvd.annoPublicacion = dvdModificado.annoPublicacion;
                dvd.genero = dvdModificado.genero;
                _context.SaveChanges();
            }
        }

        public void eliminarDVD(string DVD)
        {
            var dvd = _context.DVDs.Find(DVD);
            if (dvd != null)
            {
                _context.DVDs.Remove(dvd);
                _context.SaveChanges();
            }
        }

        public DVD BuscarDVD(string DVD)
        {
            return _context.DVDs.Find(DVD);
        }
    }
}


