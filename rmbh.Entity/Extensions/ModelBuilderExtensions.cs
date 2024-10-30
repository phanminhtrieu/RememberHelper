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
                new User() { Id = new Guid("701e1774-9993-44fe-b377-aae0f51e0231"), Email = "trieu@gmail.com", FirstName = "Phan", LastName = "Minh Trieu", Password = "123456", Role = UserRole.Admin, CreatedDate = CURRENT_DATE, ModifiedDate = CURRENT_DATE },
                new User() { Id = new Guid("9c0de9d9-1022-419e-9828-e8c7cc6e77c7"), Email = "van@gmail.com", FirstName = "Nguyen", LastName = "Ngoc Khanh Van", Password = "123456", Role = UserRole.Admin, CreatedDate = CURRENT_DATE, ModifiedDate = CURRENT_DATE },
                new User() { Id = new Guid("0a647a8e-eeaf-4d96-8263-566cb883c994"), Email = "hoa@gmail.com", FirstName = "Pham", LastName = "Minh Hoa", Password = "123456", Role = UserRole.Admin, CreatedDate = CURRENT_DATE, ModifiedDate = CURRENT_DATE },

                // Normal user
                new User() { Id = new Guid("4b6519a1-21ae-44b7-874a-0da82c60ad59"), Email = "duc@gmail.com", FirstName = "Pham", LastName = "Van Duc", Password = "123456", Role = UserRole.Learner, CreatedDate = CURRENT_DATE, ModifiedDate = CURRENT_DATE },
                new User() { Id = new Guid("b2e1073e-5c78-4bbf-9a23-0d3a799a4f81"), Email = "vana@gmail.com", FirstName = "Nguyen", LastName = "Van A", Password = "123456", Role = UserRole.Learner, CreatedDate = CURRENT_DATE, ModifiedDate = CURRENT_DATE },
                new User() { Id = new Guid("d5c1b63d-cd34-47a6-9d18-9b0c5e457d2f"), Email = "thib@gmail.com", FirstName = "Tran", LastName = "Thi B", Password = "123456", Role = UserRole.Learner, CreatedDate = CURRENT_DATE, ModifiedDate = CURRENT_DATE },
                new User() { Id = new Guid("9b12349d-16b4-43fc-945c-b1632f0bcbb1"), Email = "tranv@gmail.com", FirstName = "Tran", LastName = "Van C", Password = "123456", Role = UserRole.Learner, CreatedDate = CURRENT_DATE, ModifiedDate = CURRENT_DATE },
                new User() { Id = new Guid("f12b876c-0e2d-4d39-b878-4d5b45e93557"), Email = "lehoang@gmail.com", FirstName = "Le", LastName = "Hoang D", Password = "123456", Role = UserRole.Learner, CreatedDate = CURRENT_DATE, ModifiedDate = CURRENT_DATE },
                new User() { Id = new Guid("22c115dd-c912-4fb2-8d57-037d89e4b5e4"), Email = "phamngoc@gmail.com", FirstName = "Pham", LastName = "Ngoc E", Password = "123456", Role = UserRole.Learner, CreatedDate = CURRENT_DATE, ModifiedDate = CURRENT_DATE },
                new User() { Id = new Guid("5e5a20e3-3a49-48fc-8e7a-14d476403e94"), Email = "nguyenkim@gmail.com", FirstName = "Nguyen", LastName = "Kim F", Password = "123456", Role = UserRole.Learner, CreatedDate = CURRENT_DATE, ModifiedDate = CURRENT_DATE },
                new User() { Id = new Guid("ff127b02-7f94-4ebd-8d99-91e69f4ab6ba"), Email = "truongtuan@gmail.com", FirstName = "Truong", LastName = "Tuan G", Password = "123456", Role = UserRole.Learner, CreatedDate = CURRENT_DATE, ModifiedDate = CURRENT_DATE },
                new User() { Id = new Guid("3d1f9f41-8ac9-4c36-b85f-bcbe68d0f58c"), Email = "vominh@gmail.com", FirstName = "Vo", LastName = "Minh H", Password = "123456", Role = UserRole.Learner, CreatedDate = CURRENT_DATE, ModifiedDate = CURRENT_DATE },
                new User() { Id = new Guid("f8d170a5-02f7-4ff4-8c12-4eb83451fcd6"), Email = "lamthanh@gmail.com", FirstName = "Lam", LastName = "Thanh I", Password = "123456", Role = UserRole.Learner, CreatedDate = CURRENT_DATE, ModifiedDate = CURRENT_DATE },
                new User() { Id = new Guid("7d3e98b2-8825-476e-b230-63a7d8d6500b"), Email = "ngochai@gmail.com", FirstName = "Ngo", LastName = "Hai J", Password = "123456", Role = UserRole.Learner, CreatedDate = CURRENT_DATE, ModifiedDate = CURRENT_DATE },
                new User() { Id = new Guid("139fcb97-bd85-4ee0-9849-cb77aeaa67da"), Email = "phamnhung@gmail.com", FirstName = "Pham", LastName = "Nhung K", Password = "123456", Role = UserRole.Learner, CreatedDate = CURRENT_DATE, ModifiedDate = CURRENT_DATE },
                new User() { Id = new Guid("2a9ffb7d-89fd-4784-b7eb-1a1245d30ae6"), Email = "doviet@gmail.com", FirstName = "Do", LastName = "Viet L", Password = "123456", Role = UserRole.Learner, CreatedDate = CURRENT_DATE, ModifiedDate = CURRENT_DATE },
                new User() { Id = new Guid("5afbead9-e4a2-4e34-8eb9-ec9989ac31b5"), Email = "leminh@gmail.com", FirstName = "Le", LastName = "Minh M", Password = "123456", Role = UserRole.Learner, CreatedDate = CURRENT_DATE, ModifiedDate = CURRENT_DATE },
                new User() { Id = new Guid("8ad18a18-2e0a-44a3-8898-ff2da1e6e6a4"), Email = "dangquan@gmail.com", FirstName = "Dang", LastName = "Quan N", Password = "123456", Role = UserRole.Learner, CreatedDate = CURRENT_DATE, ModifiedDate = CURRENT_DATE },
                new User() { Id = new Guid("995dd243-3d72-44fc-b8f6-dfe9b1f4abaf"), Email = "buihieu@gmail.com", FirstName = "Bui", LastName = "Hieu O", Password = "123456", Role = UserRole.Learner, CreatedDate = CURRENT_DATE, ModifiedDate = CURRENT_DATE },
                new User() { Id = new Guid("bb7be635-3f9e-4af2-96d1-f232a717b39e"), Email = "truonganh@gmail.com", FirstName = "Truong", LastName = "Anh P", Password = "123456", Role = UserRole.Learner, CreatedDate = CURRENT_DATE, ModifiedDate = CURRENT_DATE },
                new User() { Id = new Guid("cb00a417-417f-4d69-9ad1-e9c04e4f3d11"), Email = "danghoa@gmail.com", FirstName = "Dang", LastName = "Hoa Q", Password = "123456", Role = UserRole.Learner, CreatedDate = CURRENT_DATE, ModifiedDate = CURRENT_DATE },
                new User() { Id = new Guid("deb20833-0427-4520-b0b9-2916b5d42d91"), Email = "ngothanh@gmail.com", FirstName = "Ngo", LastName = "Thanh R", Password = "123456", Role = UserRole.Learner, CreatedDate = CURRENT_DATE, ModifiedDate = CURRENT_DATE },
                new User() { Id = new Guid("1b8df37b-80cf-4182-8cc9-12de166b46e2"), Email = "phuocnam@gmail.com", FirstName = "Phuoc", LastName = "Nam S", Password = "123456", Role = UserRole.Learner, CreatedDate = CURRENT_DATE, ModifiedDate = CURRENT_DATE },
                new User() { Id = new Guid("237b98a8-9d2c-4dd7-8058-06a7c4909a6d"), Email = "lehong@gmail.com", FirstName = "Le", LastName = "Hong T", Password = "123456", Role = UserRole.Learner, CreatedDate = CURRENT_DATE, ModifiedDate = CURRENT_DATE },
                new User() { Id = new Guid("c876965b-b849-4f4b-b1ae-4c78e5f9b3df"), Email = "nguyenanh@gmail.com", FirstName = "Nguyen", LastName = "Anh U", Password = "123456", Role = UserRole.Learner, CreatedDate = CURRENT_DATE, ModifiedDate = CURRENT_DATE }
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
                new UserClass
                {
                    Id = 1,
                    UserId = new Guid("4b6519a1-21ae-44b7-874a-0da82c60ad59"),
                    ClassId = 1,
                    Role = ClassRole.Owner,
                    JoinedDate = DateTime.Now,
                    TimeSpent = 320,
                    MasteryScore = MasteryScore.Poor,
                    LastLearningDate = DateTime.Now
                },
                new UserClass
                {
                    Id = 2,
                    UserId = new Guid("b2e1073e-5c78-4bbf-9a23-0d3a799a4f81"),
                    ClassId = 1,
                    Role = ClassRole.Member,
                    JoinedDate = DateTime.Now,
                    TimeSpent = 275,
                    MasteryScore = MasteryScore.VeryPoor,
                    LastLearningDate = DateTime.Now
                },
                new UserClass
                {
                    Id = 3,
                    UserId = new Guid("d5c1b63d-cd34-47a6-9d18-9b0c5e457d2f"),
                    ClassId = 1,
                    Role = ClassRole.Member,
                    JoinedDate = DateTime.Now,
                    TimeSpent = 150,
                    MasteryScore = MasteryScore.Excellent,
                    LastLearningDate = DateTime.Now
                },
                new UserClass
                {
                    Id = 4,
                    UserId = new Guid("9b12349d-16b4-43fc-945c-b1632f0bcbb1"),
                    ClassId = 1,
                    Role = ClassRole.Member,
                    JoinedDate = DateTime.Now,
                    TimeSpent = 480,
                    MasteryScore = MasteryScore.Excellent,
                    LastLearningDate = DateTime.Now
                },
                new UserClass
                {
                    Id = 5,
                    UserId = new Guid("f12b876c-0e2d-4d39-b878-4d5b45e93557"),
                    ClassId = 1,
                    Role = ClassRole.Member,
                    JoinedDate = DateTime.Now,
                    TimeSpent = 200,
                    MasteryScore = MasteryScore.Excellent,
                    LastLearningDate = DateTime.Now
                },
                new UserClass
                {
                    Id = 6,
                    UserId = new Guid("22c115dd-c912-4fb2-8d57-037d89e4b5e4"),
                    ClassId = 1,
                    Role = ClassRole.Member,
                    JoinedDate = DateTime.Now,
                    TimeSpent = 360,
                    MasteryScore = MasteryScore.Excellent,
                    LastLearningDate = DateTime.Now
                },
                new UserClass
                {
                    Id = 7,
                    UserId = new Guid("5e5a20e3-3a49-48fc-8e7a-14d476403e94"),
                    ClassId = 1,
                    Role = ClassRole.Member,
                    JoinedDate = DateTime.Now,
                    TimeSpent = 110,
                    MasteryScore = MasteryScore.VeryPoor,
                    LastLearningDate = DateTime.Now
                },
                new UserClass
                {
                    Id = 8,
                    UserId = new Guid("ff127b02-7f94-4ebd-8d99-91e69f4ab6ba"),
                    ClassId = 1,
                    Role = ClassRole.Member,
                    JoinedDate = DateTime.Now,
                    TimeSpent = 430,
                    MasteryScore = MasteryScore.Good,
                    LastLearningDate = DateTime.Now
                },

                new UserClass
                {
                    Id = 9,
                    UserId = new Guid("3d1f9f41-8ac9-4c36-b85f-bcbe68d0f58c"),
                    ClassId = 2,
                    Role = ClassRole.Owner,
                    JoinedDate = DateTime.Now,
                    TimeSpent = 120,
                    MasteryScore = MasteryScore.Excellent,
                    LastLearningDate = DateTime.Now
                },
                new UserClass
                {
                    Id = 10,
                    UserId = new Guid("f8d170a5-02f7-4ff4-8c12-4eb83451fcd6"),
                    ClassId = 2,
                    Role = ClassRole.Member,
                    JoinedDate = DateTime.Now,
                    TimeSpent = 290,
                    MasteryScore = MasteryScore.Excellent,
                    LastLearningDate = DateTime.Now
                },
                new UserClass
                {
                    Id = 11,
                    UserId = new Guid("7d3e98b2-8825-476e-b230-63a7d8d6500b"),
                    ClassId = 2,
                    Role = ClassRole.Member,
                    JoinedDate = DateTime.Now,
                    TimeSpent = 240,
                    MasteryScore = MasteryScore.Excellent,
                    LastLearningDate = DateTime.Now
                },
                new UserClass
                {
                    Id = 12,
                    UserId = new Guid("139fcb97-bd85-4ee0-9849-cb77aeaa67da"),
                    ClassId = 2,
                    Role = ClassRole.Member,
                    JoinedDate = DateTime.Now,
                    TimeSpent = 310,
                    MasteryScore = MasteryScore.Excellent,
                    LastLearningDate = DateTime.Now
                },
                new UserClass
                {
                    Id = 13,
                    UserId = new Guid("2a9ffb7d-89fd-4784-b7eb-1a1245d30ae6"),
                    ClassId = 2,
                    Role = ClassRole.Member,
                    JoinedDate = DateTime.Now,
                    TimeSpent = 405,
                    MasteryScore = MasteryScore.Excellent,
                    LastLearningDate = DateTime.Now
                },
                new UserClass
                {
                    Id = 14,
                    UserId = new Guid("5afbead9-e4a2-4e34-8eb9-ec9989ac31b5"),
                    ClassId = 2,
                    Role = ClassRole.Member,
                    JoinedDate = DateTime.Now,
                    TimeSpent = 500,
                    MasteryScore = MasteryScore.Excellent,
                    LastLearningDate = DateTime.Now
                },
                new UserClass
                {
                    Id = 15,
                    UserId = new Guid("8ad18a18-2e0a-44a3-8898-ff2da1e6e6a4"),
                    ClassId = 2,
                    Role = ClassRole.Member,
                    JoinedDate = DateTime.Now,
                    TimeSpent = 370,
                    MasteryScore = MasteryScore.Excellent,
                    LastLearningDate = DateTime.Now
                },
                new UserClass
                {
                    Id = 16,
                    UserId = new Guid("995dd243-3d72-44fc-b8f6-dfe9b1f4abaf"),
                    ClassId = 2,
                    Role = ClassRole.Member,
                    JoinedDate = DateTime.Now,
                    TimeSpent = 180,
                    MasteryScore = MasteryScore.Excellent,
                    LastLearningDate = DateTime.Now
                },

                new UserClass
                {
                    Id = 17,
                    UserId = new Guid("bb7be635-3f9e-4af2-96d1-f232a717b39e"),
                    ClassId = 3,
                    Role = ClassRole.Owner,
                    JoinedDate = DateTime.Now,
                    TimeSpent = 300,
                    MasteryScore = MasteryScore.Excellent,
                    LastLearningDate = DateTime.Now
                },
                new UserClass
                {
                    Id = 18,
                    UserId = new Guid("cb00a417-417f-4d69-9ad1-e9c04e4f3d11"),
                    ClassId = 3,
                    Role = ClassRole.Member,
                    JoinedDate = DateTime.Now,
                    TimeSpent = 110,
                    MasteryScore = MasteryScore.Excellent,
                    LastLearningDate = DateTime.Now
                },
                new UserClass
                {
                    Id = 19,
                    UserId = new Guid("deb20833-0427-4520-b0b9-2916b5d42d91"),
                    ClassId = 3,
                    Role = ClassRole.Member,
                    JoinedDate = DateTime.Now,
                    TimeSpent = 410,
                    MasteryScore = MasteryScore.Excellent,
                    LastLearningDate = DateTime.Now
                },
                new UserClass
                {
                    Id = 20,
                    UserId = new Guid("1b8df37b-80cf-4182-8cc9-12de166b46e2"),
                    ClassId = 3,
                    Role = ClassRole.Member,
                    JoinedDate = DateTime.Now,
                    TimeSpent = 450,
                    MasteryScore = MasteryScore.Excellent,
                    LastLearningDate = DateTime.Now
                },
                new UserClass
                {
                    Id = 21,
                    UserId = new Guid("237b98a8-9d2c-4dd7-8058-06a7c4909a6d"),
                    ClassId = 3,
                    Role = ClassRole.Member,
                    JoinedDate = DateTime.Now,
                    TimeSpent = 215,
                    MasteryScore = MasteryScore.Excellent,
                    LastLearningDate = DateTime.Now
                },
                new UserClass
                {
                    Id = 22,
                    UserId = new Guid("c876965b-b849-4f4b-b1ae-4c78e5f9b3df"),
                    ClassId = 3,
                    Role = ClassRole.Member,
                    JoinedDate = DateTime.Now,
                    TimeSpent = 170,
                    MasteryScore = MasteryScore.Poor,
                    LastLearningDate = DateTime.Now
                },
                new UserClass
                {
                    Id = 23,
                    UserId = new Guid("7d3e98b2-8825-476e-b230-63a7d8d6500b"),
                    ClassId = 3,
                    Role = ClassRole.Member,
                    JoinedDate = DateTime.Now,
                    TimeSpent = 275,
                    MasteryScore = MasteryScore.Good,
                    LastLearningDate = DateTime.Now
                },
                new UserClass
                {
                    Id = 24,
                    UserId = new Guid("f8d170a5-02f7-4ff4-8c12-4eb83451fcd6"),
                    ClassId = 3,
                    Role = ClassRole.Member,
                    JoinedDate = DateTime.Now,
                    TimeSpent = 350,
                    MasteryScore = MasteryScore.Good,
                    LastLearningDate = DateTime.Now
                });

            //// Decks
            modelBuilder.Entity<Deck>().HasData(
                new Deck
                {
                    Id = 1,
                    ClassId = 1,
                    Title = "React Basics",
                    Description = "This deck covers the fundamental concepts of React, including components, props, and state management.",
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    SortOrder = 1,
                    StudyDeckType = StudyDeckType.Random
                },
                new Deck
                {
                    Id = 2,
                    ClassId = 1,
                    Title = "Advanced React Patterns",
                    Description = "Explore advanced patterns in React such as Higher-Order Components, Render Props, and Context API.",
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    SortOrder = 2,
                    StudyDeckType = StudyDeckType.Progressive
                },

                new Deck
                {
                    Id = 3,
                    ClassId = 2,
                    Title = "ASP.NET Core Fundamentals",
                    Description = "Learn the basics of ASP.NET Core, including routing, middleware, and dependency injection.",
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    SortOrder = 1,
                    StudyDeckType = StudyDeckType.Random
                },
                new Deck
                {
                    Id = 4,
                    ClassId = 2,
                    Title = "Building REST APIs",
                    Description = "This deck focuses on creating RESTful APIs using ASP.NET Core MVC and Entity Framework.",
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    SortOrder = 2,
                    StudyDeckType = StudyDeckType.Progressive
                },

                new Deck
                {
                    Id = 5,
                    ClassId = 3,
                    Title = "Introduction to TailwindCSS",
                    Description = "Discover the utility-first approach to CSS with TailwindCSS and how to get started with it.",
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    SortOrder = 1,
                    StudyDeckType = StudyDeckType.Random
                },
                new Deck
                {
                    Id = 6,
                    ClassId = 3,
                    Title = "Advanced Tailwind Techniques",
                    Description = "Learn advanced techniques in TailwindCSS for customizing designs and improving workflow.",
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    SortOrder = 2,
                    StudyDeckType = StudyDeckType.Progressive
                });

            // UserDeckStatistic
            modelBuilder.Entity<UserDeckStatistic>().HasData(
                // Class 1: ReactJS
                new UserDeckStatistic
                {
                    Id = 1,
                    DeckId = 1,
                    UserId = new Guid("4b6519a1-21ae-44b7-874a-0da82c60ad59"), // Owner
                    TimeSpent = 120,
                    MasteryScore = MasteryScore.Excellent,
                    Day = DateTime.Now.Day,
                    Month = DateTime.Now.Month,
                    Year = DateTime.Now.Year,
                    Note = "Completed all sections."
                },
                new UserDeckStatistic
                {
                    Id = 2,
                    DeckId = 1,
                    UserId = new Guid("b2e1073e-5c78-4bbf-9a23-0d3a799a4f81"),
                    TimeSpent = 150,
                    MasteryScore = MasteryScore.Good,
                    Day = DateTime.Now.Day,
                    Month = DateTime.Now.Month,
                    Year = DateTime.Now.Year,
                    Note = "Struggled with some concepts."
                },
                new UserDeckStatistic
                {
                    Id = 3,
                    DeckId = 1,
                    UserId = new Guid("d5c1b63d-cd34-47a6-9d18-9b0c5e457d2f"),
                    TimeSpent = 180,
                    MasteryScore = MasteryScore.Average,
                    Day = DateTime.Now.Day,
                    Month = DateTime.Now.Month,
                    Year = DateTime.Now.Year,
                    Note = "Basic understanding."
                },
                new UserDeckStatistic
                {
                    Id = 4,
                    DeckId = 2,
                    UserId = new Guid("9b12349d-16b4-43fc-945c-b1632f0bcbb1"),
                    TimeSpent = 200,
                    MasteryScore = MasteryScore.Good,
                    Day = DateTime.Now.Day,
                    Month = DateTime.Now.Month,
                    Year = DateTime.Now.Year,
                    Note = "Learned some advanced patterns."
                },
                new UserDeckStatistic
                {
                    Id = 5,
                    DeckId = 2,
                    UserId = new Guid("f12b876c-0e2d-4d39-b878-4d5b45e93557"),
                    TimeSpent = 220,
                    MasteryScore = MasteryScore.Poor,
                    Day = DateTime.Now.Day,
                    Month = DateTime.Now.Month,
                    Year = DateTime.Now.Year,
                    Note = "Need more practice."
                },
                new UserDeckStatistic
                {
                    Id = 6,
                    DeckId = 2,
                    UserId = new Guid("22c115dd-c912-4fb2-8d57-037d89e4b5e4"),
                    TimeSpent = 260,
                    MasteryScore = MasteryScore.VeryPoor,
                    Day = DateTime.Now.Day,
                    Month = DateTime.Now.Month,
                    Year = DateTime.Now.Year,
                    Note = "Very confused about the concepts."
                },
                new UserDeckStatistic
                {
                    Id = 7,
                    DeckId = 2,
                    UserId = new Guid("5e5a20e3-3a49-48fc-8e7a-14d476403e94"),
                    TimeSpent = 230,
                    MasteryScore = MasteryScore.Average,
                    Day = DateTime.Now.Day,
                    Month = DateTime.Now.Month,
                    Year = DateTime.Now.Year,
                    Note = "Moderate understanding."
                },
                new UserDeckStatistic
                {
                    Id = 8,
                    DeckId = 2,
                    UserId = new Guid("ff127b02-7f94-4ebd-8d99-91e69f4ab6ba"),
                    TimeSpent = 210,
                    MasteryScore = MasteryScore.Good,
                    Day = DateTime.Now.Day,
                    Month = DateTime.Now.Month,
                    Year = DateTime.Now.Year,
                    Note = "Good grasp on the subject."
                },

                // Class 2: ASP.NET Core MVC
                new UserDeckStatistic
                {
                    Id = 9,
                    DeckId = 3,
                    UserId = new Guid("3d1f9f41-8ac9-4c36-b85f-bcbe68d0f58c"), // Owner
                    TimeSpent = 140,
                    MasteryScore = MasteryScore.Excellent,
                    Day = DateTime.Now.Day,
                    Month = DateTime.Now.Month,
                    Year = DateTime.Now.Year,
                    Note = "Mastered the fundamentals."
                },
                new UserDeckStatistic
                {
                    Id = 10,
                    DeckId = 3,
                    UserId = new Guid("f8d170a5-02f7-4ff4-8c12-4eb83451fcd6"),
                    TimeSpent = 160,
                    MasteryScore = MasteryScore.Good,
                    Day = DateTime.Now.Day,
                    Month = DateTime.Now.Month,
                    Year = DateTime.Now.Year,
                    Note = "Good understanding of routing."
                },
                new UserDeckStatistic
                {
                    Id = 11,
                    DeckId = 3,
                    UserId = new Guid("7d3e98b2-8825-476e-b230-63a7d8d6500b"),
                    TimeSpent = 180,
                    MasteryScore = MasteryScore.Average,
                    Day = DateTime.Now.Day,
                    Month = DateTime.Now.Month,
                    Year = DateTime.Now.Year,
                    Note = "Basic grasp of middleware."
                },
                new UserDeckStatistic
                {
                    Id = 12,
                    DeckId = 4,
                    UserId = new Guid("139fcb97-bd85-4ee0-9849-cb77aeaa67da"),
                    TimeSpent = 190,
                    MasteryScore = MasteryScore.Good,
                    Day = DateTime.Now.Day,
                    Month = DateTime.Now.Month,
                    Year = DateTime.Now.Year,
                    Note = "Successfully built an API."
                },
                new UserDeckStatistic
                {
                    Id = 13,
                    DeckId = 4,
                    UserId = new Guid("2a9ffb7d-89fd-4784-b7eb-1a1245d30ae6"),
                    TimeSpent = 210,
                    MasteryScore = MasteryScore.Poor,
                    Day = DateTime.Now.Day,
                    Month = DateTime.Now.Month,
                    Year = DateTime.Now.Year,
                    Note = "Still learning the API concepts."
                },
                new UserDeckStatistic
                {
                    Id = 14,
                    DeckId = 4,
                    UserId = new Guid("5afbead9-e4a2-4e34-8eb9-ec9989ac31b5"),
                    TimeSpent = 220,
                    MasteryScore = MasteryScore.VeryPoor,
                    Day = DateTime.Now.Day,
                    Month = DateTime.Now.Month,
                    Year = DateTime.Now.Year,
                    Note = "Completely lost on this."
                },
                new UserDeckStatistic
                {
                    Id = 15,
                    DeckId = 4,
                    UserId = new Guid("8ad18a18-2e0a-44a3-8898-ff2da1e6e6a4"),
                    TimeSpent = 200,
                    MasteryScore = MasteryScore.Average,
                    Day = DateTime.Now.Day,
                    Month = DateTime.Now.Month,
                    Year = DateTime.Now.Year,
                    Note = "Moderate understanding."
                },
                new UserDeckStatistic
                {
                    Id = 16,
                    DeckId = 4,
                    UserId = new Guid("995dd243-3d72-44fc-b8f6-dfe9b1f4abaf"),
                    TimeSpent = 230,
                    MasteryScore = MasteryScore.Good,
                    Day = DateTime.Now.Day,
                    Month = DateTime.Now.Month,
                    Year = DateTime.Now.Year,
                    Note = "Good grasp on API building."
                },

                // Class 3: TailwindCSS
                new UserDeckStatistic
                {
                    Id = 17,
                    DeckId = 5,
                    UserId = new Guid("bb7be635-3f9e-4af2-96d1-f232a717b39e"), // Owner
                    TimeSpent = 130,
                    MasteryScore = MasteryScore.Excellent,
                    Day = DateTime.Now.Day,
                    Month = DateTime.Now.Month,
                    Year = DateTime.Now.Year,
                    Note = "Perfectly understood the utility-first approach."
                },
                new UserDeckStatistic
                {
                    Id = 18,
                    DeckId = 5,
                    UserId = new Guid("cb00a417-417f-4d69-9ad1-e9c04e4f3d11"),
                    TimeSpent = 150,
                    MasteryScore = MasteryScore.Good,
                    Day = DateTime.Now.Day,
                    Month = DateTime.Now.Month,
                    Year = DateTime.Now.Year,
                    Note = "Nice introduction to TailwindCSS."
                },
                new UserDeckStatistic
                {
                    Id = 19,
                    DeckId = 5,
                    UserId = new Guid("deb20833-0427-4520-b0b9-2916b5d42d91"),
                    TimeSpent = 170,
                    MasteryScore = MasteryScore.Average,
                    Day = DateTime.Now.Day,
                    Month = DateTime.Now.Month,
                    Year = DateTime.Now.Year,
                    Note = "Need to work more on customization."
                },
                new UserDeckStatistic
                {
                    Id = 20,
                    DeckId = 6,
                    UserId = new Guid("1b8df37b-80cf-4182-8cc9-12de166b46e2"),
                    TimeSpent = 190,
                    MasteryScore = MasteryScore.Good,
                    Day = DateTime.Now.Day,
                    Month = DateTime.Now.Month,
                    Year = DateTime.Now.Year,
                    Note = "Good start with the framework."
                },
                new UserDeckStatistic
                {
                    Id = 21,
                    DeckId = 6,
                    UserId = new Guid("237b98a8-9d2c-4dd7-8058-06a7c4909a6d"),
                    TimeSpent = 210,
                    MasteryScore = MasteryScore.Poor,
                    Day = DateTime.Now.Day,
                    Month = DateTime.Now.Month,
                    Year = DateTime.Now.Year,
                    Note = "Struggled with understanding the utility classes."
                },
                new UserDeckStatistic
                {
                    Id = 22,
                    DeckId = 6,
                    UserId = new Guid("c876965b-b849-4f4b-b1ae-4c78e5f9b3df"),
                    TimeSpent = 220,
                    MasteryScore = MasteryScore.VeryPoor,
                    Day = DateTime.Now.Day,
                    Month = DateTime.Now.Month,
                    Year = DateTime.Now.Year,
                    Note = "Completely lost in the initial stages."
                });

            //// Cards
            modelBuilder.Entity<Card>().HasData(
                // Deck 1: Card examples for ReactJS
                new Card
                {
                    Id = 1,
                    DeckId = 1,
                    Question = "What is JSX?",
                    Answer = "JSX is a syntax extension for JavaScript that allows you to write HTML-like code within JavaScript.",
                    SortOrder = 1,
                    QuestionClarifier = "It's commonly used with React.",
                    AnswerClarifier = "JSX gets compiled to JavaScript.",
                    QuestionFootnote = "JSX can be confused with HTML.",
                    AnswerFootnote = "JSX is not mandatory in React.",
                    CreatedUserId = new Guid("4b6519a1-21ae-44b7-874a-0da82c60ad59"), // Owner
                    ModifiedUserId = new Guid("4b6519a1-21ae-44b7-874a-0da82c60ad59")
                },
                new Card
                {
                    Id = 2,
                    DeckId = 1,
                    Question = "What are components?",
                    Answer = "Components are independent, reusable pieces of code that return a React element.",
                    SortOrder = 2,
                    QuestionClarifier = "They can be functional or class-based.",
                    AnswerClarifier = "Components can manage their own state.",
                    QuestionFootnote = "Components can be nested within each other.",
                    AnswerFootnote = "They enhance reusability.",
                    CreatedUserId = new Guid("4b6519a1-21ae-44b7-874a-0da82c60ad59"),
                    ModifiedUserId = new Guid("4b6519a1-21ae-44b7-874a-0da82c60ad59")
                },
                new Card
                {
                    Id = 3,
                    DeckId = 1,
                    Question = "What is state?",
                    Answer = "State is an object that holds data about the component's current situation.",
                    SortOrder = 3,
                    QuestionClarifier = "State allows components to create dynamic and interactive applications.",
                    AnswerClarifier = "State updates trigger re-renders.",
                    QuestionFootnote = "State is managed within the component.",
                    AnswerFootnote = "State should be updated using setState.",
                    CreatedUserId = new Guid("4b6519a1-21ae-44b7-874a-0da82c60ad59"),
                    ModifiedUserId = new Guid("4b6519a1-21ae-44b7-874a-0da82c60ad59")
                },
                new Card
                {
                    Id = 4,
                    DeckId = 1,
                    Question = "What is a prop?",
                    Answer = "Props are inputs to React components that allow data to be passed down from parent to child.",
                    SortOrder = 4,
                    QuestionClarifier = "Props are read-only.",
                    AnswerClarifier = "They enable component communication.",
                    QuestionFootnote = "Props can be any type of data.",
                    AnswerFootnote = "Props do not change inside the component.",
                    CreatedUserId = new Guid("4b6519a1-21ae-44b7-874a-0da82c60ad59"),
                    ModifiedUserId = new Guid("4b6519a1-21ae-44b7-874a-0da82c60ad59")
                },
                new Card
                {
                    Id = 5,
                    DeckId = 1,
                    Question = "What is a lifecycle method?",
                    Answer = "Lifecycle methods are hooks that allow you to run code at specific points in a component's life.",
                    SortOrder = 5,
                    QuestionClarifier = "They include mounting, updating, and unmounting.",
                    AnswerClarifier = "Common methods include componentDidMount and componentWillUnmount.",
                    QuestionFootnote = "Lifecycle methods are specific to class components.",
                    AnswerFootnote = "Hooks offer similar functionality in functional components.",
                    CreatedUserId = new Guid("4b6519a1-21ae-44b7-874a-0da82c60ad59"),
                    ModifiedUserId = new Guid("4b6519a1-21ae-44b7-874a-0da82c60ad59")
                },

                // Deck 2: Card examples for ASP.NET Core MVC
                new Card
                {
                    Id = 6,
                    DeckId = 3,
                    Question = "What is ASP.NET Core?",
                    Answer = "ASP.NET Core is a cross-platform framework for building modern cloud-based web applications.",
                    SortOrder = 1,
                    QuestionClarifier = "It is an open-source framework.",
                    AnswerClarifier = "ASP.NET Core is designed for high performance.",
                    QuestionFootnote = "It supports microservices architecture.",
                    AnswerFootnote = "ASP.NET Core can run on Windows, macOS, and Linux.",
                    CreatedUserId = new Guid("3d1f9f41-8ac9-4c36-b85f-bcbe68d0f58c"), // Owner
                    ModifiedUserId = new Guid("3d1f9f41-8ac9-4c36-b85f-bcbe68d0f58c")
                },
                new Card
                {
                    Id = 7,
                    DeckId = 3,
                    Question = "What is the MVC pattern?",
                    Answer = "MVC stands for Model-View-Controller, a pattern used to separate application logic from the user interface.",
                    SortOrder = 2,
                    QuestionClarifier = "It helps in organizing code and making it maintainable.",
                    AnswerClarifier = "MVC divides an application into three interconnected components.",
                    QuestionFootnote = "Models represent the data.",
                    AnswerFootnote = "Controllers handle user input.",
                    CreatedUserId = new Guid("3d1f9f41-8ac9-4c36-b85f-bcbe68d0f58c"),
                    ModifiedUserId = new Guid("3d1f9f41-8ac9-4c36-b85f-bcbe68d0f58c")
                },
                new Card
                {
                    Id = 8,
                    DeckId = 3,
                    Question = "What is Entity Framework Core?",
                    Answer = "Entity Framework Core is an ORM (Object-Relational Mapper) for .NET applications.",
                    SortOrder = 3,
                    QuestionClarifier = "It allows developers to work with a database using .NET objects.",
                    AnswerClarifier = "EF Core simplifies data access.",
                    QuestionFootnote = "It supports LINQ queries.",
                    AnswerFootnote = "EF Core can be used with various databases.",
                    CreatedUserId = new Guid("3d1f9f41-8ac9-4c36-b85f-bcbe68d0f58c"),
                    ModifiedUserId = new Guid("3d1f9f41-8ac9-4c36-b85f-bcbe68d0f58c")
                },
                new Card
                {
                    Id = 9,
                    DeckId = 3,
                    Question = "What is middleware?",
                    Answer = "Middleware is software that connects different applications or services.",
                    SortOrder = 4,
                    QuestionClarifier = "In ASP.NET Core, middleware are components that are assembled into an application pipeline.",
                    AnswerClarifier = "Middleware can perform operations on HTTP requests.",
                    QuestionFootnote = "Middleware can be added in the Configure method.",
                    AnswerFootnote = "Common middleware includes authentication and logging.",
                    CreatedUserId = new Guid("3d1f9f41-8ac9-4c36-b85f-bcbe68d0f58c"),
                    ModifiedUserId = new Guid("3d1f9f41-8ac9-4c36-b85f-bcbe68d0f58c")
                },
                new Card
                {
                    Id = 10,
                    DeckId = 3,
                    Question = "What is dependency injection?",
                    Answer = "Dependency injection is a technique for achieving Inversion of Control between classes and their dependencies.",
                    SortOrder = 5,
                    QuestionClarifier = "It helps in making components more decoupled.",
                    AnswerClarifier = "ASP.NET Core has built-in support for dependency injection.",
                    QuestionFootnote = "It promotes testability.",
                    AnswerFootnote = "It reduces class dependencies.",
                    CreatedUserId = new Guid("3d1f9f41-8ac9-4c36-b85f-bcbe68d0f58c"),
                    ModifiedUserId = new Guid("3d1f9f41-8ac9-4c36-b85f-bcbe68d0f58c")
                },

                // Deck 3: Card examples for TailwindCSS
                new Card
                {
                    Id = 11,
                    DeckId = 5,
                    Question = "What is Tailwind CSS?",
                    Answer = "Tailwind CSS is a utility-first CSS framework for rapid UI development.",
                    SortOrder = 1,
                    QuestionClarifier = "It enables developers to design directly in their markup.",
                    AnswerClarifier = "Tailwind promotes a different workflow compared to traditional CSS.",
                    QuestionFootnote = "It is customizable through configuration.",
                    AnswerFootnote = "Tailwind's utility classes help in avoiding CSS bloat.",
                    CreatedUserId = new Guid("bb7be635-3f9e-4af2-96d1-f232a717b39e"), // Owner
                    ModifiedUserId = new Guid("bb7be635-3f9e-4af2-96d1-f232a717b39e")
                },
                new Card
                {
                    Id = 12,
                    DeckId = 5,
                    Question = "How to install Tailwind CSS?",
                    Answer = "You can install Tailwind CSS via npm, yarn, or by including a CDN in your HTML.",
                    SortOrder = 2,
                    QuestionClarifier = "Using npm is the most common method.",
                    AnswerClarifier = "Make sure to set up a build process for purging unused styles.",
                    QuestionFootnote = "Install Tailwind with npm by running `npm install tailwindcss`.",
                    AnswerFootnote = "A CDN link is available for quick setup.",
                    CreatedUserId = new Guid("bb7be635-3f9e-4af2-96d1-f232a717b39e"),
                    ModifiedUserId = new Guid("bb7be635-3f9e-4af2-96d1-f232a717b39e")
                },
                new Card
                {
                    Id = 13,
                    DeckId = 5,
                    Question = "What are utility classes?",
                    Answer = "Utility classes are single-purpose classes that apply one specific style.",
                    SortOrder = 3,
                    QuestionClarifier = "They help in creating designs without writing custom CSS.",
                    AnswerClarifier = "Each utility class has a specific function.",
                    QuestionFootnote = "Utility classes are prefixed with relevant property names.",
                    AnswerFootnote = "They can be combined to create complex designs.",
                    CreatedUserId = new Guid("bb7be635-3f9e-4af2-96d1-f232a717b39e"),
                    ModifiedUserId = new Guid("bb7be635-3f9e-4af2-96d1-f232a717b39e")
                },
                new Card
                {
                    Id = 14,
                    DeckId = 5,
                    Question = "What is the purpose of Tailwind's configuration file?",
                    Answer = "The configuration file allows customization of the default Tailwind styles.",
                    SortOrder = 4,
                    QuestionClarifier = "You can define your own colors, fonts, and breakpoints.",
                    AnswerClarifier = "It is essential for theming.",
                    QuestionFootnote = "The file is usually named `tailwind.config.js`.",
                    AnswerFootnote = "Configuration helps in optimizing the build.",
                    CreatedUserId = new Guid("bb7be635-3f9e-4af2-96d1-f232a717b39e"),
                    ModifiedUserId = new Guid("bb7be635-3f9e-4af2-96d1-f232a717b39e")
                },
                new Card
                {
                    Id = 15,
                    DeckId = 5,
                    Question = "How to purge unused styles?",
                    Answer = "To purge unused styles, configure the `purge` option in the Tailwind config file.",
                    SortOrder = 5,
                    QuestionClarifier = "This step reduces file size for production.",
                    AnswerClarifier = "Purge CSS scans your templates for classes.",
                    QuestionFootnote = "Set up your purge options in `tailwind.config.js`.",
                    AnswerFootnote = "Use the `NODE_ENV` variable to control the purge in production.",
                    CreatedUserId = new Guid("bb7be635-3f9e-4af2-96d1-f232a717b39e"),
                    ModifiedUserId = new Guid("bb7be635-3f9e-4af2-96d1-f232a717b39e")
                });
        }
    }
}
