using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    public class Item
    {
        private readonly int id;
        private string name;
        private string info;
        private decimal cost;
        public int ID
        {
            get { return id; }
        }

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 200)
                {
                    throw new ArgumentException("Название товара должно быть от 1 до 200 символов.");
                }
                name = value;
            }
        }

        public string Info
        {
            get => info;
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 1000)
                {
                    throw new ArgumentException("Описание товара должно быть до 1000 символов.");
                }
                info = value;
            }
        }

        public decimal Cost
        {
            get => cost;
            set
            {
                if (value < 0 || value > 100000)
                {
                    throw new ArgumentException("Стоимость товара должна быть в диапазоне от 0 до 100000.");
                }
                cost = value;
            }
        }

        public Item(string name, string info, decimal cost)
        {
            id = IdGenerator.GetNextId();
            Name = name;
            Info = info;
            Cost = cost;
        }
    }
}
