namespace BlobStorageAzure.Domain.Entities
{
    public class Producto
    {
        public int Id { get; private set; }
        public string? Nombre { get; private set; }
        public string? Descripcion { get; private set; }
        public decimal Precio { get; private set; }
        public string? ImagenUrl { get; private set; }

        //Relación con categoria
        public int CategoriaId { get; private set; }
        public Categoria? Categoria { get; private set; }

        private Producto() { }

        public Producto(string nombre, string descripcion, decimal precio, int categoriaId)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre del prodcuto es obligatorio.");
            if (precio <= 0)
                throw new ArgumentException("El precio debe ser mayor a cero.");

            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
            CategoriaId = categoriaId;
        }

        public void AsignarImagen(string imagenUrl)
        {
            ImagenUrl = imagenUrl;
        }
    }
}
