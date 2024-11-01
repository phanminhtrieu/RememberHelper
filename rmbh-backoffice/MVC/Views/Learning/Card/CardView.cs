using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using rmbh.Entity;
using System.Data;

namespace rmbh_backoffice.MVC.Views.Learning.Card
{
    public partial class CardView : BaseChildForm, IView
    {
        public Form Form
        {
            get
            {
                return this;
            }
        }

        public string Title
        {
            get
            {
                return Text;
            }

            set
            {
                Text = value;
            }
        }

        private readonly AppDbContext _context;

        public CardView()
        {
            InitializeComponent();
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("rmbh"));

            _context = new AppDbContext(optionsBuilder.Options);
        }

        private void CardView_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = _context.Cards.ToList();
        }
    }
}
