using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BO;

namespace DL
{
    public class Series
    {
        #region ESTADO

        static List<Serie> listaSeries;

        public Series()
        {
            listaSeries = new List<Serie>();
            LoadData();
        }
        #endregion

        #region CONSTRUTORES
        /// <summary>
        /// Construtor para series
        /// </summary>
        static Series()
        {
            listaSeries = new List<Serie>();

        }

        #region PROPRIEDADES
        /// <summary>
        /// Função que define ou entao devolve a l
        /// </summary>
        public static List<Serie> ListaSeries
        {
            get { return listaSeries; }
            set { listaSeries = value; }
        }

        #endregion

        #endregion

        #region METODOS PUBLICOS SERIES
        /// <summary>
        /// Insere uma nova serie
        /// </summary>
        /// <param name="novaserie"></param>
        /// <returns></returns>
        public static bool InsererSerie (Serie novaserie)
        {
            try
            {
                listaSeries.Add(novaserie);
            }
            catch { return false; }

            return true;
        }
        #endregion

        #region METODOS PRIVADOS SERIES
        private static void LoadData()
        {

        }

        #endregion
    }
}
