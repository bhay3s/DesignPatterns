using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Memento
{
    public class SimpleCustomer
    {
        private SimpleCustomerMomento _momento;
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public SimpleCustomer(string name, string phone, string email)
        {
            this.Name = name;
            this.Phone = phone;
            this.Email = email;

            _momento = new SimpleCustomerMomento(name, phone, email); // save original values
        }

        public void RevertToOriginalValues()
        {
            if (_momento == null)
                return;

            this.Name = _momento.Name;
            this.Phone = _momento.Phone;
            this.Email = _momento.Email;
        }

        private class SimpleCustomerMomento
        {
            public string Name { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }

            public SimpleCustomerMomento(string name, string phone, string email)
            {
                this.Name = name;
                this.Phone = phone;
                this.Email = email;

            }
        }
    }
}
