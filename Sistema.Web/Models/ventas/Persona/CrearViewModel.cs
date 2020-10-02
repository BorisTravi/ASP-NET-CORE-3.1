using System.ComponentModel.DataAnnotations;


namespace Sistema.Web.Models.ventas.Persona
{
    public class CrearViewModel
    {
        [Required]
        public string tipo_persona { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El nombre no debe tener menos 3 caracteres y mas de 50")]
        public string nombre { get; set; }
        public string tipo_documento { get; set; }
        public string num_documento { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }

    }
}
