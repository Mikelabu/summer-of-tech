﻿using System;

namespace NullWorries.Models
{
    public class Person
    {
        public Person(string givenName, string familyName, DateTime? dateOfBirth)
        {
            GivenName = givenName;
            FamilyName = familyName;

            if (dateOfBirth != null && dateOfBirth.Value < DateTime.Now)
            {
                DateOfBirth = dateOfBirth;
            }
        }

        public string GivenName { get; set; }

        public string FamilyName { get; set; }

        public DateTime? DateOfBirth { get; set; }
    }
}
