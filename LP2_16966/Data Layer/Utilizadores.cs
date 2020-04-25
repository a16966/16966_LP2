using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BO;


namespace DL
{
    public class Utilizadores
    {
        #region ESTADO

        static List<Utilizador> listaUtilizadores;

        public Utilizadores()
        {
            listaUtilizadores = new List<Utilizador>();
            LoadData();
        }
        #endregion

        #region CONSTRUTORES
        /// <summary>
        /// Construtor para utilizadores
        /// </summary>
        static Utilizadores()
        {
            listaUtilizadores = new List<Utilizador>();

        }

        #region PROPRIEDADES
        /// <summary>
        /// Função que define ou entao devolve a l
        /// </summary>
        public static List<Utilizador> ListaUtilizadores
        {
            get { return listaUtilizadores; }
            set { listaUtilizadores = value; }
        }

        #endregion

        #endregion

        #region METODOS PUBLICOS UTILIZADOR

        /// <summary>
        /// Compara o Username recebido com os que existem na lista
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        static public bool ExisteUtilizador(string Name)
        {

            bool result = true;

            foreach (Utilizador u in listaUtilizadores) //Percorre a lista de utilizadores que vai ser recebida como parametro
            {

                if (Name == u.Username)
                {

                    result = true;
                    break; //Usado para parar de percorrer a lista de utilizadores

                }

                else //Break não é usado para continuar a percorrer a lista até ao fim
                {

                    result = false;

                }

            }

            return result;
        }

        static public bool RegistarUsuario(Utilizador u)
        {

            Utilizadores x = new Utilizadores();

            if (ExisteUtilizador(u.Username) == true)        //se existir já esse username então já n regista
                return false;

            if (listaUtilizadores.Count == 0)                    //se não existir nenhum esse passa a ser o idCliente 1
                u.IdCliente = 1;

            else
            {

                int aux = listaUtilizadores[listaUtilizadores.Count - 1].IdCliente;
                u.IdCliente = aux + 1; //Adiciona o valor de idCliente ao novo Utilizador , incrementando o do último por 1

            }

            listaUtilizadores.Add(u);
            return true;

        }

        #endregion METODOS PUBLICOS UTILIZADOR

        #region METODOS PRIVADOS UTILIZADOR
        private static void LoadData()
        {

        }
        #endregion METODOS PRIVADOS UTILIZADOR

    }

}