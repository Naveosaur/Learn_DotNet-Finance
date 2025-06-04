using dotnet.Models;

namespace Learn_DotNet_Finance.Interfaces
{
    public interface ICommentRepository
    {
        Task<List<Comment>> GetAllAsync();
    }
}