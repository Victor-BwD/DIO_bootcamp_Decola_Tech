using ManipulatingFiles.Helper;
using System;

namespace ManipulatingFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "F:\\TrabalhandoComArquivos";

            FileHelper helper = new FileHelper();

            helper.ListarDiretorios(caminho);
            helper.ListarArquivosDiretorios(caminho);
        }
    }
}
