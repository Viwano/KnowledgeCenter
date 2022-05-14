using System.Collections.Generic;

namespace KnowledgeCenter.Data.Entities
{
    public class KnowledgeModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public RequestKind RequestKind { get; set; }
        public RequestType RequestType { get; set; }
        public DomainScope DomainScope { get; set; }
        public string Module { get; set; }
        public int EstimateTime { get; set; }
        public string Tag { get; set; }
        public string Description { get; set; }
        public ICollection<KnowledgeDetailModel> KnowledgeDetailModels { get; set; }
    }

    public enum RequestKind
    {
        Education,
        CreateForm,
        EditForm,
        AddUser,
        UserAccess,
        SystemIssue,
        RenewContract
    }

    public enum RequestType
    {
        Request,
        Problem,
        Rule
    }

    public enum DomainScope
    {
        Rayvarz,
        Rahkaran,
        Portal
    }
}
