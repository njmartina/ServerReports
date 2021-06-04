using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerReports
{
    class Server
    {
        // Servers information includes first and last name and date of birth
        public string FirstName { get; }
        public string LastName { get; }
        public DateTime DateOfBirth { get; }

        //Constructor
        public Server(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        //Calculates the age of the server
        public double CalculateAge()
        {
            return Convert.ToInt32((DateTime.Now - DateOfBirth).TotalDays / 365);
        }

        //ToString override to print basic information
        public override string ToString()
        {
            return $"This server's name is {FirstName} {LastName} and they are {CalculateAge()} years old.";
        }
    }
}
