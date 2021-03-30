using System;
using System.IO;
using System.Collections.Generic;
using Liga_CSV_Converter.Entities;
using Liga_CSV_Converter.Services;

namespace Liga_CSV_Converter
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("1: Ler e formatar um arquivo | 2: Sair ");
            int opt = int.Parse(Console.ReadLine());
            while (opt == 1)
            {
                LigaServices servico = new LigaServices();
                List<string> fileList = servico.PopulateList();
                servico.GenerateFormatedList(fileList);
                Console.Write("1: Ler e formatar um arquivo | 2: Sair ");
                opt = int.Parse(Console.ReadLine());
            }

            System.Environment.Exit(0);
        }
    }

}
