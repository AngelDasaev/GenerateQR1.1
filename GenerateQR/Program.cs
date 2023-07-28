using Presentation;

namespace GenerateQR
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new GenerateQR());
            //Application.Run(new MoldeoQueries());
            Application.Run(new LoginForm());
            //Application.Run(new RegistroUsuarios());
            //Application.Run(new BienvenidaForm());
            //Application.Run(new test());
            //Application.Run(new PinturasQueries());

        }
    }
}