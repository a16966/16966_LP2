using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BO;

namespace DL
{
    public class Filmes
    {
        #region ESTADO

        static List<Filme> listaFilmes;

        public Filmes()
        {
            listaFilmes = new List<Filme>();
            LoadData();
        }
        #endregion

        #region CONSTRUTORES
        /// <summary>
        /// Construtor para filmes
        /// </summary>
        static Filmes()
        {
            listaFilmes = new List<Filme>();

        }

        #region PROPRIEDADES
        /// <summary>
        /// Função que define ou entao devolve a l
        /// </summary>
        public static List<Filme> ListaFilmes
        {
            get { return listaFilmes; }
            set { listaFilmes = value; }
        }

        #endregion

        #endregion

        #region METODOS PUBLICOS FILMES
        /// <summary>
        /// Insere uma nova serie
        /// </summary>
        /// <param name="novaserie"></param>
        /// <returns></returns>
        public static bool InsereFilme(Filme novofilme)
        {
            try
            {
                listaFilmes.Add(novofilme);
            }
            catch { return false; }

            return true;
        }
        #endregion

        #region METODOS PRIVADOS FILMES
        private static void LoadData()
        {

        }

        #endregion
    }
}

