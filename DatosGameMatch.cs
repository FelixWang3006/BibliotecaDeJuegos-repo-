using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BibliotecaDeJuegos
{
    public static class DatosGameMatch
    {
        private static List<Videojuego> biblioteca = new List<Videojuego>();
        private static List<Videojuego> juegosPerfil = new List<Videojuego>();
        private static List<string> favoritos = new List<string>();
        private static bool datosCargados = false;
        private static string rutaArchivo = "";
        private static string rutaPerfil = "";
        private static string rutaJuegosUsuario = "";

        public static List<Videojuego> Biblioteca
        {
            get { return biblioteca; }
        }

        public static List<Videojuego> JuegosPerfil
        {
            get { return juegosPerfil; }
        }

        public static void CargarBiblioteca()
        {
            if (datosCargados)
            {
                return;
            }

            rutaArchivo = Path.Combine(Application.StartupPath, "videojuegos.txt");
            string carpetaDatos = Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApplicationData), "GameMatch");
            rutaPerfil = Path.Combine(carpetaDatos, "perfil_gamer.txt");
            rutaJuegosUsuario = Path.Combine(carpetaDatos, "juegos_usuario.txt");

            if (!File.Exists(rutaArchivo))
            {
                throw new FileNotFoundException("No se encontro el archivo videojuegos.txt.", rutaArchivo);
            }

            string[] lineas = File.ReadAllLines(rutaArchivo, Encoding.UTF8);
            List<Videojuego> juegosCargados = new List<Videojuego>();

            for (int i = 0; i < lineas.Length; i++)
            {
                if (lineas[i].Trim() != "")
                {
                    Videojuego juego = CrearJuegoDesdeLinea(lineas[i], i + 1);
                    juegosCargados.Add(juego);
                }
            }

            CargarJuegosDelUsuario(juegosCargados);

            biblioteca.Clear();

            for (int i = 0; i < juegosCargados.Count; i++)
            {
                biblioteca.Add(juegosCargados[i]);
            }

            datosCargados = true;
            GuardarJuegosUsuario();
            CargarPerfilGuardado();
        }

        private static Videojuego CrearJuegoDesdeLinea(string linea, int numeroLinea)
        {
            string[] datos = linea.Split(';');
            double puntuacion;

            if (datos.Length != 10)
            {
                throw new FormatException("La linea " + numeroLinea + " del archivo de juegos no tiene 10 datos.");
            }

            if (!double.TryParse(datos[9], NumberStyles.Any, CultureInfo.InvariantCulture, out puntuacion) &&
                !double.TryParse(datos[9], out puntuacion))
            {
                throw new FormatException("La puntuacion de la linea " + numeroLinea + " no es valida.");
            }

            return new Videojuego(datos[0], datos[1], datos[2], datos[3], datos[4],
                datos[5], datos[6], datos[7], datos[8], puntuacion);
        }

        public static bool AgregarAlPerfil(Videojuego juego)
        {
            if (juego == null)
            {
                throw new ArgumentException("Debe seleccionar un juego.");
            }

            if (BuscarEnLista(juegosPerfil, juego.Nombre) != null)
            {
                return false;
            }

            juegosPerfil.Add(juego);
            GuardarPerfil();
            return true;
        }

        public static void QuitarDelPerfil(string nombre)
        {
            Videojuego juego = BuscarEnLista(juegosPerfil, nombre);

            if (juego != null)
            {
                juegosPerfil.Remove(juego);
            }

            CambiarFavorito(nombre, false);
            GuardarPerfil();
        }

        public static bool EsFavorito(string nombre)
        {
            for (int i = 0; i < favoritos.Count; i++)
            {
                if (string.Equals(favoritos[i], nombre, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        public static void CambiarFavorito(string nombre, bool esFavorito)
        {
            bool existe = EsFavorito(nombre);

            if (esFavorito && !existe)
            {
                favoritos.Add(nombre);
            }
            else if (!esFavorito && existe)
            {
                for (int i = favoritos.Count - 1; i >= 0; i--)
                {
                    if (string.Equals(favoritos[i], nombre, StringComparison.OrdinalIgnoreCase))
                    {
                        favoritos.RemoveAt(i);
                    }
                }
            }

            GuardarPerfil();
        }

        public static List<Videojuego> ObtenerFavoritos()
        {
            List<Videojuego> lista = new List<Videojuego>();

            for (int i = 0; i < juegosPerfil.Count; i++)
            {
                if (EsFavorito(juegosPerfil[i].Nombre))
                {
                    lista.Add(juegosPerfil[i]);
                }
            }

            return lista;
        }

        public static List<Videojuego> ObtenerRecomendaciones()
        {
            List<Videojuego> listaFavoritos = ObtenerFavoritos();
            List<Videojuego> recomendaciones = new List<Videojuego>();
            List<int> puntajes = new List<int>();

            for (int i = 0; i < biblioteca.Count; i++)
            {
                Videojuego candidato = biblioteca[i];

                if (BuscarEnLista(juegosPerfil, candidato.Nombre) == null)
                {
                    int puntaje = CalcularCoincidencia(candidato, listaFavoritos);

                    if (puntaje > 0)
                    {
                        recomendaciones.Add(candidato);
                        puntajes.Add(puntaje);
                    }
                }
            }

            // Ordenamiento sencillo de mayor coincidencia y luego mayor puntuacion.
            for (int i = 0; i < recomendaciones.Count - 1; i++)
            {
                for (int j = i + 1; j < recomendaciones.Count; j++)
                {
                    if (puntajes[j] > puntajes[i] ||
                        (puntajes[j] == puntajes[i] && recomendaciones[j].Puntuación > recomendaciones[i].Puntuación))
                    {
                        Videojuego juegoTemporal = recomendaciones[i];
                        recomendaciones[i] = recomendaciones[j];
                        recomendaciones[j] = juegoTemporal;

                        int puntajeTemporal = puntajes[i];
                        puntajes[i] = puntajes[j];
                        puntajes[j] = puntajeTemporal;
                    }
                }
            }

            if (recomendaciones.Count > 20)
            {
                recomendaciones.RemoveRange(20, recomendaciones.Count - 20);
            }

            return recomendaciones;
        }

        private static int CalcularCoincidencia(Videojuego candidato, List<Videojuego> listaFavoritos)
        {
            int mejorPuntaje = 0;

            for (int i = 0; i < listaFavoritos.Count; i++)
            {
                int puntaje = 0;

                if (string.Equals(candidato.Género, listaFavoritos[i].Género, StringComparison.OrdinalIgnoreCase))
                {
                    puntaje += 4;
                }

                if (PlataformasRelacionadas(candidato.Plataforma, listaFavoritos[i].Plataforma))
                {
                    puntaje += 3;
                }

                double diferencia = Math.Abs(candidato.Puntuación - listaFavoritos[i].Puntuación);

                if (diferencia <= 1)
                {
                    puntaje += 3;
                }
                else if (diferencia <= 2)
                {
                    puntaje += 1;
                }

                if (puntaje > mejorPuntaje)
                {
                    mejorPuntaje = puntaje;
                }
            }

            return mejorPuntaje;
        }

        private static bool PlataformasRelacionadas(string plataforma1, string plataforma2)
        {
            string texto1 = plataforma1.ToLower();
            string texto2 = plataforma2.ToLower();

            return texto1.Contains(texto2) || texto2.Contains(texto1) ||
                   (texto1.Contains("playstation") && texto2.Contains("playstation")) ||
                   (texto1.Contains("xbox") && texto2.Contains("xbox")) ||
                   (texto1.Contains("nintendo") && texto2.Contains("nintendo"));
        }

        public static void AgregarJuego(Videojuego juego)
        {
            if (juego == null)
            {
                throw new ArgumentException("Los datos del juego no son validos.");
            }

            if (BuscarEnLista(biblioteca, juego.Nombre) != null)
            {
                throw new ArgumentException("Ya existe un juego con ese nombre en la biblioteca.");
            }

            biblioteca.Add(juego);

            try
            {
                GuardarJuegosUsuario();
            }
            catch
            {
                biblioteca.Remove(juego);
                throw;
            }
        }

        public static void EliminarJuegoAgregado(string nombre)
        {
            Videojuego juego = BuscarEnLista(biblioteca, nombre);

            if (juego == null || !juego.EsAgregadoPorUsuario())
            {
                throw new ArgumentException("Solo se pueden eliminar los juegos agregados por el usuario.");
            }

            biblioteca.Remove(juego);
            QuitarDelPerfil(nombre);
            GuardarJuegosUsuario();
        }

        private static void CargarJuegosDelUsuario(List<Videojuego> juegosCargados)
        {
            string rutaLectura = rutaJuegosUsuario;

            if (!File.Exists(rutaLectura))
            {
                rutaLectura = Path.Combine(Application.StartupPath, "juegos_usuario_inicial.txt");

                if (!File.Exists(rutaLectura))
                {
                    return;
                }
            }

            string[] lineas = File.ReadAllLines(rutaLectura, Encoding.UTF8);

            for (int i = 0; i < lineas.Length; i++)
            {
                if (lineas[i].Trim() != "")
                {
                    Videojuego juego = CrearJuegoDesdeLinea(lineas[i], i + 1);

                    if (BuscarEnLista(juegosCargados, juego.Nombre) == null)
                    {
                        juegosCargados.Add(juego);
                    }
                }
            }
        }

        private static void GuardarJuegosUsuario()
        {
            string carpeta = Path.GetDirectoryName(rutaJuegosUsuario);

            if (!Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(carpeta);
            }

            List<string> lineas = new List<string>();

            for (int i = 0; i < biblioteca.Count; i++)
            {
                if (biblioteca[i].EsAgregadoPorUsuario())
                {
                    lineas.Add(biblioteca[i].ObtenerLineaArchivo());
                }
            }

            File.WriteAllLines(rutaJuegosUsuario, lineas.ToArray(), Encoding.UTF8);
        }

        private static void CargarPerfilGuardado()
        {
            juegosPerfil.Clear();
            favoritos.Clear();

            if (!File.Exists(rutaPerfil))
            {
                return;
            }

            string[] lineas = File.ReadAllLines(rutaPerfil, Encoding.UTF8);

            for (int i = 0; i < lineas.Length; i++)
            {
                string[] datos = lineas[i].Split(';');

                if (datos.Length == 2)
                {
                    Videojuego juego = BuscarEnLista(biblioteca, datos[0]);
                    bool esFavorito;

                    if (juego != null && bool.TryParse(datos[1], out esFavorito))
                    {
                        juegosPerfil.Add(juego);

                        if (esFavorito)
                        {
                            favoritos.Add(juego.Nombre);
                        }
                    }
                }
            }
        }

        private static void GuardarPerfil()
        {
            if (!datosCargados || rutaPerfil == "")
            {
                return;
            }

            string carpeta = Path.GetDirectoryName(rutaPerfil);

            if (!Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(carpeta);
            }

            string[] lineas = new string[juegosPerfil.Count];

            for (int i = 0; i < juegosPerfil.Count; i++)
            {
                lineas[i] = juegosPerfil[i].Nombre + ";" + EsFavorito(juegosPerfil[i].Nombre);
            }

            File.WriteAllLines(rutaPerfil, lineas, Encoding.UTF8);
        }

        private static Videojuego BuscarEnLista(List<Videojuego> lista, string nombre)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (string.Equals(lista[i].Nombre, nombre, StringComparison.OrdinalIgnoreCase))
                {
                    return lista[i];
                }
            }

            return null;
        }
    }
}
