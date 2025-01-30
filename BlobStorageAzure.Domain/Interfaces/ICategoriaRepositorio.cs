using BlobStorageAzure.Domain.Entities;

namespace BlobStorageAzure.Domain.Interfaces
{
    public interface ICategoriaRepositorio
    {
        Task AddAsync(Categoria categoria);
        Task<Categoria> GetByIdAsync(int id);
        Task<IEnumerable<Categoria>> GetAllAsync();
    }
}
