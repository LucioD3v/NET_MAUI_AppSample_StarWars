using StarWars.Models;

namespace StarWars.Service
{
    /// <summary>
    /// Define métodos para interactuar con los datos de Star Wars.
    /// </summary>
    public interface IStarWarsService
    {
        /// <summary>
        /// Recupera asincrónicamente una lista de caracteres.
        /// </summary>
        /// <returns> Una tarea que representa la operación asincrónica. 
        public Task<List<PersonajesResponse>> GetPersonajesAsync();

        /// <summary>
        /// Recupera asincrónicamente una lista de planetas.
        /// </summary>
        /// <returns> Una tarea que representa la operación asincrónica.
        public Task<List<PlanetsResponse>> GetPlanetsAsync();

        /// <summary>
        /// Recupera asincrónicamente una lista de naves espaciales.
        /// </summary>
        /// <returns>Una tarea que representa la operación asincrónica.
        public Task<List<StarShipsResponse>> GetStarShipsAsync();

    }
}