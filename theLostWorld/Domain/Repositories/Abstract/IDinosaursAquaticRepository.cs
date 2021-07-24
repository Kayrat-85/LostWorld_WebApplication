using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks;
using theLostWorld.Domain.Entities;

namespace theLostWorld.Domain.Repositories.Abstract
{
    public interface IDinosaursAquaticRepository
    {
        IQueryable<DinosaursAquatic> GetDinosaurs();
        DinosaursAquatic GetDinosaursById(Guid id);
        void SaveDinosaurs(DinosaursAquatic entity);
        void DeleteDinosaurs(Guid id);
    }
}
