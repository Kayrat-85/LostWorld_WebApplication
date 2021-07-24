using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using theLostWorld.Domain.Entities;
using theLostWorld.Domain.Repositories.Abstract;

namespace theLostWorld.Domain.Repositories.EntityFramework
{
    public class EFMammalsPredatorsRepository : IMammalsPredatorsRepository
    {

        private readonly AppDbContext context;
        //конструктор
        public EFMammalsPredatorsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<MammalsPredators> GetMammals()
        {
            return context.MammalsPredators;
        }

        public MammalsPredators GetMammalsById(Guid id)
        {
            return context.MammalsPredators.FirstOrDefault(x => x.Id == id);
        }

        public void SaveMammals(MammalsPredators entity)
        {
            if (entity.Id == default)
            {
                context.Entry(entity).State = EntityState.Added;
            }
            else context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteMammals(Guid id)
        {
            context.MammalsPredators.Remove(new MammalsPredators() { Id = id });
            context.SaveChanges();
        }
    }
}
