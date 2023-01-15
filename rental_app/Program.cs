using rental_app.Models;
using rental_app.Data;

namespace rental_app
{
    
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}