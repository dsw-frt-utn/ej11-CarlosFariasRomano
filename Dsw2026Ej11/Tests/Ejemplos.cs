using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;
using Microsoft.VisualBasic;
using System.Globalization;

namespace Dsw2026Ej11.Tests;

internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList listAlu = new CasoList();

        Alumno alu1 = new Alumno(25, "Antonio", 6.5);
        Alumno alu2 = new Alumno(30, "Mariano", 9.1);
        Alumno alu3 = new Alumno(35, "Julian", 7.8);

        listAlu.AgregarAlumno(alu1);
        listAlu.AgregarAlumno(alu2);
        listAlu.AgregarAlumno(alu3);

        Console.WriteLine("--- LISTA INCIAL ALUMNOS ---");
        foreach (var a in listAlu.ObtenerLista())
        {
            Console.WriteLine(a);
        }
        Console.WriteLine();

        Console.WriteLine("--- BUSQUEDA DE ALUMNOS EN LISTA ---");
        Console.WriteLine(listAlu.BuscarAluPorNombre("Mariano"));
        var encontrado = listAlu.BuscarAluPorNombre("Nacho");
        Console.WriteLine(encontrado != null ? encontrado.ToString() : "El alumno buscado No existe");
        Console.WriteLine();

        Console.WriteLine("--- ELIMINACION DE ALUMNO Y LISTADO ---");
        listAlu.EliminarAlumno(alu2);
        foreach (var a in listAlu.ObtenerLista())
        {
            Console.WriteLine(a);
        }
        Console.WriteLine();

        Console.WriteLine("--- ELIMINACION ALUMNO POR POSICION Y LISTADO");
        listAlu.EliminarPorPosicion(0);
        foreach (var a in listAlu.ObtenerLista())
        {
            Console.WriteLine(a);
        }
        Console.WriteLine();

    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary dictAlu = new CasoDictionary();

        Alumno alu1 = new Alumno(258, "Antonio", 6.5);
        Alumno alu2 = new Alumno(307, "Mariano", 9.1);
        Alumno alu3 = new Alumno(322, "Julian", 7.8);

        dictAlu.AgregarAlumno(alu1.Id, alu1);
        dictAlu.AgregarAlumno(alu2.Id, alu2);
        dictAlu.AgregarAlumno(alu3.Id, alu3);

        Console.WriteLine("--- DICCIONARIO INCIAL ALUMNOS ---");
        foreach (var item in dictAlu.ObtenerDiccionario())
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        Console.WriteLine("--- BUSQUEDA ALUMNO POR CLAVE ---");
        Console.WriteLine(dictAlu.BuscarAlumno(307));
        Console.WriteLine();

        Console.WriteLine("--- BUSQUEDA ALUMNO INEXISTENTE POR CLAVE ---");
        var busqueda = dictAlu.BuscarAlumno(40);
        Console.WriteLine(busqueda != null ? busqueda.ToString() : "El alumno buscado no existe");
        Console.WriteLine();

        Console.WriteLine("--- ELIMINACION DE ALUMNO POR CLAVE Y LISTADO ---");
        dictAlu.EliminarAlumno(322);
        foreach (var item in dictAlu.ObtenerDiccionario())
        {
            Console.WriteLine($"{item.Key} - {item.Value.Nombre} - {item.Value.Promedio}");
        }
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda

    public static void EjemploLinq()
    {
        CultureInfo.CurrentCulture = new CultureInfo("es-AR");
        CasoLinq linqLibro = new CasoLinq();

        Console.WriteLine("--- PRIMER LIBRO ---");
        var primero = linqLibro.GetPrimero();
        Console.WriteLine($"ID: {primero.Id} - Titulo: {primero.Titulo} - Precio: {primero.Precio:C}");
        Console.WriteLine();
        Console.WriteLine("--- ULTIMO LIBRO ---");
        var ultimo = linqLibro.GetUltimo();
        Console.WriteLine($"ID: {ultimo.Id} - Titulo: {ultimo.Titulo} - Precio: {ultimo.Precio:C}");
        Console.WriteLine();
        Console.WriteLine("--- SUMA PRECIOS LIBROS ---");
        Console.WriteLine(linqLibro.GetTotalPrecios().ToString("C"));
        Console.WriteLine();
        Console.WriteLine("--- PROMEDIO PRECIOS LIBROS ---");
        Console.WriteLine(linqLibro.GetPromedioPrecios().ToString("C"));
        Console.WriteLine();
        Console.WriteLine("--- LISTA LIBROS POR ID > 15 ---");
        foreach (var l in linqLibro.GetListById())
        {
            Console.WriteLine($"ID: {l.Id} - Titulo: {l.Titulo} - Precio: {l.Precio:C}");
        }
        Console.WriteLine();
        Console.WriteLine("--- LISTA LIBROS POR TITULO Y PRECIO ---");
        foreach (var l in linqLibro.GetLibro())
        {
            Console.WriteLine(l);
        }
        Console.WriteLine();
        Console.WriteLine("--- LIBRO MAYOR PRECIO ---");
        var mayor = linqLibro.GetMayorPrecio();
        Console.WriteLine($"ID: {mayor.Id} - Titulo: {mayor.Titulo} - Precio: {mayor.Precio:C}");
        Console.WriteLine();
        Console.WriteLine("--- LIBRO MENOR PRECIO ---");
        var menor = linqLibro.GetMenorPrecio();
        Console.WriteLine($"ID: {menor.Id} - Titulo: {menor.Titulo} - Precio: {menor.Precio:C}");
        Console.WriteLine();
        Console.WriteLine("--- LISTA LIBROS POR PRECIO > PROMEDIO ---");
        Console.WriteLine($"Promedio: {linqLibro.GetPromedioPrecios():C}");
        foreach (var l in linqLibro.GetMayorPromedio())
        {
            Console.WriteLine($"ID: {l.Id} - Titulo: {l.Titulo} - Precio: {l.Precio:C}");
        }
        Console.WriteLine();
        Console.WriteLine("--- LISTA LIBROS ORDENADOS DESCENDENTEMENTE ---");
        foreach (var l in linqLibro.GetLibrosOrdenados())
        {
            Console.WriteLine(l.Titulo);
        }

    }
}
