using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesAlumno
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Grupo> grupos = new List<Grupo>();

            //son variable aisladas
            Grupo matematicas = new Grupo("Matematicas", "cdmat5736");//dar de alta un gurpo
            Grupo historia = new Grupo("historia", "h5783");

            //añadir a la lista, las variables anteriores 
            grupos.Add(matematicas);
            grupos.Add(historia);

            Alumno juan = new Alumno("juan", "89543");
            Alumno maria = new Alumno("maria", "79y857439");
            Alumno lili = new Alumno("lili", "89ln9");
            Alumno ana = new Alumno("ana", "a89889");
            Alumno victor = new Alumno("victor", "u4892");


            historia.Alumnos.Add(juan);//para agregar a la lista 
            historia.Alumnos.Add(lili);
            historia.Alumnos.Add(maria);

            matematicas.Alumnos.Add(ana);
            matematicas.Alumnos.Add(victor);
            matematicas.Alumnos.Add(lili);
            matematicas.Alumnos.Add(juan);
            matematicas.Alumnos.Add(maria);
           

            foreach(Grupo grupo in grupos)//declarar una variable, para cada grupo en la coleccion gurpo hace lo siguiente, el primero es le tipo de dato

            {
                Console.WriteLine("grupo:" + grupo.Codigo);
                Console.WriteLine("materia:" + grupo.Materia);
                Console.WriteLine("lista de alumnos");

                foreach(Alumno alumno in grupo.Alumnos)
                {
                    Console.WriteLine("*" + alumno.Nombre);
                    Console.WriteLine("        -"+alumno.Matricula);          
                }
            }


            Console.Read();



        }
    }
}
