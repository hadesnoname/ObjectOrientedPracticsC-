using System;

namespace ObjectOrientedPractics.Model
{
    public class Customer
    {
        private readonly int id;
        private string fullname;
        private string address;

        public int Id => id;

        public string FullName
        {
            get => fullname;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > 200)
                    throw new ArgumentException("Полное имя не может быть пустым и должно содержать до 200 символов.");
                fullname = value;
            }
        }

        public string Address
        {
            get => address;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > 500)
                    throw new ArgumentException("Адрес не может быть пустым и должен содержать до 500 символов.");
                address = value;
            }
        }

        // Конструктор
        public Customer(string fullName, string address)
        {
            this.id = IdGenerator.GenerateId();  
            this.FullName = fullName;  
            this.Address = address;    
        }
    }
}

namespace ObjectOrientedPractics.Model
{
    public static class IdGenerator
    {
        private static int currentId = 0;

        public static int GenerateId()
        {
            return ++currentId;  
        }

        internal static int GetNextId()
        {
            throw new NotImplementedException();
        }
    }
}
