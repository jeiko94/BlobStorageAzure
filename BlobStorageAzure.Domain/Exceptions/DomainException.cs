namespace BlobStorageAzure.Domain.Exceptions
{
    public class DomainException : Exception
    {
        public DomainException(string nombre) : base(nombre) { }
    }
}
