using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using theLostWorld.Domain.Entities;
using theLostWorld.Domain.Repositories.Abstract;

namespace theLostWorld.Domain.Repositories.EntityFramework
{
    public class EFMammalsHerbivoresRepository : IMammalsHerbivoresRepository
    {
        private readonly AppDbContext context;
        //конструктор
        public EFMammalsHerbivoresRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<MammalsHerbivores> GetMammals()
        {
            return context.MammalsHerbivores;
        }

        public MammalsHerbivores GetMammalsById(Guid id)
        {
            return context.MammalsHerbivores.FirstOrDefault(x => x.Id == id);
        }

        public void SaveMammals(MammalsHerbivores entity)
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
            context.MammalsHerbivores.Remove(new MammalsHerbivores() { Id = id });
            context.SaveChanges();
        }
    }
}
