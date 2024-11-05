using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using rmbh.Entity;
using rmbh_backoffice.MVC.Models.Services.Authentications;
using rmbh_backoffice.MVC.Models.Services.Cards;
using rmbh_backoffice.MVC.Models.Services.Classes;
using rmbh_backoffice.MVC.Models.Services.Decks;
using rmbh_backoffice.MVC.Models.Services.Users;

namespace rmbh_backoffice.MVC
{
    public static class ServiceConfigurator
    {
        /// <summary>
        /// Inject db context into controller and create ControllerFactory
        /// </summary>
        /// <returns></returns>
        public static ControllerFactory ConfigureServices()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("rmbh"));

            var context = new AppDbContext(optionsBuilder.Options);

            #region Service

            // Authentication
            IAuthenticationService authenticationService = new AuthenticationService(context);

            // User
            IUserService userService = new UserService(context);

            // Learning
            IClassService classService = new ClassService(context);
            ICardService cardService = new CardService(context);
            IDeckService deckService = new DeckService(context);


            #endregion

            return new ControllerFactory
                (
                    // Atuthentication 
                    authenticationService,

                    // User
                    userService,

                    // Learning
                    classService,
                    cardService
                    classService,
                    deckService
                );
        }
    }
}
