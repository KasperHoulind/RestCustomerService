using System;
using System.Collections.Generic;
using System.Text;

namespace ModelClassCustomer.model
{
    public class Customer
    {
        public int _Id;
        public string _FirstName;
        public string _LastName;
        public int _YearOfreg;

        public int Id
        {
            get => _Id;
            set => _Id = value;
        }

        public string FirstName
        {
            get => _FirstName;
            set => _FirstName = value;
        }

        public string LastName
        {
            get => _LastName;
            set => _LastName = value;
        }

        public int YearOfreg
        {
            get => _YearOfreg;
            set => _YearOfreg = value;
        }

        public Customer(int id, string firstName, string lastName, int yearOfreg)
        {
            _Id = id;
            _FirstName = firstName;
            _LastName = lastName;
            _YearOfreg = yearOfreg;
        }

        public Customer()
        {

        }
    }
}
