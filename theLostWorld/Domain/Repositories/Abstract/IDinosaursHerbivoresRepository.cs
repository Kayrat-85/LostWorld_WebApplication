using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using theLostWorld.Domain.Entities;

namespace theLostWorld.Domain.Repositories.Abstract
{
    public interface IDinosaursHerbivoresRepository
    {
        IQueryable<DinosaursHerbivores> GetDinosaurs();
        DinosaursHerbivores GetDinosaursById(Guid id);
        void SaveDinosaurs(DinosaursHerbivores entity);
        void DeleteDinosaurs(Guid id);
    }
}
