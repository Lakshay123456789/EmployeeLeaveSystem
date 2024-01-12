namespace BusinessLogicLayer.FileService
{
    public interface ICSVService
    {
        Task<IEnumerable<T>> ReadCSV<T>(Stream file);
    }
}