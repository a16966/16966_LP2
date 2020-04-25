using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{

    [Serializable]
    public class Utilizador
    {
        #region VARIAVEIS
        int idade, idCliente;
        string username, password;
        #endregion VARIAVEIS

        #region PROPRIEDADES

        public string Username { get => username; set => username = value; }

        public string Password { get => password; set => password = value; }

        public int Idade
        {

            get { return idade; }

            set
            {

                if (idade > 0)
                {

                    idade = value;

                }

            }
        }
        public int IdCliente { get => idCliente; set => idCliente = value; }

        #endregion PROPRIEADADES

        #region CONSTRUTORES
        /// <summary>
        /// Construtor default da classe
        /// </summary>
        public Utilizador()
        {
            this.Username = default(string);
            this.Password = default(string);
            this.Idade = default(int);

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="idade"></param>
        public Utilizador(string username, string password, int idade)
        {

            this.Username = username;
            this.Password = password;
            this.Idade = idade;

        }
        #endregion CONSTRUTORES
    }


}

