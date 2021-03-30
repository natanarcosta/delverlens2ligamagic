using Liga_CSV_Converter.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Liga_CSV_Converter.Services
{
    class LigaServices
    {
        public List<Card> list = new List<Card>();
        public List<string> PopulateList()
        {
            
            string[] allFiles = Directory.GetFiles(@"C:\Temp\DelverLensSource", "*.*", SearchOption.AllDirectories);
            List<string> fileList = new List<string>();

            for (int i = 0; i < allFiles.Length; i++)
            {
                fileList.Add(allFiles[i]);
                Console.WriteLine($"{i} : " + fileList[i]);
            }
            return fileList;
        }
        public void GenerateFormatedList(List<string> fileList)
        {
            Console.Write("Selecione o arquivo: ");
            int opt = int.Parse(Console.ReadLine());
            string path = fileList[opt];

            using StreamReader file = File.OpenText(path);
            string firstLine = file.ReadLine(); // Primeira linha, cabeçalho inútil
            while (!file.EndOfStream)
            {
                string[] temp = file.ReadLine().Replace("\"", "").Split(",");
                int quantity = int.Parse(temp[0]);
                string name = temp[1];
                string edCode = temp[2];
                list.Add(new Card(quantity, name, edCode));
            }

            foreach (Card card in list)
            {
                Console.WriteLine(card.ToString());
            }
        }
    }
}
