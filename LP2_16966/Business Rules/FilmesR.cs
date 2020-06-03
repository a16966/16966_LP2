using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BO;
using DL;

namespace BR
{
    public class FilmesR
    {
        /// <summary>
        /// função que insere um novo filme, caso exista dá return false
        /// </summary>
        /// <param name="novoFilme"></param>
        /// <returns></returns>
        public static bool InsereFilme(Filme novoFilme)
        {
            //verifica se o determinado filme já existe
            if (Filmes.ExisteFilme(novoFilme))
                return false;

            return Filmes.InsereFilme(novoFilme);
        }

        /// <summary>
        /// Função que mostrará os dados do filme
        /// </summary>
        /// <param name="nomefilme"></param>
        /// <returns></returns>
        public static bool MostraDadosFilme(string nomefilme)
        {
            return Filmes.MostraDadosFilme(nomefilme);
        }
        /// <summary>
        /// A função que remove o filme
        /// </summary>
        /// <param name="IDFilme"></param>
        /// <returns></returns>
        public static bool RemoveFilme(int IDFilme)
        {
            return Filmes.RemoveFilme(IDFilme);
        }
        /// <summary>
        /// Adicionar Favoritos
        /// </summary>
        /// <param name="novoFilme"></param>
        /// <returns></returns>
        public static List<Filme> RegistaFavoritoFilme(Filme novoFilme)
        {
            return Filmes.RegistaFavoritoFilme(novoFilme);
        }
    }
}
