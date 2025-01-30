namespace BlobStorageAzure.Domain.Entities
{
    public class Categoria
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public List<Producto> Productos { get; private set; } = new();

        private Categoria() { }

        public Categoria(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombe de la categoria es obligatorio.");

            Nombre = nombre;
        }
    }
}
