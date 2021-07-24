using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using theLostWorld.Domain.Entities;

namespace theLostWorld.Domain.Repositories.Abstract
{
    public interface IDinosaursFlyingRepository
    {
        IQueryable<DinosaursFlying> GetDinosaurs();
        DinosaursFlying GetDinosaursById(Guid id);
        void SaveDinosaurs(DinosaursFlying entity);
        void DeleteDinosaurs(Guid id);
    }
}
