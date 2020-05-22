using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BO;
using DL;


namespace BR
{
    class SeriesR
    {
        /// <summary>
        /// função que insere um nova serie, caso exista dá return false
        /// </summary>
        /// <param name="novaSerie"></param>
        /// <returns></returns>
        public static bool InsereSerie(Serie novaSerie)
        {
            //verifica se o determinado filme já existe
            if (Series.ExisteSerie(novaSerie))
                return false;

            return Series.InsereSerie(novaSerie);
        }

        /// <summary>
        /// Função que mostrará os dados da Serie
        /// </summary>
        /// <param name="nomeserie"></param>
        /// <returns></returns>
        public static bool MostraDadosSeries(string nomeserie)
        {
            return Series.MostraDadosSeries(nomeserie);
        }
        /// <summary>
        /// A função que remove a serie
        /// </summary>
        /// <param name="IDFilme"></param>
        /// <returns></returns>
        public static bool RemoveSerie(int IDSerie)
        {
            return Series.RemoveSerie(IDSerie);
        }

        /// <summary>
        /// Adicionar Favoritos
        /// </summary>
        /// <param name="novoFilme"></param>
        /// <returns></returns>
        public static List<Serie> RegistaFavoritoSerie(Serie novaSerie)
        {
            return Series.RegistaFavoritoSerie(novaSerie);
        }
    }
}
