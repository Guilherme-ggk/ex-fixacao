using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_estoque
{
    public interface IEstoque // a interface é a que faz o trabalho de abraçar todas as classes e guarda las em um só lugar
    {
        void Exibir();
        void AdicionarEntrada();
        void AdicionarSaida();


    }
}
