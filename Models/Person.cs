using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Lesson02_Startup.Models
{
    public class Person
    {
        private DateTime birthday;
        public DateTime birthDate {  get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string zip { get; set; }
        public string city { get; set; }
        public List<string> phoneNumbers { get; set; }

        public DateTime Birthday
        {
            set
            {
                if (age > 0 || age < 120)
                {
                    throw new Exception("Age not accepted");
                }
                else
                {
                    birthday = value;
                }
            }
            get { return birthday; }
        }

        public int age { 
            get
            {
                DateTime now = DateTime.Now;
                int age;

                age = now.Year - birthDate.Year;

                if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
                {
                    age--;
                }

                return age;
            }
        }



        public Person(string firstnavn, string lastnavn, string address, string zip, string city)
        {
            this.firstName = firstnavn;
            this.lastName = lastnavn;
            this.address = address;
            this.zip = zip;
            this.city = city;
            this.phoneNumbers = new List<string>();
        }

        public void addPhoneNumber(string phoneNumber)
        {
            this.phoneNumbers.Add(phoneNumber);
        }

        public List<string> getPhoneNumbers()
        {
            return phoneNumbers;
        }
        // code inside the get block of the Age
     
    }
}