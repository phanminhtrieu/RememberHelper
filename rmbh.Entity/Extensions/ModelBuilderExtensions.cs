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
                new User() { Id = new Guid("4b6519a1-21ae-44b7-874a-0da82c60ad59"), Email = "duc@gmail.com", FirstName = "Pham", LastName = "Van Duc", Password = "123456", Role = UserRole.User },
                new User() { Id = new Guid("b2e1073e-5c78-4bbf-9a23-0d3a799a4f81"), Email = "vana@gmail.com", FirstName = "Nguyen", LastName = "Van A", Password = "123456", Role = UserRole.User },
                new User() { Id = new Guid("d5c1b63d-cd34-47a6-9d18-9b0c5e457d2f"), Email = "thib@gmail.com", FirstName = "Tran", LastName = "Thi B", Password = "123456", Role = UserRole.User },
                new User() { Id = new Guid("9b12349d-16b4-43fc-945c-b1632f0bcbb1"), Email = "tranv@gmail.com", FirstName = "Tran", LastName = "Van C", Password = "123456", Role = UserRole.User },
                new User() { Id = new Guid("f12b876c-0e2d-4d39-b878-4d5b45e93557"), Email = "lehoang@gmail.com", FirstName = "Le", LastName = "Hoang D", Password = "123456", Role = UserRole.User },
                new User() { Id = new Guid("22c115dd-c912-4fb2-8d57-037d89e4b5e4"), Email = "phamngoc@gmail.com", FirstName = "Pham", LastName = "Ngoc E", Password = "123456", Role = UserRole.User },
                new User() { Id = new Guid("5e5a20e3-3a49-48fc-8e7a-14d476403e94"), Email = "nguyenkim@gmail.com", FirstName = "Nguyen", LastName = "Kim F", Password = "123456", Role = UserRole.User },
                new User() { Id = new Guid("ff127b02-7f94-4ebd-8d99-91e69f4ab6ba"), Email = "truongtuan@gmail.com", FirstName = "Truong", LastName = "Tuan G", Password = "123456", Role = UserRole.User },
                new User() { Id = new Guid("3d1f9f41-8ac9-4c36-b85f-bcbe68d0f58c"), Email = "vominh@gmail.com", FirstName = "Vo", LastName = "Minh H", Password = "123456", Role = UserRole.User },
                new User() { Id = new Guid("f8d170a5-02f7-4ff4-8c12-4eb83451fcd6"), Email = "lamthanh@gmail.com", FirstName = "Lam", LastName = "Thanh I", Password = "123456", Role = UserRole.User },
                new User() { Id = new Guid("7d3e98b2-8825-476e-b230-63a7d8d6500b"), Email = "ngochai@gmail.com", FirstName = "Ngo", LastName = "Hai J", Password = "123456", Role = UserRole.User },
                new User() { Id = new Guid("139fcb97-bd85-4ee0-9849-cb77aeaa67da"), Email = "phamnhung@gmail.com", FirstName = "Pham", LastName = "Nhung K", Password = "123456", Role = UserRole.User },
                new User() { Id = new Guid("2a9ffb7d-89fd-4784-b7eb-1a1245d30ae6"), Email = "doviet@gmail.com", FirstName = "Do", LastName = "Viet L", Password = "123456", Role = UserRole.User },
                new User() { Id = new Guid("5afbead9-e4a2-4e34-8eb9-ec9989ac31b5"), Email = "leminh@gmail.com", FirstName = "Le", LastName = "Minh M", Password = "123456", Role = UserRole.User },
                new User() { Id = new Guid("8ad18a18-2e0a-44a3-8898-ff2da1e6e6a4"), Email = "dangquan@gmail.com", FirstName = "Dang", LastName = "Quan N", Password = "123456", Role = UserRole.User },
                new User() { Id = new Guid("995dd243-3d72-44fc-b8f6-dfe9b1f4abaf"), Email = "buihieu@gmail.com", FirstName = "Bui", LastName = "Hieu O", Password = "123456", Role = UserRole.User },
                new User() { Id = new Guid("bb7be635-3f9e-4af2-96d1-f232a717b39e"), Email = "truonganh@gmail.com", FirstName = "Truong", LastName = "Anh P", Password = "123456", Role = UserRole.User },
                new User() { Id = new Guid("cb00a417-417f-4d69-9ad1-e9c04e4f3d11"), Email = "danghoa@gmail.com", FirstName = "Dang", LastName = "Hoa Q", Password = "123456", Role = UserRole.User },
                new User() { Id = new Guid("deb20833-0427-4520-b0b9-2916b5d42d91"), Email = "ngothanh@gmail.com", FirstName = "Ngo", LastName = "Thanh R", Password = "123456", Role = UserRole.User },
                new User() { Id = new Guid("1b8df37b-80cf-4182-8cc9-12de166b46e2"), Email = "phuocnam@gmail.com", FirstName = "Phuoc", LastName = "Nam S", Password = "123456", Role = UserRole.User },
                new User() { Id = new Guid("237b98a8-9d2c-4dd7-8058-06a7c4909a6d"), Email = "lehong@gmail.com", FirstName = "Le", LastName = "Hong T", Password = "123456", Role = UserRole.User },
                new User() { Id = new Guid("c876965b-b849-4f4b-b1ae-4c78e5f9b3df"), Email = "nguyenanh@gmail.com", FirstName = "Nguyen", LastName = "Anh U", Password = "123456", Role = UserRole.User }
                );

            //// Teams
            modelBuilder.Entity<Team>().HasData(
                new Team() { Id = 1, Name = "Happy Dogs", Description = "A team of passionate individuals who love working together to bring joy. They believe that happiness can be shared like a wagging tail.", Status = TeamStatus.Active },
                new Team() { Id = 2, Name = "Tech Titans", Description = "Known for their cutting-edge tech skills, this team constantly pushes the boundaries. Their innovative solutions have earned them a strong reputation.", Status = TeamStatus.Active },
                new Team() { Id = 3, Name = "Creative Minds", Description = "This team thrives on creativity and fresh ideas. Their collaborative spirit often leads to groundbreaking projects that challenge the norm.", Status = TeamStatus.Active },
                new Team() { Id = 4, Name = "Visionary Owls", Description = "Focused on foresight and strategic planning, they tackle challenges with wisdom. The team is recognized for turning complex visions into actionable plans.", Status = TeamStatus.Inactive },
                new Team() { Id = 5, Name = "Innovative Sparks", Description = "Always coming up with new ideas, this team never runs out of creativity. They believe that every spark of innovation leads to bigger opportunities.", Status = TeamStatus.Active },
                new Team() { Id = 6, Name = "Trailblazers", Description = "Leading the way in uncharted territories, this team loves challenges. They are fearless in pursuing new paths and setting trends.", Status = TeamStatus.Active },
                new Team() { Id = 7, Name = "Dynamic Achievers", Description = "The team's energy and drive are contagious. They consistently exceed expectations, achieving dynamic results in every project.", Status = TeamStatus.Banned },
                new Team() { Id = 8, Name = "Strategic Pioneers", Description = "This team is known for their strategic insight and leadership. They navigate through tough situations with calculated moves, always a step ahead.", Status = TeamStatus.Active }
                );

            //// UserTeams
            modelBuilder.Entity<UserTeam>().HasData(
                // Team 1
                new UserTeam() { Id = 1, UserId = new Guid("4b6519a1-21ae-44b7-874a-0da82c60ad59"), TeamId = 1, JoinedDate = CURRENT_DATE, Role = TeamRole.Admin },
                new UserTeam() { Id = 2, UserId = new Guid("b2e1073e-5c78-4bbf-9a23-0d3a799a4f81"), TeamId = 1, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 3, UserId = new Guid("d5c1b63d-cd34-47a6-9d18-9b0c5e457d2f"), TeamId = 1, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 4, UserId = new Guid("9b12349d-16b4-43fc-945c-b1632f0bcbb1"), TeamId = 1, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 5, UserId = new Guid("f12b876c-0e2d-4d39-b878-4d5b45e93557"), TeamId = 1, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 6, UserId = new Guid("22c115dd-c912-4fb2-8d57-037d89e4b5e4"), TeamId = 1, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 7, UserId = new Guid("5e5a20e3-3a49-48fc-8e7a-14d476403e94"), TeamId = 1, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 8, UserId = new Guid("ff127b02-7f94-4ebd-8d99-91e69f4ab6ba"), TeamId = 1, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 9, UserId = new Guid("3d1f9f41-8ac9-4c36-b85f-bcbe68d0f58c"), TeamId = 1, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 10, UserId = new Guid("f8d170a5-02f7-4ff4-8c12-4eb83451fcd6"), TeamId = 1, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },

                // Team 2
                new UserTeam() { Id = 11, UserId = new Guid("7d3e98b2-8825-476e-b230-63a7d8d6500b"), TeamId = 2, JoinedDate = CURRENT_DATE, Role = TeamRole.Admin },
                new UserTeam() { Id = 12, UserId = new Guid("139fcb97-bd85-4ee0-9849-cb77aeaa67da"), TeamId = 2, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 13, UserId = new Guid("2a9ffb7d-89fd-4784-b7eb-1a1245d30ae6"), TeamId = 2, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 14, UserId = new Guid("5afbead9-e4a2-4e34-8eb9-ec9989ac31b5"), TeamId = 2, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 15, UserId = new Guid("8ad18a18-2e0a-44a3-8898-ff2da1e6e6a4"), TeamId = 2, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 16, UserId = new Guid("995dd243-3d72-44fc-b8f6-dfe9b1f4abaf"), TeamId = 2, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 17, UserId = new Guid("bb7be635-3f9e-4af2-96d1-f232a717b39e"), TeamId = 2, JoinedDate = CURRENT_DATE, Role = TeamRole.Viewer },
                new UserTeam() { Id = 18, UserId = new Guid("cb00a417-417f-4d69-9ad1-e9c04e4f3d11"), TeamId = 2, JoinedDate = CURRENT_DATE, Role = TeamRole.Viewer },
                new UserTeam() { Id = 19, UserId = new Guid("deb20833-0427-4520-b0b9-2916b5d42d91"), TeamId = 2, JoinedDate = CURRENT_DATE, Role = TeamRole.Viewer },
                new UserTeam() { Id = 20, UserId = new Guid("1b8df37b-80cf-4182-8cc9-12de166b46e2"), TeamId = 2, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },

                // Team 3
                new UserTeam() { Id = 21, UserId = new Guid("237b98a8-9d2c-4dd7-8058-06a7c4909a6d"), TeamId = 3, JoinedDate = CURRENT_DATE, Role = TeamRole.Admin },
                new UserTeam() { Id = 23, UserId = new Guid("c876965b-b849-4f4b-b1ae-4c78e5f9b3df"), TeamId = 3, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 24, UserId = new Guid("4b6519a1-21ae-44b7-874a-0da82c60ad59"), TeamId = 3, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 25, UserId = new Guid("b2e1073e-5c78-4bbf-9a23-0d3a799a4f81"), TeamId = 3, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 26, UserId = new Guid("d5c1b63d-cd34-47a6-9d18-9b0c5e457d2f"), TeamId = 3, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 27, UserId = new Guid("9b12349d-16b4-43fc-945c-b1632f0bcbb1"), TeamId = 3, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 28, UserId = new Guid("f12b876c-0e2d-4d39-b878-4d5b45e93557"), TeamId = 3, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 29, UserId = new Guid("22c115dd-c912-4fb2-8d57-037d89e4b5e4"), TeamId = 3, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 30, UserId = new Guid("5e5a20e3-3a49-48fc-8e7a-14d476403e94"), TeamId = 3, JoinedDate = CURRENT_DATE, Role = TeamRole.Viewer },

                // Team 4
                new UserTeam() { Id = 31, UserId = new Guid("ff127b02-7f94-4ebd-8d99-91e69f4ab6ba"), TeamId = 4, JoinedDate = CURRENT_DATE, Role = TeamRole.Admin },
                new UserTeam() { Id = 32, UserId = new Guid("3d1f9f41-8ac9-4c36-b85f-bcbe68d0f58c"), TeamId = 4, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 33, UserId = new Guid("f8d170a5-02f7-4ff4-8c12-4eb83451fcd6"), TeamId = 4, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 34, UserId = new Guid("7d3e98b2-8825-476e-b230-63a7d8d6500b"), TeamId = 4, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 35, UserId = new Guid("139fcb97-bd85-4ee0-9849-cb77aeaa67da"), TeamId = 4, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 36, UserId = new Guid("2a9ffb7d-89fd-4784-b7eb-1a1245d30ae6"), TeamId = 4, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 37, UserId = new Guid("5afbead9-e4a2-4e34-8eb9-ec9989ac31b5"), TeamId = 4, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 38, UserId = new Guid("8ad18a18-2e0a-44a3-8898-ff2da1e6e6a4"), TeamId = 4, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 39, UserId = new Guid("995dd243-3d72-44fc-b8f6-dfe9b1f4abaf"), TeamId = 4, JoinedDate = CURRENT_DATE, Role = TeamRole.Viewer },
                new UserTeam() { Id = 40, UserId = new Guid("bb7be635-3f9e-4af2-96d1-f232a717b39e"), TeamId = 4, JoinedDate = CURRENT_DATE, Role = TeamRole.Viewer },

                // Team 5
                new UserTeam() { Id = 41, UserId = new Guid("cb00a417-417f-4d69-9ad1-e9c04e4f3d11"), TeamId = 5, JoinedDate = CURRENT_DATE, Role = TeamRole.Admin },
                new UserTeam() { Id = 42, UserId = new Guid("deb20833-0427-4520-b0b9-2916b5d42d91"), TeamId = 5, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 43, UserId = new Guid("1b8df37b-80cf-4182-8cc9-12de166b46e2"), TeamId = 5, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 44, UserId = new Guid("237b98a8-9d2c-4dd7-8058-06a7c4909a6d"), TeamId = 5, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 46, UserId = new Guid("c876965b-b849-4f4b-b1ae-4c78e5f9b3df"), TeamId = 5, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 47, UserId = new Guid("4b6519a1-21ae-44b7-874a-0da82c60ad59"), TeamId = 5, JoinedDate = CURRENT_DATE, Role = TeamRole.Viewer },
                new UserTeam() { Id = 48, UserId = new Guid("b2e1073e-5c78-4bbf-9a23-0d3a799a4f81"), TeamId = 5, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 49, UserId = new Guid("d5c1b63d-cd34-47a6-9d18-9b0c5e457d2f"), TeamId = 5, JoinedDate = CURRENT_DATE, Role = TeamRole.Viewer },
                new UserTeam() { Id = 50, UserId = new Guid("9b12349d-16b4-43fc-945c-b1632f0bcbb1"), TeamId = 5, JoinedDate = CURRENT_DATE, Role = TeamRole.Viewer },

                // Team 6
                new UserTeam() { Id = 51, UserId = new Guid("f12b876c-0e2d-4d39-b878-4d5b45e93557"), TeamId = 6, JoinedDate = CURRENT_DATE, Role = TeamRole.Admin },
                new UserTeam() { Id = 52, UserId = new Guid("22c115dd-c912-4fb2-8d57-037d89e4b5e4"), TeamId = 6, JoinedDate = CURRENT_DATE, Role = TeamRole.Viewer },
                new UserTeam() { Id = 53, UserId = new Guid("5e5a20e3-3a49-48fc-8e7a-14d476403e94"), TeamId = 6, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 54, UserId = new Guid("ff127b02-7f94-4ebd-8d99-91e69f4ab6ba"), TeamId = 6, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 55, UserId = new Guid("3d1f9f41-8ac9-4c36-b85f-bcbe68d0f58c"), TeamId = 6, JoinedDate = CURRENT_DATE, Role = TeamRole.Viewer },
                new UserTeam() { Id = 56, UserId = new Guid("f8d170a5-02f7-4ff4-8c12-4eb83451fcd6"), TeamId = 6, JoinedDate = CURRENT_DATE, Role = TeamRole.Viewer },
                new UserTeam() { Id = 57, UserId = new Guid("7d3e98b2-8825-476e-b230-63a7d8d6500b"), TeamId = 6, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 58, UserId = new Guid("139fcb97-bd85-4ee0-9849-cb77aeaa67da"), TeamId = 6, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 59, UserId = new Guid("2a9ffb7d-89fd-4784-b7eb-1a1245d30ae6"), TeamId = 6, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 60, UserId = new Guid("5afbead9-e4a2-4e34-8eb9-ec9989ac31b5"), TeamId = 6, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },

                // Team 7
                new UserTeam() { Id = 61, UserId = new Guid("8ad18a18-2e0a-44a3-8898-ff2da1e6e6a4"), TeamId = 7, JoinedDate = CURRENT_DATE, Role = TeamRole.Admin },
                new UserTeam() { Id = 62, UserId = new Guid("995dd243-3d72-44fc-b8f6-dfe9b1f4abaf"), TeamId = 7, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 63, UserId = new Guid("bb7be635-3f9e-4af2-96d1-f232a717b39e"), TeamId = 7, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 64, UserId = new Guid("cb00a417-417f-4d69-9ad1-e9c04e4f3d11"), TeamId = 7, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 65, UserId = new Guid("deb20833-0427-4520-b0b9-2916b5d42d91"), TeamId = 7, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 66, UserId = new Guid("1b8df37b-80cf-4182-8cc9-12de166b46e2"), TeamId = 7, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 67, UserId = new Guid("237b98a8-9d2c-4dd7-8058-06a7c4909a6d"), TeamId = 7, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 69, UserId = new Guid("c876965b-b849-4f4b-b1ae-4c78e5f9b3df"), TeamId = 7, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 70, UserId = new Guid("4b6519a1-21ae-44b7-874a-0da82c60ad59"), TeamId = 7, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },

                // Team 8
                new UserTeam() { Id = 71, UserId = new Guid("b2e1073e-5c78-4bbf-9a23-0d3a799a4f81"), TeamId = 8, JoinedDate = CURRENT_DATE, Role = TeamRole.Admin },
                new UserTeam() { Id = 72, UserId = new Guid("d5c1b63d-cd34-47a6-9d18-9b0c5e457d2f"), TeamId = 8, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 73, UserId = new Guid("9b12349d-16b4-43fc-945c-b1632f0bcbb1"), TeamId = 8, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 74, UserId = new Guid("f12b876c-0e2d-4d39-b878-4d5b45e93557"), TeamId = 8, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 75, UserId = new Guid("22c115dd-c912-4fb2-8d57-037d89e4b5e4"), TeamId = 8, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 76, UserId = new Guid("5e5a20e3-3a49-48fc-8e7a-14d476403e94"), TeamId = 8, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 77, UserId = new Guid("ff127b02-7f94-4ebd-8d99-91e69f4ab6ba"), TeamId = 8, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 78, UserId = new Guid("3d1f9f41-8ac9-4c36-b85f-bcbe68d0f58c"), TeamId = 8, JoinedDate = CURRENT_DATE, Role = TeamRole.Member },
                new UserTeam() { Id = 79, UserId = new Guid("f8d170a5-02f7-4ff4-8c12-4eb83451fcd6"), TeamId = 8, JoinedDate = CURRENT_DATE, Role = TeamRole.Member }
                );

            //// Classes
            modelBuilder.Entity<Class>().HasData(
                new Class() 
                { 
                    Id = 1, 
                    Name = "ReactJS", 
                    Description = "ReactJS is a JavaScript library by Facebook for building interactive user interfaces with reusable components. Students will learn concepts like JSX and component lifecycle, enhancing their ability to create efficient applications.", 
                    HeadlineAbout = "Build Dynamic User Interfaces with ReactJS", 
                    DescriptionAbout = "ReactJS is a powerful JavaScript library developed by Facebook, designed for creating interactive and efficient user interfaces. By learning React, students will master reusable components and key concepts like JSX and component lifecycle, equipping them to develop modern web applications.", 
                    Visibility = ClassVisibility.Public, 
                    DefaultStudyMixType = DefaultStudyMixType.Random, 
                    CreatedUserId = new Guid("f8d170a5-02f7-4ff4-8c12-4eb83451fcd6"),
                    ModifiedUserId = new Guid("f8d170a5-02f7-4ff4-8c12-4eb83451fcd6"),
                    CreatedDate = CURRENT_DATE, 
                    ModifiedDate = CURRENT_DATE
                },
                new Class() 
                { 
                    Id = 2, 
                    Name = "ASP.NET Core .MVC", 
                    Description = "ASP.NET Core .MVC is a Microsoft framework that uses the Model-View-Controller (.MVC) pattern to separate application logic from user interface. Students will learn to build APIs and manage data with Entity Framework Core while ensuring application security.", 
                    HeadlineAbout = "Develop Robust Web Applications with ASP.NET Core .MVC", 
                    DescriptionAbout = "ASP.NET Core .MVC is a versatile framework from Microsoft that follows the Model-View-Controller (.MVC) pattern to streamline web application development. Students will learn to create APIs, manage data using Entity Framework Core, and implement security features, ensuring their applications are both functional and secure.", 
                    Visibility = ClassVisibility.Public, 
                    DefaultStudyMixType = DefaultStudyMixType.Progressive,
                    CreatedUserId = new Guid("995dd243-3d72-44fc-b8f6-dfe9b1f4abaf"),
                    ModifiedUserId = new Guid("995dd243-3d72-44fc-b8f6-dfe9b1f4abaf"),
                    CreatedDate = CURRENT_DATE, 
                    ModifiedDate = CURRENT_DATE 
                },
                new Class() 
                { 
                    Id = 3, 
                    Name = "TailwindCSS", 
                    Description = "Tailwind CSS is a utility-first framework that allows for rapid and flexible UI design using utility classes. Students will discover how to integrate it into projects and customize layouts efficiently.", 
                    HeadlineAbout = "Design Stunning User Interfaces with Tailwind CSS", 
                    DescriptionAbout = "Tailwind CSS is a utility-first framework that accelerates UI design by enabling developers to use pre-defined utility classes. Students will explore how to quickly integrate Tailwind into their projects, customize layouts, and create visually appealing interfaces with ease.", 
                    Visibility = ClassVisibility.Private, 
                    DefaultStudyMixType = DefaultStudyMixType.Progressive,
                    CreatedUserId = new Guid("cb00a417-417f-4d69-9ad1-e9c04e4f3d11"),
                    ModifiedUserId = new Guid("cb00a417-417f-4d69-9ad1-e9c04e4f3d11"),
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
