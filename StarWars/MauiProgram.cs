using Microsoft.Extensions.Logging;
using StarWars.Service;

namespace StarWars
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            /// <summary>
            /// Registra el servicio Star Wars y la página principal en el contenedor de inyección de dependencia.
            /// </summary>
            builder.Services.AddSingleton<IStarWarsService, StarWarsService>();

            /// <summary>
            /// Registra la página principal con duración de vida transitoria en el contenedor de inyección de dependencia.
            /// </summary>
            builder.Services.AddTransient<MainPage>();


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
