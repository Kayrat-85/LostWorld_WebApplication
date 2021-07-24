using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using theLostWorld.Domain.Entities;

namespace theLostWorld.Domain.Repositories.Abstract
{
    public interface IAnthropogenesisRepository
    {
        IQueryable<Anthropogenesis> GetAnthropogenesis();
        Anthropogenesis GetAnthropogenesisById(Guid id);
        void SaveAnthropogenesis(Anthropogenesis entity);
        void DeleteAnthropogenesis(Guid id);
    }
}
