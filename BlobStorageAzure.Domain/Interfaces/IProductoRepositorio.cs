using BlobStorageAzure.Domain.Entities;

namespace BlobStorageAzure.Domain.Interfaces
{
    public interface IProductoRepositorio
    {
        Task AddAsync(Producto producto);
        Task UpdateAsync(Producto producto);
        Task<Producto> GetByIdAsync(int id);
        Task<IEnumerable<Producto>> GetAllAsync();
        Task<IEnumerable<Producto>> GetByCategoriaIdAsync(int categoriaId);
    }
}
