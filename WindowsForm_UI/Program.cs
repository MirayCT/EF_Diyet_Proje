using _04Project.ViewModel.Concrete;

namespace WindowsForm_UI
{
    internal static class Program
    {
        public static UserLoginInformationViewModel LoginedUserInformation = new UserLoginInformationViewModel();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new WelcomePage());
        }
    }
        
}