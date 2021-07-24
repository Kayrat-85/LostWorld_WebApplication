using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using theLostWorld.Domain.Entities;
using theLostWorld.Domain.Repositories.Abstract;

namespace theLostWorld.Domain.Repositories.EntityFramework
{
    public class EFDinosaursPredatorsRepository : IDinosaursPredatorsRepository
    {
        private readonly AppDbContext context;
        //конструктор
        public EFDinosaursPredatorsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<DinosaursPredators> GetDinosaurs()
        {
            return context.DinosaursPredator;
        }

        public DinosaursPredators GetDinosaursById(Guid id)
        {
            return context.DinosaursPredator.FirstOrDefault(x => x.Id == id);
        }

        public void SaveDinosaurs(DinosaursPredators entity)
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
            context.DinosaursPredator.Remove(new DinosaursPredators() { Id = id });
            context.SaveChanges();
        }
    }
}
