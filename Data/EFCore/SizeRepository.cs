﻿using ShoeStore.Data.Repositories;
using ShoeStore.Models;

namespace ShoeStore.Data.EFCore
{
    public class SizeRepository : EfCoreRepository<Size, ApplicationDbContext>, ISizeRepository<Size>
    {
        public SizeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}