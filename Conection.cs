using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Produtos
{
    internal class Conection
    {
        static private string servidor = "localhost";
        static private string bancoDados = "productsystem";
        static private string usuario = "root";
        static private string senha = "#senha#";

        static public string Servidor = $"server = {servidor}; User Id = {usuario}; database = {bancoDados}; password = {senha}";
    }
}
