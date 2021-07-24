using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using theLostWorld.Domain.Entities;
using theLostWorld.Domain.Repositories.Abstract;


namespace theLostWorld.Domain.Repositories.EntityFramework
{
    public class EFDinosaursHerbivoresRepository : IDinosaursHerbivoresRepository
    {
        private readonly AppDbContext context;
        //конструктор
        public EFDinosaursHerbivoresRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<DinosaursHerbivores> GetDinosaurs()
        {
            return context.DinosaursHerbivore;
        }

        public DinosaursHerbivores GetDinosaursById(Guid id)
        {
            return context.DinosaursHerbivore.FirstOrDefault(x => x.Id == id);
        }

        public void SaveDinosaurs(DinosaursHerbivores entity)
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
            context.DinosaursHerbivore.Remove(new DinosaursHerbivores() { Id = id });
            context.SaveChanges();
        }
    }
}
