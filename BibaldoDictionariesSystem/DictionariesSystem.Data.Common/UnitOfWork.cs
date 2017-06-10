﻿using DictionariesSystem.Contracts.Data;
using System;
using System.Data.Entity;

namespace DictionariesSystem.Data.Common
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext dbContext;

        public UnitOfWork(DbContext context)
        {
            this.dbContext = context;
        }

        public void SaveChanges()
        {
            this.dbContext.SaveChanges();
        }
    }
}