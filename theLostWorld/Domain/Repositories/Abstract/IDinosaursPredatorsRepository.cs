using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using theLostWorld.Domain.Entities;

namespace theLostWorld.Domain.Repositories.Abstract
{
    public interface IDinosaursPredatorsRepository
    {
        IQueryable<DinosaursPredators> GetDinosaurs();
        DinosaursPredators GetDinosaursById(Guid id);
        void SaveDinosaurs(DinosaursPredators entity);
        void DeleteDinosaurs(Guid id);
    }
}
