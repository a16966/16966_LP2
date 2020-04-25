using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    [Serializable]
    public class Filme
    {
        #region VARIAVEIS
        string titulo, diretor, genero;
        float rating;
        int mesFilme, minutosFilme, anoFilme, idFilme;
        #endregion VARIAVEIS

        #region PROPRIEDADES
        public string Titulo { get => titulo; set => titulo = value; }
        public string Diretor { get => diretor; set => diretor = value; }
        public string Genero { get => genero; set => genero = value; }

        public float Rating
        {

            get { return rating; }

            set
            {

                if (rating > 0 && rating <= 10)
                {

                    rating = value;

                }

            }

        }
        public int MesFilme { get => mesFilme; set => mesFilme = value; }
        public int MinutosFilmme { get => minutosFilme; set => minutosFilme = value; }
        public int AnoFilme { get => anoFilme; set => anoFilme = value; }

        #endregion PROPRIEDADES

        #region CONSTRUTORES

        /// <summary>
        /// Construtor default da classe
        /// </summary>
        public Filme()
        {

            this.Titulo = default(string);
            this.Diretor = default(string);
            this.Genero = default(string);
            this.Rating = default(float);
            this.MesFilme = default(int);
            this.MinutosFilmme = default(int);
            this.AnoFilme = default(int);


        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="titulo"></param>
        /// <param name="diretor"></param>
        /// <param name="genero"></param>
        /// <param name="rating"></param>
        /// <param name="mesfilme"></param>
        /// <param name="minutosfilme"></param>
        /// <param name="anofilme"></param>
        public Filme(string titulo, string diretor, string genero, float rating, int mesfilme, int minutosfilme, int anofilme)
        {
            this.Titulo = titulo;
            this.Diretor = diretor;
            this.Genero = genero;
            this.Rating = rating;
            this.MesFilme = mesfilme;
            this.MinutosFilmme = minutosfilme;
            this.AnoFilme = anofilme;
        }
        #endregion CONSTRUTORES

        #region OPERADORES

        #endregion OPERADORES

    }
}
