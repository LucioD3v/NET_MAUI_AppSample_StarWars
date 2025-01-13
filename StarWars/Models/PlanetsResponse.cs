namespace StarWars.Models
{
    /// <summary>
    /// Representa una respuesta que contiene detalles sobre un planeta.
    /// </summary>
    public class PlanetsResponse
    {
        /// <summary>
        /// Obtiene o establece el nombre del planeta.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Obtiene o establece la URL de la imagen del planeta.
        /// </summary>
        public string image { get; set; }
    }
}
