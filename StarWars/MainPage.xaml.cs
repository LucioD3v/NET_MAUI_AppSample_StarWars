using StarWars.Service;

namespace StarWars
{
    /// <summary>
    /// Representa la página principal de la aplicación.
    /// </summary>
    public partial class MainPage : ContentPage
    {
        private readonly IStarWarsService _starWarsService;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="MainPage"/>.
        /// </summary>
        /// <param name="service">El servicio de Star Wars que se utilizará para la recuperación de datos.</param>
        public MainPage(IStarWarsService service)
        {
            InitializeComponent();
            _starWarsService = service;
        }

        /// <summary>
        /// Maneja el evento de clic para recuperar y mostrar datos.
        /// </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e">Los datos del evento</param>
        private async void OnDataClicked(object sender, EventArgs e)
        {
            loading.IsVisible = true;

            //var data = await _starWarsService.GetPersonajesAsync();
            var data = await _starWarsService.GetPlanetsAsync();

            listViewPlanets.ItemsSource = data;

            loading.IsVisible = false;
        }
    }
}
