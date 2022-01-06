using System;
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
        // lista todas as pastas
        public void ListarDiretorios(string caminho)
        {
            var retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);

            foreach (var retorno in retornoCaminho)
            {
                Console.WriteLine(retorno);
            }
        }

        // lista as pastas e os arquivos dentro delas
        public void ListarArquivosDiretorios(string caminho)
        {
            var retornoArquivos = Directory.GetFiles(caminho, "*", SearchOption.AllDirectories);

            foreach (var retorno in retornoArquivos)
            {
                Console.WriteLine(retorno);
            }
        }

        // cria a pasta
        public void CriarDiretorio(string caminho)
        {
            var retorno = Directory.CreateDirectory(caminho);
            Console.WriteLine(retorno.FullName);
        }

        // deleta a pasta e todos os arquivos
        public void ApagarDiretorio(string caminho, bool apagarTodosOsArquivos)
        {
            Directory.Delete(caminho, apagarTodosOsArquivos);
        }

        // cria um arquivo de texto (recomendado para arquivos pequenos e médios)
        public void CriarArquivoTexto(string caminho, string conteudo)
        {
            if (!File.Exists(caminho)) // se o item não existir, crie
            {
                File.WriteAllText(caminho, conteudo);
            }
            
        }

        // cria arquivo de texto por partes (recomendado para arquivos grandes)
        public void CriarArquivoTextoStream(string caminho, List<string> conteudo)
        {
            

            using (var stream = File.CreateText(caminho)) {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
            }
            
        }

        // Adiciona linha em arquivo de texto
        public void AdicionarTexto(string caminho, string conteudo)
        {
            File.AppendAllText(caminho, conteudo);
        }

        // adiciona linhas em arquivos de texto por stream
        public void AdicionarTextoStream(string caminho, List<string> conteudo)
        {


            using (var stream = File.AppendText(caminho))
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
            }

        }

        // ler arquivo sem stream, carregando todo o arquivo de uma vez
        public void LerArquivo(string caminho)
        {
           var conteudo = File.ReadAllLines(caminho);

            foreach (var linha in conteudo)
            {
                Console.WriteLine(linha);
            }
        }

        // ler atraves de stream, linha por linha inclemental
        public void LerArquivoStream(string caminho)
        {
            string linha = string.Empty;

            using(var stream = File.OpenText(caminho))
            {
                while((linha = stream.ReadLine()) != null)
                {
                    Console.WriteLine(linha);
                }
            }
        }
    }
}
