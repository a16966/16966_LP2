using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BO;
using DL;

namespace BR
{
    class UtilizadoresR
    {
        /// <summary>
        /// Insere o utilizador se não existir
        /// </summary>
        /// <param name="novoUtilizador"></param>
        /// <returns></returns>
        public static bool InsereUtilizador(Utilizador novoUtilizador)
        {
            //verifica se o determinado filme já existe
            if (Utilizadores.ExisteUtilizador(novoUtilizador))
                return false;

            return Utilizadores.InsereUtilizador(novoUtilizador);
        }
        /// <summary>
        /// função que muda as informações do cliente
        /// </summary>
        /// <param name="u"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        static public bool ChangeUserData(Utilizador u, string username, string password)
        {
            return (Utilizadores.ChangeUserData(u, username, password));
        }
    }
}
