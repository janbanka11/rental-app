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
            ApplicationConfiguration.Initialize();
            Application.Run(new InitialForm());
        }
    }
}