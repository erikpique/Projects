using System;

namespace Quiz2015.Comentario
{
    public class Comment
    {
        protected string comentario { get; set; }
        protected bool publicado { get; set; }

        protected Guid? idPregunta { get; set; }

        public void Comentario(string _comentario, bool _publicado, Guid? _idpregunta)
        {
            comentario = _comentario;
            publicado = _publicado;
            idPregunta = _idpregunta;
        }
    }
}