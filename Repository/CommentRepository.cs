using dotnet.Data;
using dotnet.Models;
using Learn_DotNet_Finance.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Learn_DotNet_Finance.Repository
{
    public class CommentRepository : ICommentRepository
    {


        private readonly ApplicationDBContext _context;

        public CommentRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<List<Comment>> GetAllAsync()
        {
            var comments = await _context.Comment.ToListAsync();
            return comments;
        }

    }
}