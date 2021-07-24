using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using theLostWorld.Domain.Entities;

namespace theLostWorld.Domain.Repositories.Abstract
{
    public interface IMammalsHerbivoresRepository
    {
        IQueryable<MammalsHerbivores> GetMammals();
        MammalsHerbivores GetMammalsById(Guid id);
        void SaveMammals(MammalsHerbivores entity);
        void DeleteMammals(Guid id);
    }
}
