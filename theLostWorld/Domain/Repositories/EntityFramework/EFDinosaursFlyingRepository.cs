using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using theLostWorld.Domain.Entities;
using theLostWorld.Domain.Repositories.Abstract;

namespace theLostWorld.Domain.Repositories.EntityFramework
{
    public class EFDinosaursFlyingRepository : IDinosaursFlyingRepository
    {
        private readonly AppDbContext context;
        //конструктор
        public EFDinosaursFlyingRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<DinosaursFlying> GetDinosaurs()
        {
            return context.DinosaursFlyings;
        }

        public DinosaursFlying GetDinosaursById(Guid id)
        {
            return context.DinosaursFlyings.FirstOrDefault(x => x.Id == id);
        }

        public void SaveDinosaurs(DinosaursFlying entity)
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
            context.DinosaursFlyings.Remove(new DinosaursFlying() { Id = id });
            context.SaveChanges();
        }
    }
}
