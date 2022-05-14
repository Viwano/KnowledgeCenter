using KnowledgeCenter.Data.Entities;
using System.Collections.Generic;

namespace KnowledgeCenter.Service.Interfaces
{
    internal interface IKnowledgeDetailCrudService
    {
        bool CreateKnowledge(KnowledgeDetailModel knowledgeModel);
        List<KnowledgeDetailModel> GetListOfKnowledges();
        bool UpdateKnowledge(KnowledgeDetailModel knowledgeModel);
        bool DeleteKnowledge(int knowledgeId);
    }
}
