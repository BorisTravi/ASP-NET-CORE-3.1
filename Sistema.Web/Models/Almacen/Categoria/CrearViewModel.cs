using System.ComponentModel.DataAnnotations;


namespace Sistema.Web.Models.Almacen.Categoria
{
    public class CrearViewModel
    {
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre no debe tener mas de 50 caracteres y menos de 3")]
        public string nombre { get; set; }

        [StringLength(256)]
        public string Descripcion { get; set; }
    }

}
