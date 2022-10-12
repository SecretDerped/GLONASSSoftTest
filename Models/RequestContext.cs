﻿using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public class RequestContext : DbContext
    {
        public RequestContext(DbContextOptions<RequestContext> options)
            : base(options)
        {
        }
        public DbSet<RequestData> Requests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RequestData>().OwnsOne(r => r.UserData);

            base.OnModelCreating(modelBuilder);
        }

        public async Task AddAsyncFake(RequestData request)
        {
            await Task.Run(() => Requests.Add(request)).ContinueWith((r) => SaveChanges());
        }

        public async Task<RequestData> GetAsyncFake(string requestGuid)
        {
            return await Task.Run(() => Requests.Where(r => r.QueryId == requestGuid).FirstOrDefault());
        }
    }
}
