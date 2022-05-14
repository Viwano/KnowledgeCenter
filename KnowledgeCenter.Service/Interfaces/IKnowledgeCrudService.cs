using KnowledgeCenter.Data.Entities;
using System.Collections.Generic;

namespace KnowledgeCenter.Service.Interfaces
{
    public interface IKnowledgeCrudService
    {
        bool CreateKnowledge(KnowledgeModel knowledgeModel);
        List<KnowledgeModel> GetListOfKnowledges();
        bool UpdateKnowledge(KnowledgeModel knowledgeModel);
        bool DeleteKnowledge(int knowledgeId);
    }
}
