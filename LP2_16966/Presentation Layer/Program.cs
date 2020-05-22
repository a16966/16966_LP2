using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BO;
using BR;

namespace Presentation_Layer
{
    class Program
    {
        static void Main(string[] args)
        {
            //criar objetos
            BO.Filme filme = new BO.Filme();
            BO.Utilizador utilizador = new BO.Utilizador();

            filme.Titulo = "Superhomem";
            utilizador.Username = "Joao95";
            ///main por terminar
            
        }
    }
}
