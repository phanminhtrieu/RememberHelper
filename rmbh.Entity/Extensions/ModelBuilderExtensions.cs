using Microsoft.EntityFrameworkCore;
using rmbh.Entity.Entities.Manipulation;
using rmbh.Entity.Enums;

namespace rmbh.Entity.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            DateTime CURRENT_DATE = DateTime.Now;

            // Users
            modelBuilder.Entity<User>().HasData(
                // Admin
                new User() { Id = new Guid("701e1774-9993-44fe-b377-aae0f51e0231"), Email = "trieu@gmail.com", FirstName = "Phan", LastName = "Minh Trieu", Password = "123456", Role = UserRole.Admin },
                new User() { Id = new Guid("9c0de9d9-1022-419e-9828-e8c7cc6e77c7"), Email = "van@gmail.com", FirstName = "Nguyen", LastName = "Ngoc Khanh Van", Password = "123456", Role = UserRole.Admin },
                new User() { Id = new Guid("0a647a8e-eeaf-4d96-8263-566cb883c994"), Email = "hoa@gmail.com", FirstName = "Pham", LastName = "Minh Hoa", Password = "123456", Role = UserRole.Admin },

                // Normal user
                new User() { Id = new Guid("4b6519a1-21ae-44b7-874a-0da82c60ad59"), Email = "duc@gmail.com", FirstName = "Pham", LastName = "Van Duc", Password = "123456", Role = UserRole.Learner },
                new User() { Id = new Guid("b2e1073e-5c78-4bbf-9a23-0d3a799a4f81"), Email = "vana@gmail.com", FirstName = "Nguyen", LastName = "Van A", Password = "123456", Role = UserRole.Learner },
                new User() { Id = new Guid("d5c1b63d-cd34-47a6-9d18-9b0c5e457d2f"), Email = "thib@gmail.com", FirstName = "Tran", LastName = "Thi B", Password = "123456", Role = UserRole.Learner },
                new User() { Id = new Guid("9b12349d-16b4-43fc-945c-b1632f0bcbb1"), Email = "tranv@gmail.com", FirstName = "Tran", LastName = "Van C", Password = "123456", Role = UserRole.Learner },
                new User() { Id = new Guid("f12b876c-0e2d-4d39-b878-4d5b45e93557"), Email = "lehoang@gmail.com", FirstName = "Le", LastName = "Hoang D", Password = "123456", Role = UserRole.Learner },
                new User() { Id = new Guid("22c115dd-c912-4fb2-8d57-037d89e4b5e4"), Email = "phamngoc@gmail.com", FirstName = "Pham", LastName = "Ngoc E", Password = "123456", Role = UserRole.Learner },
                new User() { Id = new Guid("5e5a20e3-3a49-48fc-8e7a-14d476403e94"), Email = "nguyenkim@gmail.com", FirstName = "Nguyen", LastName = "Kim F", Password = "123456", Role = UserRole.Learner },
                new User() { Id = new Guid("ff127b02-7f94-4ebd-8d99-91e69f4ab6ba"), Email = "truongtuan@gmail.com", FirstName = "Truong", LastName = "Tuan G", Password = "123456", Role = UserRole.Learner },
                new User() { Id = new Guid("3d1f9f41-8ac9-4c36-b85f-bcbe68d0f58c"), Email = "vominh@gmail.com", FirstName = "Vo", LastName = "Minh H", Password = "123456", Role = UserRole.Learner },
                new User() { Id = new Guid("f8d170a5-02f7-4ff4-8c12-4eb83451fcd6"), Email = "lamthanh@gmail.com", FirstName = "Lam", LastName = "Thanh I", Password = "123456", Role = UserRole.Learner },
                new User() { Id = new Guid("7d3e98b2-8825-476e-b230-63a7d8d6500b"), Email = "ngochai@gmail.com", FirstName = "Ngo", LastName = "Hai J", Password = "123456", Role = UserRole.Learner },
                new User() { Id = new Guid("139fcb97-bd85-4ee0-9849-cb77aeaa67da"), Email = "phamnhung@gmail.com", FirstName = "Pham", LastName = "Nhung K", Password = "123456", Role = UserRole.Learner },
                new User() { Id = new Guid("2a9ffb7d-89fd-4784-b7eb-1a1245d30ae6"), Email = "doviet@gmail.com", FirstName = "Do", LastName = "Viet L", Password = "123456", Role = UserRole.Learner },
                new User() { Id = new Guid("5afbead9-e4a2-4e34-8eb9-ec9989ac31b5"), Email = "leminh@gmail.com", FirstName = "Le", LastName = "Minh M", Password = "123456", Role = UserRole.Learner },
                new User() { Id = new Guid("8ad18a18-2e0a-44a3-8898-ff2da1e6e6a4"), Email = "dangquan@gmail.com", FirstName = "Dang", LastName = "Quan N", Password = "123456", Role = UserRole.Learner },
                new User() { Id = new Guid("995dd243-3d72-44fc-b8f6-dfe9b1f4abaf"), Email = "buihieu@gmail.com", FirstName = "Bui", LastName = "Hieu O", Password = "123456", Role = UserRole.Learner },
                new User() { Id = new Guid("bb7be635-3f9e-4af2-96d1-f232a717b39e"), Email = "truonganh@gmail.com", FirstName = "Truong", LastName = "Anh P", Password = "123456", Role = UserRole.Learner },
                new User() { Id = new Guid("cb00a417-417f-4d69-9ad1-e9c04e4f3d11"), Email = "danghoa@gmail.com", FirstName = "Dang", LastName = "Hoa Q", Password = "123456", Role = UserRole.Learner },
                new User() { Id = new Guid("deb20833-0427-4520-b0b9-2916b5d42d91"), Email = "ngothanh@gmail.com", FirstName = "Ngo", LastName = "Thanh R", Password = "123456", Role = UserRole.Learner },
                new User() { Id = new Guid("1b8df37b-80cf-4182-8cc9-12de166b46e2"), Email = "phuocnam@gmail.com", FirstName = "Phuoc", LastName = "Nam S", Password = "123456", Role = UserRole.Learner },
                new User() { Id = new Guid("237b98a8-9d2c-4dd7-8058-06a7c4909a6d"), Email = "lehong@gmail.com", FirstName = "Le", LastName = "Hong T", Password = "123456", Role = UserRole.Learner },
                new User() { Id = new Guid("c876965b-b849-4f4b-b1ae-4c78e5f9b3df"), Email = "nguyenanh@gmail.com", FirstName = "Nguyen", LastName = "Anh U", Password = "123456", Role = UserRole.Learner }
                );

            //// Classes
            modelBuilder.Entity<Class>().HasData(
                new Class() 
                { 
                    Id = 1, 
                    Title = "ReactJS", 
                    Description = "ReactJS is a JavaScript library by Facebook for building interactive user interfaces with reusable components. Students will learn concepts like JSX and component lifecycle, enhancing their ability to create efficient applications.", 
                    Visibility = ClassVisibility.Public, 
                    CreatedDate = CURRENT_DATE, 
                    ModifiedDate = CURRENT_DATE
                },
                new Class() 
                { 
                    Id = 2, 
                    Title = "ASP.NET Core MVC", 
                    Description = "ASP.NET Core MVC is a Microsoft framework that uses the Model-View-Controller (MVC) pattern to separate application logic from user interface. Students will learn to build APIs and manage data with Entity Framework Core while ensuring application security.", 
                    Visibility = ClassVisibility.Private, 
                    CreatedDate = CURRENT_DATE, 
                    ModifiedDate = CURRENT_DATE 
                },
                new Class() 
                { 
                    Id = 3, 
                    Title = "TailwindCSS", 
                    Description = "Tailwind CSS is a utility-first framework that allows for rapid and flexible UI design using utility classes. Students will discover how to integrate it into projects and customize layouts efficiently.", 
                    Visibility = ClassVisibility.Private, 
                    CreatedDate = CURRENT_DATE, 
                    ModifiedDate = CURRENT_DATE 
                });

            //// UserClasses
            modelBuilder.Entity<UserClass>().HasData(
                new UserClass()
                {
                    Id = 1,
                    UserId = new Guid("f8d170a5-02f7-4ff4-8c12-4eb83451fcd6"),
                    ClassId = 1,
                });

            //// Decks
            //modelBuilder.Entity<Deck>().HasData();

            //// Cards
            //modelBuilder.Entity<Card>().HasData();

        }
    }
}
