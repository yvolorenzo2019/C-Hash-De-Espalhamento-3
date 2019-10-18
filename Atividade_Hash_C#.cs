using System.Text;
using System;
using System.Security.Cryptography;
using System.Text;

namespace md5hash
{
    class Program
    {
        static void Main(string[] args)
        {
            string professores;
            string result;
            professores = "Graciete e Jussimar são Legais <3";

            //Criando o Objeto com  a Hash de Espalhamento MD5
            MD5 md5hash = MD5.Create();

            //Guardando a variavel do Hash
            byte[] data = md5hash.ComputeHash(Encoding.UTF8.GetBytes(professores));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("x2"));
            }

            result = sb.ToString();

            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
