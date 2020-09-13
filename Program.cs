using System;

namespace nomecompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite seu primeiro nome:");
            string nome=Console.ReadLine();
            Console.Write("digite seu sobrenome:");
            string sobrenome=Console.ReadLine();
            Console.WriteLine("nome completo:"+nome+" "+sobrenome);
            Console.Write("nome do catálogo:"+sobrenome+", "+nome);
            
        }
    }
}
