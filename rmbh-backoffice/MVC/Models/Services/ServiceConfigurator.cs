﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using rmbh.Entity;
using rmbh_backoffice.MVC.Controllers;
using rmbh_backoffice.MVC.Models.Services.Authentications;
using rmbh_backoffice.MVC.Models.Services.Users;

namespace rmbh_backoffice.MVC.Models.Services
{
    public static class ServiceConfigurator
    {
        public static ControllerFactory ConfigureServices()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("rmbh"));

            var context = new AppDbContext(optionsBuilder.Options);

            // Authentication
            IAuthenticationService authenticationService = new AuthenticationService(context);

            // User
            IUserService userService = new UserService(context);

            return new ControllerFactory
                (
                    // Atuthentication 
                    authenticationService,

                    // User
                    userService
                );
        }
    }
}
