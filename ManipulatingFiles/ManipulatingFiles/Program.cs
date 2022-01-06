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

            //var caminhoPathCombine = Path.Combine(caminho, "Pasta Teste 3", "SubPasta Teste 3");
            var caminhoDeletePathCombine = Path.Combine(caminho, "Pasta Teste 1");
            var caminhoParaCriarArquivo = Path.Combine(caminho, "arquivo-teste.txt");

            FileHelper helper = new FileHelper();

            helper.ListarDiretorios(caminho);
            helper.ListarArquivosDiretorios(caminho);
            //helper.CriarDiretorio(caminhoPathCombine);
            //Console.WriteLine("Criando diretorio: "+ caminhoPathCombine);
            //helper.ApagarDiretorio(caminhoDeletePathCombine, true);
            helper.CriarArquivoTexto(caminhoParaCriarArquivo, "Olá, teste de escrita");
        }
    }
}
