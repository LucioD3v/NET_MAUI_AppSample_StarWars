namespace StarWars
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            /// <summary>
            /// Establece la página principal de la aplicación.
            /// </summary>
            //MainPage = new AppShell();
            MainPage = new AppShellCards();
        }
    }
}
