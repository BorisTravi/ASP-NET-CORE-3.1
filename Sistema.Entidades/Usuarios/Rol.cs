using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Entidades.Usuarios
{
    public class Rol
    { 
        public int idrol { get; set; }
        [Required]
        [StringLength(30, MinimumLength =3 , ErrorMessage ="El nombre no debe contener de mas de 30 caracteres y menos de 3.")]
        public string nombre{ get; set; }
        [StringLength(256)]
        public string Descripcion { get; set; }
        public bool condicion { get; set; }

        public ICollection<Usuario> Usuarios { get; set; }
    }
}
