using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Tarefa
    {
         public int userId;
         public int id;
         public string title;
         public bool completed;  
        
        public void Exibir()
        {
            Console.WriteLine("=============================================");
            Console.WriteLine("");
            Console.WriteLine("Tarefas e objetos");
            Console.WriteLine($"User ID: {userId}");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Titulo: {title}");
            Console.WriteLine($"Finalizou? {completed}");
            Console.WriteLine("");
            Console.WriteLine("=============================================");
        }
    }
}
