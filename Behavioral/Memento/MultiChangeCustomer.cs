using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Memento
{
    class MultiChangeCustomer
    {
        private List<MultiChangeCustomerMomento> _momentos = new List<MultiChangeCustomerMomento>();

        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public MultiChangeCustomer(string name, string phone, string email)
        {
            this.Name = name;
            this.Phone = phone;
            this.Email = email;

            //save the og data to the mementos list
            SaveMomento();
        }

        public void SaveMomento()
        {
            var momento = new MultiChangeCustomerMomento(this.Name, this.Phone, this.Email);
            _momentos.Add(momento);
        }

        public void RevertToOriginal()
        {
            var originalMomento = _momentos.FirstOrDefault();

            if (originalMomento == null)
                return;

            LoadValuesFromMomento(originalMomento);

            if (_momentos.Count > 1)
                _momentos.RemoveRange(1, _momentos.Count - 1);
        }

        public void RevertToLast()
        {
            var lastMomento = _momentos.LastOrDefault();

            if (lastMomento == null)
                return;

            LoadValuesFromMomento(lastMomento);

            if (_momentos.Count > 1)// remove only if it's not the first
                _momentos.Remove(lastMomento);//.RemoveAt(_momentos.Count - 1);
        }

        private void LoadValuesFromMomento(MultiChangeCustomerMomento momento)
        {
            this.Name = momento.Name;
            this.Phone = momento.Phone;
            this.Email = momento.Email;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Phone: {Phone}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine();
        }

        private class MultiChangeCustomerMomento
        {
            public string Name { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }

            public MultiChangeCustomerMomento(string name, string phone, string email)
            {
                this.Name = name;
                this.Phone = phone;
                this.Email = email;
            }
        }
    }
}
