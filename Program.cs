namespace MaksProject
{
    internal static class Program
    {
        public static int price { get; set; }
        public static int weight { get; set; }
        public static int count { get; set; }
        public static string name {  get; set; }
        public static string description { get; set; }
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}