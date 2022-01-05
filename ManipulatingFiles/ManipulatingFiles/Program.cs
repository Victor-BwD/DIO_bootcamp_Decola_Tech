using ManipulatingFiles.Helper;
using System;
using System.IO;

namespace ManipulatingFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "F:\\TrabalhandoComArquivos";

            var caminhoPathCombine = Path.Combine(caminho, "Pasta Teste 3", "SubPasta Teste 3");

            FileHelper helper = new FileHelper();

            helper.ListarDiretorios(caminho);
            helper.ListarArquivosDiretorios(caminho);
            helper.CriarDiretorio(caminhoPathCombine);
            Console.WriteLine("Criando diretorio: "+ caminhoPathCombine);
        }
    }
}
