using System;
using Bogus;

namespace example5
{
    internal class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

        private static readonly Faker<Customer> faker;

        static Customer()
        {
            var randomizer = new Randomizer();

            faker = new Faker<Customer>()
                .RuleFor(customer => customer.FirstName, faker => faker.Name.FirstName())
                .RuleFor(customer => customer.LastName, faker => faker.Name.LastName())
                .RuleFor(customer => customer.Phone, _ => randomizer.Replace("###-##-####"));
        }

        internal static Customer Generate()
        {
            return faker.Generate();
        }
    }
}