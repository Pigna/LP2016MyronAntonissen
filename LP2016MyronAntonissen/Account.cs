using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2016MyronAntonissen
{
    public abstract class Account
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string  Email { get; set; }
        public Account(int id, string naam, string email)
        {
            Id = id;
            Naam = naam;
            Email = email;
        }

    }
}
