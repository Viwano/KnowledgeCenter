namespace KnowledgeCenter.Data.Entities
{
    public class KnowledgeDetailModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int CreatorUserId { get; set; }
        public string Description { get; set; }
    }
}
