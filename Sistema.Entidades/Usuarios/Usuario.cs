using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sistema.Entidades.Usuarios
{
    public class Usuario
    {
        [Key]
        public int idusuario { get; set; }
        [ForeignKey("rol")]
        [Required]
        public int idrol { get; set; }
        [Required]
        [StringLength(100, MinimumLength =3, ErrorMessage ="El nombre no debe tener mas de 100 caratecteres y menos de 3 caracteres.")]
        public string nombre { get; set; }
        public string tipo_documento { get; set; }
        public string num_documento { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public byte[] password_hash { get; set; }
        [Required]
        public byte[] password_salt { get; set; }
        public bool condicion { get; set; }

        public Rol rol { get; set; }
    }   
}
