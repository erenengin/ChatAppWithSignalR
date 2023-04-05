﻿using Chat.Data;


using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Chat.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext context;
        private bool disposed;
        public IGenericRepository<User> UserRepository { get; private set; }

        

        public UnitOfWork(AppDbContext context)
        {

            this.context = context;

            UserRepository = new GenericRepository<User>(context);
        }
        public void Complete()
        {
            context.SaveChanges();
        }



        protected virtual void Clean(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();

                }

            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Clean(true);
            GC.SuppressFinalize(this);
        }
    }
}
