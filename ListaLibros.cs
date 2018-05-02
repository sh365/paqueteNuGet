using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecasNuGet
{
    public class ListaLibros : List<Libro>
    {
        public ListaLibros()
        {
            Libro libro = new Libro
            {
                IdLibro = 1,
                Titulo = "Cien años de soledad",
                Autor = "Gabriel García Márquez"
            };
            this.Add(libro);
            libro = new Libro
            {
                IdLibro = 2,
                Titulo = "El señor de los anillos",
                Autor = "J. R. R. Tolkien"
            };
            this.Add(libro);
            libro = new Libro
            {
                IdLibro = 3,
                Titulo = "1984",
                Autor = "George Orwell"
            };
            this.Add(libro);
            libro = new Libro
            {
                IdLibro = 4,
                Titulo = "Un mundo feliz",
                Autor = "Aldous Huxley"
            };
            this.Add(libro);
            libro = new Libro
            {
                IdLibro = 5,
                Titulo = "Orgullo y prejuicio",
                Autor = "Jane Austen"
            };
            this.Add(libro);
            libro = new Libro
            {
                IdLibro = 6,
                Titulo = "Crimen y castigo",
                Autor = "Fiódor Dostoyevski"
            };
            this.Add(libro);
            libro = new Libro
            {
                IdLibro = 7,
                Titulo = "Lolita",
                Autor = "Vladimir Nabokov"
            };
            this.Add(libro);
            libro = new Libro
            {
                IdLibro = 8,
                Titulo = "Ulises",
                Autor = "James Joyce"
            };
            this.Add(libro);
            libro = new Libro
            {
                IdLibro = 9,
                Titulo = "Madame Bovary",
                Autor = "Gustave Flaubert"
            };
            libro = new Libro
            {
                IdLibro = 10,
                Titulo = "En busca del tiempo perdido",
                Autor = "Marcel Proust"
            };
            this.Add(libro);
        }
    }
}
