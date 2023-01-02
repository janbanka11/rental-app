using rental_app.Models;
using rental_app.Data;

namespace rental_app
{
    
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        

        [STAThread]
        static void Main()
        {
            using RentalAppContext context = new RentalAppContext();

            Customer customer = new Customer()
            {
                Username = "Marcin",
                Password = "Dolowy",
                Name = "Mariusz",
                Surname = "Dolowy",
                DateOfBirth = DateTime.Now
            };
            context.Customers.Add(customer);
            customer.Surname = "banka";
            
            context.SaveChanges();

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}