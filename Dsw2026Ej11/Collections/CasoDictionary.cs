using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    private Dictionary<int, Alumno> alumnosDict = new Dictionary<int, Alumno>();

    public void AgregarAlumno(int legajo, Alumno alumno)
    {
        bool agregado = alumnosDict.TryAdd(legajo, alumno);
    }

    public Alumno? BuscarAlumno(int key)
    {
        return alumnosDict.ContainsKey(key) ? alumnosDict[key] : null;
    }

    public Dictionary<int, Alumno> ObtenerDiccionario()
    {
        return alumnosDict;
    }

    public void EliminarAlumno(int key)
    {
        alumnosDict.Remove(key);
    }

}
