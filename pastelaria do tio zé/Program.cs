using System.Globalization;
namespace pastelaria_do_tio_zé
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string LangRegion = ""; // en-US, es, pt-BR, etc
                                    //ajusta o idioma/região
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(LangRegion);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(LangRegion);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new ZePasteis());
        }
    }
}