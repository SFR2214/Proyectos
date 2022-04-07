using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPro
{
    class Alumno
    {
        //Declarar los miembros de tipo campo 
        String matricula, contrasena = "12345678", carrera;
        String nombre, primerApellido, segundoApellido, curp;
        DateTime fechaNacimiento, fechaInscripcion;
        Char seccion, semestre;
        bool acceso = false;
        private char tipoSangre;

        //miembros de tipo constante
        const string NUMERO_TECNOLOGICO = "100";

        public Alumno(string nombre, string primerApellido, string segundoApellido, string curp, DateTime fechaNacimiento, DateTime fechaIinscripcion, char tipoSangre)
        {
            this.nombre = nombre;
            this.segundoApellido = segundoApellido;
            this.primerApellido = primerApellido;
            this.curp = curp;
            this.fechaNacimiento = fechaNacimiento;
            this.fechaInscripcion = fechaIinscripcion;
            // this es un apuntador (para declarar las bariables globales)
            //sea creada la matricula 
            //anexar matricula el valor de la clase static
            //camino largo
            if(foliopro.numeroFolio >= 1 && foliopro.numeroFolio <= 9)
            {
                this.matricula = (fechaIinscripcion.Year + "" + NUMERO_TECNOLOGICO).Substring(2, 5) + "000" + foliopro.numeroFolio;
            }
            if (foliopro.numeroFolio >= 10 && foliopro.numeroFolio <= 90)
            {
                this.matricula = (fechaIinscripcion.Year + "" + NUMERO_TECNOLOGICO).Substring(2, 5) + "00" + foliopro.numeroFolio;
            }
            if (foliopro.numeroFolio >= 100 )
            {
                this.matricula = (fechaIinscripcion.Year + "" + NUMERO_TECNOLOGICO).Substring(2, 5) + "000" + foliopro.numeroFolio;
            }

            this.matricula = (fechaIinscripcion.Year + "" + NUMERO_TECNOLOGICO).Substring(2, 5) + "0" + foliopro.numeroFolio;
            foliopro.numeroFolio = foliopro.numeroFolio + 1; 
            // +""+ sellama contatenar, es unir para hacer una nueva bariable 

            


        }
      
        //Agregar un miembro de tipo propiedad
        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }

        }
        public String Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }

        }
       public bool Acceso
       {
            get { return acceso; }
            set { acceso = value; }
        }
        public char Seccion
        {
            get { return seccion; }
            set { seccion = value; }
        }
        public string ApeidoPaterno
        {
           set { primerApellido = value; }
           get { return primerApellido; }
        }
        public string ApeidoMaterno
        {
            get { return segundoApellido; }
            set { segundoApellido = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        public string Curp
        {
            set { curp = value; }
            get { return curp; }
        }
        //agregar miembro tipo metodo 
        //tipoDeAcceso tipoDatos nombre (opcionalmente params){}
        //tipo: pubrlic| private | protected | internal
        // string | int | bool| double | char | float | smallint
        public string CalcularEdad()
        {
            int edad;
            edad = (DateTime.Now - fechaNacimiento).Days;
            String valorDeRetornoDeLaFuncion =
                String.Format("la edad del alumno{0}, es de {1}.", nombre, edad.ToString());
            edad = (DateTime.Now - fechaNacimiento).Days / 365;
            //si no if else

            if (fechaNacimiento.Year <= 1999)
            {
                valorDeRetornoDeLaFuncion = "El alumo tiene una Fecha no asignada";
            }
            else
            {
               edad = (DateTime.Now - fechaNacimiento).Days/365;
                valorDeRetornoDeLaFuncion =
                    string.Format("la edad del alimno {0} {2}{3}, es de {1}, año.", nombre, edad.ToString(), primerApellido, matricula/*.IndexOf(matricula,2,2)*/);
            }
            // determinar la salida de la funcion
            //return edad.ToString();
            return edad.ToString();
           
          
            //si no if else
        }
        

        public byte CalcularEdad2(DateTime fechaNacimientoParam)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            fechaNacimiento = fechaNacimientoParam;
            //validar si se cargo la fecha de nacimeinto de mi objeto
            int edad;
            edad = (DateTime.Now - fechaNacimientoParam).Days / 365;
            //si no if else
            if (edad >= 100)
            {
                //Tarea: la variable valorDeRetornoDeLaFuncion debe regreresar une
                //string.Format en que debe imprimir el nombre del alumno
                edad = 0;
            }
            //determinar la salida de la funcion
            //return edad.ToString();
            return Convert.ToByte(edad);
        }





















    }
}