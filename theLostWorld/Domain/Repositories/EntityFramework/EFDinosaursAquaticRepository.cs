using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using theLostWorld.Domain.Entities;
using theLostWorld.Domain.Repositories.Abstract;

namespace theLostWorld.Domain.Repositories.EntityFramework
{
    public class EFDinosaursAquaticRepository : IDinosaursAquaticRepository
    {
        private readonly AppDbContext context;
        //конструктор
        public EFDinosaursAquaticRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<DinosaursAquatic> GetDinosaurs()
        {
            return context.DinosaursAquatics;
        }

        public DinosaursAquatic GetDinosaursById(Guid id)
        {
            return context.DinosaursAquatics.FirstOrDefault(x => x.Id == id);
        }

        public void SaveDinosaurs(DinosaursAquatic entity)
        {
            if (entity.Id == default)
            {
                context.Entry(entity).State = EntityState.Added;
            }
            else context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteDinosaurs(Guid id)
        {
            context.DinosaursAquatics.Remove(new DinosaursAquatic() { Id = id });
            context.SaveChanges();
        }
    }
}
