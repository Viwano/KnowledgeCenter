using KnowledgeCenter.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace KnowledgeCenter.Data
{
    public class KnowledgeCenterDbContext : DbContext
    {
        public DbSet<KnowledgeModel> KnowledgeModel { get; set; }
        public DbSet<KnowledgeDetailModel> KnowledgeDetailModel { get; set; }
    }
}
