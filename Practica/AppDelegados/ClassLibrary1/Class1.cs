using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        private string _apellido;
        private int _dni;
        private string _fotoAlumno;
        private string _nombre;

        public string Apellido { get {return this._apellido;} set {this._apellido = value;} }
        public int DNI { get{return this._dni;} set {this._dni = value;} }
        public string RutaDeLaFoto { get {return this._fotoAlumno;} set {this._fotoAlumno = value;} }
        public string Nombre { get {return this._nombre;} set {this._nombre = value;} }

        public Alumno(string nombre, string apellido, string ruta, int dni)
        {
            this.Apellido = apellido;
            this.DNI = dni;
            this.RutaDeLaFoto = ruta;
            this.Nombre = nombre;

        }


    }
}
