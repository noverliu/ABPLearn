﻿using PPG.Production.EntityFramework;
using EntityFramework.DynamicFilters;

namespace PPG.Production.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly ProductionDbContext _context;

        public InitialHostDbBuilder(ProductionDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
