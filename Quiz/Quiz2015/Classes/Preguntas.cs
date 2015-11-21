using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.Classes
{
    public class Preguntas
    {
        protected string Pregunta { get; set; }
        protected string Respuesta { get; set; }
        protected string Tema { get; set; }

        public Preguntas(string pregunta, string respuesta, string tema)
        {
            this.Pregunta = pregunta;
            this.Respuesta = respuesta;
            this.Tema = tema;
        }

        public abstract void mostrarPreguntas();
    }
}