﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ManipulatingFiles.Helper
{
    // * é um filtro, quer dizer que vai trazer todos
    // Se quiser trazer algo especifico usar "*.txt" por exemplo
    // Se quiser trazer por algum nome usar "*2.txt", por exemplo, assim ele pegará todos os arquivos com 2 no final
    // Se quiser buscar qualquer formato mas com algum nome especifico usar "*2*", por exemplo

    class FileHelper
    {
        public void ListarDiretorios(string caminho)
        {
            var retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);

            foreach (var retorno in retornoCaminho)
            {
                Console.WriteLine(retorno);
            }
        }

        public void ListarArquivosDiretorios(string caminho)
        {
            var retornoArquivos = Directory.GetFiles(caminho, "*", SearchOption.AllDirectories);

            foreach (var retorno in retornoArquivos)
            {
                Console.WriteLine(retorno);
            }
        }

        public void CriarDiretorio(string caminho)
        {
            var retorno = Directory.CreateDirectory(caminho);
            Console.WriteLine(retorno.FullName);
        }

        public void ApagarDiretorio(string caminho, bool apagarTodosOsArquivos)
        {
            Directory.Delete(caminho, apagarTodosOsArquivos);
        }

        public void CriarArquivoTexto(string caminho, string conteudo)
        {
            if (!File.Exists(caminho)) // se o item não existir, crie
            {
                File.WriteAllText(caminho, conteudo);
            }
            
        }

        public void CriarArquivoTextoStream(string caminho, List<string> conteudo)
        {
            

            using (var stream = File.CreateText(caminho)) {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
            }
            
        }
    }
}
