﻿using Autofac;
using Library.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySys.Framework
{
    public class FrameworkModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public FrameworkModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<FrameworkContext>()
                   .WithParameter("connectionString", _connectionString)
                   .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                   .InstancePerLifetimeScope();

            builder.RegisterType<BookUnitOfWork>().As<IBookUnitOfWork>()
                   .InstancePerLifetimeScope();
            builder.RegisterType<BookService>().As<IBookService>()
                   .InstancePerLifetimeScope();
            builder.RegisterType<BookRepository>().As<IBookRepository>()
                   .InstancePerLifetimeScope();


            base.Load(builder);
        }
    }
}
