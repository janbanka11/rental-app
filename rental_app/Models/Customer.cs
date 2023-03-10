using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rental_app.Models
{
    public class Customer
    {

        public int CustomerId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Customer() { }
        public Customer(string username, string password, string name, string surname, DateTime dateOfBirth)
        {
            Username = username;
            Password = password;
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
        }
    }
}