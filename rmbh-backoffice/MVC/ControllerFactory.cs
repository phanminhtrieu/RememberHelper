using rmbh_backoffice.MVC.Controllers;
using rmbh_backoffice.MVC.Controllers.Learning.Card;
using rmbh_backoffice.MVC.Controllers.Learning.Class;
using rmbh_backoffice.MVC.Controllers.Learning.Deck;
using rmbh_backoffice.MVC.Controllers.Login;
using rmbh_backoffice.MVC.Controllers.User;
using rmbh_backoffice.MVC.Models.Services.Authentications;
using rmbh_backoffice.MVC.Models.Services.Cards;
using rmbh_backoffice.MVC.Models.Services.Classes;
using rmbh_backoffice.MVC.Models.Services.Decks;
using rmbh_backoffice.MVC.Models.Services.Users;

namespace rmbh_backoffice.MVC
{
    /// <summary>
    /// A place where Controllers are created with their services.
    /// </summary>
    public class ControllerFactory
    {
        // Authentications
        private readonly IAuthenticationService _authenticationService;
        private readonly IUserService _userService;
        private readonly IClassService _classService;
        private readonly ICardService _cardService;
        private readonly IDeckService _deckService;

        public ControllerFactory(
            IAuthenticationService authenticationService, 
            IUserService userService,
            IClassService classService,
            ICardService cardService,
            IDeckService deckService)
        {
            _authenticationService = authenticationService;
            _userService = userService;
            _classService = classService;
            _cardService = cardService;
            _deckService = deckService;
        }

        public T CreateController<T>() where T : BaseController
        {
            object controller;

            switch (typeof(T))
            {
                case Type t when t == typeof(LoginController):
                    controller = new LoginController(_authenticationService);
                    break;

                case Type t when t == typeof(UserController):
                    controller = new UserController(_userService);
                    break;

                case Type t when t == typeof(ClassController):
                    controller = new ClassController(_classService);
                    break;

                case Type t when t == typeof(CardController):
                    controller = new CardController(_cardService, _deckService);
                    break;

                case Type t when t == typeof(DeckController):
                    controller = new DeckController(_deckService);
                    break;

                // Tạo một Controller không có inject các service vào (hay Controller đó chỉ sử dụng constructor không có tham số)
                default:
                    controller = Activator.CreateInstance<T>();
                    break;
            }

            return (T)controller;
        }
    }
}
