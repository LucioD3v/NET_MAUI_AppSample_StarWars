namespace StarWars.Models
{
    /// <summary>
    /// Representa una respuesta que contiene detalles sobre un personaje.
    /// </summary>
    public class PersonajesResponse
    {
        /// <summary>
        /// Obtiene o establece el nombre del personaje.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Obtiene o establece el género del personaje.
        /// </summary>
        public string gender { get; set; }
    }
}

