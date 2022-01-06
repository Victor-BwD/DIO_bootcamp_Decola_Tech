using ManipulatingFiles.Helper;
using System;
using System.Collections.Generic;
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
            var caminhoParaCriarArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
            var listaString = new List<string> { "Linha 1", "Linha 2", "Linha 3" };
            var listaStringContinuacao = new List<string> { "Linha 4", "Linha 5", "Linha 6" };
            var novoCaminhoParaCriarArquivo = Path.Combine(caminho, "Pasta Teste 2", "arquivo-teste-stream.txt");

            FileHelper helper = new FileHelper();

            //helper.ListarDiretorios(caminho);
            //helper.ListarArquivosDiretorios(caminho);
            //helper.CriarDiretorio(caminhoPathCombine);
            //Console.WriteLine("Criando diretorio: "+ caminhoPathCombine);
            //helper.ApagarDiretorio(caminhoDeletePathCombine, true);
            //helper.CriarArquivoTexto(caminhoParaCriarArquivo, "Olá, teste de escrita");
            //helper.CriarArquivoTextoStream(caminhoParaCriarArquivo, listaString);
            //helper.AdicionarTextoStream(caminhoParaCriarArquivo, listaStringContinuacao);
            //helper.LerArquivoStream(caminhoParaCriarArquivo);
            helper.MoverArquivo(caminhoParaCriarArquivo, novoCaminhoParaCriarArquivo);
        }
    }
}
