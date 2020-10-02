
using Microsoft.EntityFrameworkCore;
using Sistema.Entidades.Almacen;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Sistema.Datos.Mappin.Almacen
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("categoria")
                .HasKey(c => c.idcategoria);
        }
    }
}
