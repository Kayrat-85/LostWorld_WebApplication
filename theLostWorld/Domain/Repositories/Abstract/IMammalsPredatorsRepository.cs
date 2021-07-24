using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using theLostWorld.Domain.Entities;

namespace theLostWorld.Domain.Repositories.Abstract
{
    public interface IMammalsPredatorsRepository
    {
        IQueryable<MammalsPredators> GetMammals();
        MammalsPredators GetMammalsById(Guid id);
        void SaveMammals(MammalsPredators entity);
        void DeleteMammals(Guid id);
    }
}
