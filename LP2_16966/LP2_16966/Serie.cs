using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    [Serializable]
    public class Serie
    {
        #region VARIAVEIS
        string tituloSerie, diretorSerie, generoSerie;
        float ratingSerie;
        int mesSerie, minutosEpisodio, anoSerie, idSerie, numeroEpisodios, numeroTemporadas;

        #endregion VARIAVEIS

        #region PROPRIEDADES
        public string TituloSerie { get => tituloSerie; set => tituloSerie = value; }
        public string DiretorSerie { get => diretorSerie; set => diretorSerie = value; }
        public string GeneroSerie { get => generoSerie; set => generoSerie = value; }

        public float RatingSerie
        {

            get { return ratingSerie; }

            set
            {

                if (ratingSerie > 0 && ratingSerie <= 10)
                {

                    ratingSerie = value;

                }

            }

        }
        public int MesSerie { get => mesSerie; set => mesSerie = value; }
        public int MinutosEpisodio { get => minutosEpisodio; set => minutosEpisodio = value; }
        public int AnoSerie { get => anoSerie; set => anoSerie = value; }
        public int IdSerie { get => idSerie; set => idSerie = value; }
        public int NumeroEpisodios { get => numeroEpisodios; set => numeroEpisodios = value; }
        public int NumeroTemporadas { get => numeroTemporadas; set => numeroTemporadas = value; }

        #endregion PROPRIEDADES
   
        #region CONSTRUTORES
        public Serie()
        {

            this.TituloSerie = default(string);
            this.DiretorSerie = default(string);
            this.GeneroSerie = default(string);
            this.RatingSerie = default(float);
            this.MesSerie = default(int);
            this.MinutosEpisodio = default(int);
            this.AnoSerie = default(int);
            this.NumeroEpisodios = default(int);
            this.NumeroTemporadas = default(int);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tituloserie"></param>
        /// <param name="diretorserie"></param>
        /// <param name="generoserie"></param>
        /// <param name="ratingserie"></param>
        /// <param name="messerie"></param>
        /// <param name="minutosEpisodio"></param>
        /// <param name="anoserie"></param>
        /// <param name="numeroepisodios"></param>
        /// <param name="numerotemporadas"></param>
        public Serie(string tituloserie, string diretorserie, string generoserie, float ratingserie, int messerie, int minutosEpisodio, int anoserie, int numeroepisodios, int numerotemporadas)
        {
            this.TituloSerie = tituloserie;
            this.DiretorSerie = diretorserie;
            this.GeneroSerie = generoserie;
            this.RatingSerie = ratingserie;
            this.MesSerie = messerie;
            this.MinutosEpisodio = minutosEpisodio;
            this.AnoSerie = anoserie;
            this.NumeroEpisodios = numeroepisodios;
            this.NumeroTemporadas = numerotemporadas;
           
        }
        #endregion CONSTRUTORES

        #region PROPRIEDADES

        #endregion PROPRIEDADES
    }

}
