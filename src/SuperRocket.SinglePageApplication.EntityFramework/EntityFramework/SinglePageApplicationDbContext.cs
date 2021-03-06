﻿using System.Data.Common;
using Abp.Zero.EntityFramework;
using SuperRocket.SinglePageApplication.Authorization.Roles;
using SuperRocket.SinglePageApplication.Authorization.Users;
using SuperRocket.SinglePageApplication.MultiTenancy;

namespace SuperRocket.SinglePageApplication.EntityFramework
{
    public class SinglePageApplicationDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public SinglePageApplicationDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in SinglePageApplicationDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of SinglePageApplicationDbContext since ABP automatically handles it.
         */
        public SinglePageApplicationDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public SinglePageApplicationDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public SinglePageApplicationDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
