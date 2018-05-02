using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecasNuGet
{
    public class Biblioteca
    {
        public List<Libro> RecuperarLibros()
        {
            List<Libro> lista = new ListaLibros();
            return lista;
        }
        public Libro BuscarLibro(int id)
        {
            List<Libro> lista = new ListaLibros();
            Libro libro = lista.Find(x => x.IdLibro == id);
            return libro;
        }
    }
}
