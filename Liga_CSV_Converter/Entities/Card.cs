using System;
using System.Collections.Generic;
using System.Text;

namespace Liga_CSV_Converter.Entities
{
    class Card
    {
        public int Quantity { get; set; }
        public string Name { get; set; }
        public string EditionCode { get; set; }
        public string EditionName { get; set; }
        public bool IsFoil { get; set; }
        public double Price { get; set; }

        public Card()
        {

        }
        public Card(int quantity, string name, string editionCode)
        {
            Quantity = quantity;
            Name = name;
            EditionCode = editionCode;
        }

        public Card(int quantity, string name, string editionCode, string editionName, bool isFoil, double price) : this(quantity, name, editionCode)
        {
            EditionName = editionName;
            IsFoil = isFoil;
            Price = price;
        }
        public override string ToString()
        {
            return Quantity + " " + Name + " " + EditionCode;
        }
    }
}
