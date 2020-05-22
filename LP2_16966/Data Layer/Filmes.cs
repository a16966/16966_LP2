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
        /// Insere uma novo filme
        /// </summary>
        /// <param name="novoFilme"></param>
        /// <returns></returns>
        public static bool InsereFilme(Filme novoFilme)
        {
            bool x = false;

            try
            {
                listaFilmes.Add(novoFilme);

                x = true;
            }
            catch (Exception f)
            {
                throw new Exception("Não foi possível adicionar", f);

            }

            return x;
        }
        /// <summary>
        /// Função que vê se esse filme já existe na database
        /// </summary>
        /// <param name="filme"></param>
        /// <returns></returns>
        public static bool ExisteFilme(Filme filme)
        {
            foreach (Filme f in listaFilmes)
            {

                if (f == filme)
                return true;
            }

            return false;
        }
        /// <summary>
        /// Mostra as informações que pretendemos de determinado filme
        /// </summary>
        /// <param name="nomefilme"></param>
        /// <returns></returns>
        public static bool MostraDadosFilme(string nomefilme)
        {
            foreach (Filme f in listaFilmes)
            {
                if (f.Titulo == nomefilme)
                    return true;
                Console.WriteLine("Dados do filme: Titulo{0}  Genero{1}  Data:{2}/{3}  ID{4}  Diretor{5}  Minutos do Filme{6} Rating{7} \n\n", f.Titulo, f.Genero, f.AnoFilme, f.MesFilme, f.IdFilme, f.Diretor, f.MinutosFilmme, f.Rating);
            }
            return false;
        }
        /// <summary>
        /// função que permitirá um filme
        /// </summary>
        /// <param name="IDFilme"></param>
        /// <returns></returns>
        public static bool RemoveFilme(int IDFilme)
        {
            bool result = false;
            
                foreach (Filme f in listaFilmes)
                {
                    if (f.IdFilme == IDFilme)
                    {
                    Console.WriteLine("Pretende eliminar o filme?\n\n");
                    Console.WriteLine("\t1-Sim;\n");
                    Console.WriteLine("\t2-Nao;\n");
                    int option = Int32.Parse(Console.ReadLine());
                    switch (option)
                    {
                        default:
                            Console.WriteLine("\nIntroduza ou a tecla 1 ou 2 apenas!");
                            Console.ReadKey();
                            break;
                        case 1:
                            result = true;
                            Console.WriteLine("\nFilme removido com sucesso");
                            listaFilmes.Remove(f);
                            break;
                        case 2:
                            break;
                    }
                    break; 
                    }
                }
            return result;
        }

        /// <summary>
        /// Função que insere filme nos favoritos e mostra no fim quantos estão nos favoritos
        /// </summary>
        /// <param name="novoFilme"></param>
        /// <returns></returns>
        public static List<Filme> RegistaFavoritoFilme(Filme novoFilme)
        {
            List<Filme> conjuntoFilmesFavoritos = new List<Filme>();

            foreach (Filme f in listaFilmes)
            {
                if (f == novoFilme)
                {
                    Console.WriteLine("Pretende adicionar o filme aos favoritos?\n\n");
                    Console.WriteLine("\t1-Sim;\n");
                    Console.WriteLine("\t2-Nao;\n");
                    int option = Int32.Parse(Console.ReadLine());
                    switch (option)
                    {
                        default:
                            Console.WriteLine("\nIntroduza ou a tecla 1 ou 2 apenas!");
                            Console.ReadKey();
                            break;
                        case 1:

                            Console.WriteLine("\nFilme adicionado com sucesso");
                            conjuntoFilmesFavoritos.Add(novoFilme);
                            break;
                        case 2:
                            break;
                    }
                    break;
                }
            }
            return conjuntoFilmesFavoritos;
        }

        #endregion

        #region METODOS PRIVADOS FILMES
        /// <summary>
        /// Carrega ficheiro que terá a informação em binário
        /// </summary>
        private static void LoadData()
        {
            string dirFicheiro;
            Stream stream;

            dirFicheiro = Environment.CurrentDirectory + "//filmes.dat";


            // Se o ficheiro alvo não existir, ignorar o resto das iterações do presente método
            if (File.Exists(dirFicheiro) == false) return;

            // Inicializar stream de leitura através da abertura do ficheiro onde os dados estão guardados  
            stream = File.Open(dirFicheiro, FileMode.Open);

            var serializador = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();


            // Carregar binário para lista
            listaFilmes = (List<Filme>)serializador.Deserialize(stream);
            stream.Close();
        }
        /// <summary>
        /// Escreve e guarda as informações do ficheiro
        /// </summary>
        private static void WriteData()
        {
            // Declaração de variáveis locais
            string dirFicheiro;
            Stream stream;

            // Definir diretorio onde o ficheiro sera manipulado
            dirFicheiro = Environment.CurrentDirectory + "//filmes.dat";


            // Inicializar stream de escrita
            stream = File.Create(dirFicheiro);

            var serializador = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

            // Serializar objecto
            serializador.Serialize(stream, listaFilmes);

            stream.Close();
        }

        #endregion
    }
}

