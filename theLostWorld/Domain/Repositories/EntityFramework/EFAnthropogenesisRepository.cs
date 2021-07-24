using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using theLostWorld.Domain.Entities;
using theLostWorld.Domain.Repositories.Abstract;

namespace theLostWorld.Domain.Repositories.EntityFramework
{
    public class EFAnthropogenesisRepository : IAnthropogenesisRepository
    {
        private readonly AppDbContext context;
        //конструктор
        public EFAnthropogenesisRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Anthropogenesis> GetAnthropogenesis()
        {
            return context.Anthropogenesis;
        }

        public Anthropogenesis GetAnthropogenesisById(Guid id)
        {
            return context.Anthropogenesis.FirstOrDefault(x => x.Id == id);
        }

        public void SaveAnthropogenesis(Anthropogenesis entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteAnthropogenesis(Guid id)
        {
            context.Anthropogenesis.Remove(new Anthropogenesis() { Id = id });
            context.SaveChanges();
        }
    }
}
