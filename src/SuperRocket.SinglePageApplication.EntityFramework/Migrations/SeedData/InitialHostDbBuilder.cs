using SuperRocket.SinglePageApplication.EntityFramework;
using EntityFramework.DynamicFilters;

namespace SuperRocket.SinglePageApplication.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly SinglePageApplicationDbContext _context;

        public InitialHostDbBuilder(SinglePageApplicationDbContext context)
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
