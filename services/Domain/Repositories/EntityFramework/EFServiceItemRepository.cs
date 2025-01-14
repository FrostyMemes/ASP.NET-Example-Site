﻿using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using services.Domain.Repositories.Abstract;

namespace services.Domain.Entities.Repositories.EntityFramework
{
    public class EFServiceItemRepository: IServiceItemsRepository
    {
        private readonly AppDbContext context;

        public EFServiceItemRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<ServiceItem> GetServiceItems()
        {
            return context.ServiceItems;
        }

        public ServiceItem GetServiceItemById(Guid id)
        {
            return context.ServiceItems.FirstOrDefault(x => x.Id == id);
        }
        
        public void SaveServiceItem(ServiceItem entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteServiceItem(Guid id)
        {
            context.ServiceItems.Remove(new ServiceItem() {Id = id});
            context.SaveChanges();
        }
    }
}