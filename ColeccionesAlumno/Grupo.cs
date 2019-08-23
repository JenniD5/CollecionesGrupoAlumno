using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesAlumno
{
    class Grupo
    {
        public string Materia { get; set; } 
        public string Codigo { get; set; }

        public List <Alumno> Alumnos { get; set; }


        public Grupo(string materia, string codigo)
        {
            Materia = materia;
            Codigo = codigo;

            Alumnos = new List<Alumno>(); // para que cree una lista nueva, se inicializa para que tenga (se le asigne) un espacio de memoria y no se quede en nulo 

        }

    }
}
