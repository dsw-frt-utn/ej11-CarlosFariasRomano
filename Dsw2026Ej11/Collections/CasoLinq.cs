using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

/*
 * Para cada punto crear un método que permita:
 * 1. Obtener el primer libro (GetPrimero)
 * 2. Obtener el último libro (GetUltimo)
 * 3. Obtener la suma de precios (GetTotalPrecios)
 * 4. Obtener el promedio de precios (GetPromedioPrecios)
 * 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
 * 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)
 * 7. Obtener el libro con el precio más alto (GetMayorPrecio)
 * 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
 * 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
 * 10. Obtener los libros ordenados por título de forma descendente
 * En todos los casos debe aplicarse LINQ
 */
public class CasoLinq
{
    private List<Libro> libros = Libro.CrearLista();

    public Libro GetPrimero()
    {
        return libros.First();
    }
    
    public Libro GetUltimo()
    {
        return libros.Last();
    }

    public decimal GetTotalPrecios()
    {
        return libros.Sum(l => l.Precio);
    }
    
    public decimal GetPromedioPrecios()
    {
        return libros.Average(l => l.Precio);
    }

    public IEnumerable<Libro> GetListById()
    {
        var consulta = from l in libros
                       where l.Id > 15
                       select l;

        return consulta
    }

    public IEnumerable<string> GetLibro()
    {
        var consulta = from l in libros
                       select l.Titulo + " - " + l.Precio.ToString("C");
        return consulta;
    }

    public Libro GetMayorPrecio()
    {
        decimal maximoPrecio = libros.Max(l => l.Precio);
        var consulta = from l in libros
                       where l.Precio == maximoPrecio
                       select l;

        return consulta.First();
    }

    public Libro GetMenorPrecio()
    {
        decimal minimoPrecio = libros.Min(l => l.Precio);
        var consulta = from l in libros
                       where l.Precio == minimoPrecio
                       select l;
        
        return consulta.First();
    }

    public IEnumerable<Libro> GetMayorPromedio()
    {
        decimal promedio = GetPromedioPrecios();

        var consulta = from l in libros
                       where l.Precio > promedio
                       select l;

        return consulta;
    }

    public IEnumerable<Libro> GetLibrosOrdenados()
    {
        var consulta = from l in libros
                       orderby l.Titulo descending
                       select l;

        return consulta; 
    }

}
