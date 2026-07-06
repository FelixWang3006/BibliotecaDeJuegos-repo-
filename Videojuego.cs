using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeJuegos
{
    public class Videojuego
    {
        private string nombre, género, subgénero, plataforma, dificultad, duración, estiloVisual, experiencia, popularidad;
        private double puntuación;

        public Videojuego(string nombre, string género, string subgénero, string plataforma, string dificultad, string duración, string estiloVisual, string experiencia, string popularidad, double puntuación)
        {
            this.nombre = nombre;
            this.género = género;
            this.subgénero = subgénero;
            this.plataforma = plataforma;
            this.dificultad = dificultad;
            this.duración = duración;
            this.estiloVisual = estiloVisual;
            this.experiencia = experiencia;
            this.popularidad = popularidad;
            this.puntuación = puntuación;
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public string Género
        {
            get
            {
                return género;
            }
            set
            {
                género = value;
            }
        }
        public string Subgénero
        {
            get
            {
                return subgénero;
            }
            set
            {
                subgénero = value;
            }
        }
        public string Plataforma
        {
            get
            {
                return plataforma;
            }
            set
            {
                plataforma = value;
            }
        }
        public string Dificultad
        {
            get
            {
                return dificultad;
            }
            set
            {
                dificultad = value;
            }
        }
        public string Duración
        {
            get
            {
                return duración;
            }
            set
            {
                duración = value;
            }
        }
        public string EstiloVisual
        {
            get
            {
                return estiloVisual;
            }
            set
            {
                estiloVisual = value;
            }
        }
        public string Experiencia
        {
            get
            {
                return experiencia;
            }
            set
            {
                experiencia = value;
            }
        }
        public string Popularidad
        {
            get
            {
                return popularidad;
            }
            set
            {
                popularidad = value;
            }
        }
        public double Puntuación
        {
            get
            {
                return puntuación;
            }
            set
            {
                puntuación = value;
            }
        }

    }
}
