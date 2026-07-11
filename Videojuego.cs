using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BibliotecaDeJuegos
{
    public class Videojuego
    {
        private string nombre, género, subgénero, plataforma, dificultad, duración, estiloVisual, experiencia, popularidad;
        private double puntuación;

        public Videojuego(string nombre, string género, string subgénero, string plataforma, string dificultad, string duración, string estiloVisual, string experiencia, string popularidad, double puntuación)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("Debe escribir el nombre del juego.");
            if (string.IsNullOrWhiteSpace(género))
                throw new ArgumentException("Debe seleccionar el genero.");
            if (string.IsNullOrWhiteSpace(plataforma))
                throw new ArgumentException("Debe seleccionar la plataforma.");
            if (puntuación < 1 || puntuación > 10)
                throw new ArgumentException("La valoracion debe estar entre 1 y 10.");

            this.nombre = nombre.Trim();
            this.género = NormalizarGenero(género);
            this.subgénero = subgénero.Trim();
            this.plataforma = NormalizarPlataforma(plataforma);
            this.dificultad = dificultad;
            this.duración = duración;
            this.estiloVisual = estiloVisual;
            this.experiencia = experiencia;
            this.popularidad = popularidad;
            this.puntuación = puntuación;
        }

        private string NormalizarGenero(string genero)
        {
            string texto = genero.Trim();

            if (string.Equals(texto, "Carrera", StringComparison.OrdinalIgnoreCase))
            {
                return "Carreras";
            }

            return texto;
        }

        private string NormalizarPlataforma(string plataforma)
        {
            string texto = plataforma.Trim();

            if (string.Equals(texto, "Steam", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(texto, "Epic games", StringComparison.OrdinalIgnoreCase))
            {
                return "PC";
            }

            if (string.Equals(texto, "Playstation", StringComparison.OrdinalIgnoreCase))
            {
                return "PlayStation";
            }

            return texto;
        }

        public string ObtenerLineaArchivo()
        {
            return Nombre + ";" + Género + ";" + Subgénero + ";" + Plataforma + ";" +
                Dificultad + ";" + Duración + ";" + EstiloVisual + ";" + Experiencia + ";" +
                Popularidad + ";" + Puntuación.ToString("0.0", CultureInfo.InvariantCulture);
        }

        public bool EsAgregadoPorUsuario()
        {
            return Subgénero == "Agregado por usuario";
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
