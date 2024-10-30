using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rmbh.Entity.Migrations
{
    public partial class InitialAppDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Visibility = table.Column<int>(type: "int", nullable: false),
                    LastLearningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Avatar = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Decks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    StudyDeckType = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Decks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Decks_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserClasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    JoinedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeSpent = table.Column<long>(type: "bigint", nullable: true),
                    MasteryScore = table.Column<int>(type: "int", nullable: true),
                    LastLearningDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClasses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClasses_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserClasses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionImg = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    AnswerImg = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    QuestionClarifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnswerClarifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionFootnote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnswerFootnote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeckId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cards_Decks_DeckId",
                        column: x => x.DeckId,
                        principalTable: "Decks",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserDeckStatistic",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeSpent = table.Column<long>(type: "bigint", nullable: true),
                    MasteryScore = table.Column<int>(type: "int", nullable: true),
                    Day = table.Column<int>(type: "int", nullable: true),
                    Month = table.Column<int>(type: "int", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeckId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDeckStatistic", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserDeckStatistic_Decks_DeckId",
                        column: x => x.DeckId,
                        principalTable: "Decks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDeckStatistic_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserCardStatistic",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeSpent = table.Column<long>(type: "bigint", nullable: true),
                    MasteryScore = table.Column<int>(type: "int", nullable: true),
                    Day = table.Column<int>(type: "int", nullable: true),
                    Month = table.Column<int>(type: "int", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCardStatistic", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserCardStatistic_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserCardStatistic_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "CreatedDate", "Description", "LastLearningDate", "Logo", "ModifiedDate", "Title", "Visibility" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "ReactJS is a JavaScript library by Facebook for building interactive user interfaces with reusable components. Students will learn concepts like JSX and component lifecycle, enhancing their ability to create efficient applications.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "ReactJS", 2 },
                    { 2, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "ASP.NET Core MVC is a Microsoft framework that uses the Model-View-Controller (MVC) pattern to separate application logic from user interface. Students will learn to build APIs and manage data with Entity Framework Core while ensuring application security.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "ASP.NET Core MVC", 1 },
                    { 3, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "Tailwind CSS is a utility-first framework that allows for rapid and flexible UI design using utility classes. Students will discover how to integrate it into projects and customize layouts efficiently.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "TailwindCSS", 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Avatar", "Bio", "CreatedDate", "Email", "FirstName", "LastName", "ModifiedDate", "Password", "Role" },
                values: new object[,]
                {
                    { new Guid("0a647a8e-eeaf-4d96-8263-566cb883c994"), null, null, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "hoa@gmail.com", "Pham", "Minh Hoa", new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "123456", 1 },
                    { new Guid("139fcb97-bd85-4ee0-9849-cb77aeaa67da"), null, null, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "phamnhung@gmail.com", "Pham", "Nhung K", new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "123456", 2 },
                    { new Guid("1b8df37b-80cf-4182-8cc9-12de166b46e2"), null, null, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "phuocnam@gmail.com", "Phuoc", "Nam S", new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "123456", 2 },
                    { new Guid("22c115dd-c912-4fb2-8d57-037d89e4b5e4"), null, null, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "phamngoc@gmail.com", "Pham", "Ngoc E", new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "123456", 2 },
                    { new Guid("237b98a8-9d2c-4dd7-8058-06a7c4909a6d"), null, null, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "lehong@gmail.com", "Le", "Hong T", new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "123456", 2 },
                    { new Guid("2a9ffb7d-89fd-4784-b7eb-1a1245d30ae6"), null, null, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "doviet@gmail.com", "Do", "Viet L", new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "123456", 2 },
                    { new Guid("3d1f9f41-8ac9-4c36-b85f-bcbe68d0f58c"), null, null, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "vominh@gmail.com", "Vo", "Minh H", new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "123456", 2 },
                    { new Guid("4b6519a1-21ae-44b7-874a-0da82c60ad59"), null, null, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "duc@gmail.com", "Pham", "Van Duc", new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "123456", 2 },
                    { new Guid("5afbead9-e4a2-4e34-8eb9-ec9989ac31b5"), null, null, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "leminh@gmail.com", "Le", "Minh M", new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "123456", 2 },
                    { new Guid("5e5a20e3-3a49-48fc-8e7a-14d476403e94"), null, null, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "nguyenkim@gmail.com", "Nguyen", "Kim F", new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "123456", 2 },
                    { new Guid("701e1774-9993-44fe-b377-aae0f51e0231"), null, null, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "trieu@gmail.com", "Phan", "Minh Trieu", new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "123456", 1 },
                    { new Guid("7d3e98b2-8825-476e-b230-63a7d8d6500b"), null, null, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "ngochai@gmail.com", "Ngo", "Hai J", new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "123456", 2 },
                    { new Guid("8ad18a18-2e0a-44a3-8898-ff2da1e6e6a4"), null, null, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "dangquan@gmail.com", "Dang", "Quan N", new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "123456", 2 },
                    { new Guid("995dd243-3d72-44fc-b8f6-dfe9b1f4abaf"), null, null, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "buihieu@gmail.com", "Bui", "Hieu O", new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "123456", 2 },
                    { new Guid("9b12349d-16b4-43fc-945c-b1632f0bcbb1"), null, null, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "tranv@gmail.com", "Tran", "Van C", new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "123456", 2 },
                    { new Guid("9c0de9d9-1022-419e-9828-e8c7cc6e77c7"), null, null, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "van@gmail.com", "Nguyen", "Ngoc Khanh Van", new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "123456", 1 },
                    { new Guid("b2e1073e-5c78-4bbf-9a23-0d3a799a4f81"), null, null, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "vana@gmail.com", "Nguyen", "Van A", new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "123456", 2 },
                    { new Guid("bb7be635-3f9e-4af2-96d1-f232a717b39e"), null, null, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "truonganh@gmail.com", "Truong", "Anh P", new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "123456", 2 },
                    { new Guid("c876965b-b849-4f4b-b1ae-4c78e5f9b3df"), null, null, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "nguyenanh@gmail.com", "Nguyen", "Anh U", new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "123456", 2 },
                    { new Guid("cb00a417-417f-4d69-9ad1-e9c04e4f3d11"), null, null, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "danghoa@gmail.com", "Dang", "Hoa Q", new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "123456", 2 },
                    { new Guid("d5c1b63d-cd34-47a6-9d18-9b0c5e457d2f"), null, null, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "thib@gmail.com", "Tran", "Thi B", new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "123456", 2 },
                    { new Guid("deb20833-0427-4520-b0b9-2916b5d42d91"), null, null, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "ngothanh@gmail.com", "Ngo", "Thanh R", new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "123456", 2 },
                    { new Guid("f12b876c-0e2d-4d39-b878-4d5b45e93557"), null, null, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "lehoang@gmail.com", "Le", "Hoang D", new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "123456", 2 },
                    { new Guid("f8d170a5-02f7-4ff4-8c12-4eb83451fcd6"), null, null, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "lamthanh@gmail.com", "Lam", "Thanh I", new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "123456", 2 },
                    { new Guid("ff127b02-7f94-4ebd-8d99-91e69f4ab6ba"), null, null, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "truongtuan@gmail.com", "Truong", "Tuan G", new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1730), "123456", 2 }
                });

            migrationBuilder.InsertData(
                table: "Decks",
                columns: new[] { "Id", "ClassId", "CreatedDate", "Description", "ModifiedDate", "SortOrder", "StudyDeckType", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(2178), "This deck covers the fundamental concepts of React, including components, props, and state management.", new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(2179), 1, 2, "React Basics" },
                    { 2, 1, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(2181), "Explore advanced patterns in React such as Higher-Order Components, Render Props, and Context API.", new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(2181), 2, 1, "Advanced React Patterns" },
                    { 3, 2, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(2182), "Learn the basics of ASP.NET Core, including routing, middleware, and dependency injection.", new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(2183), 1, 2, "ASP.NET Core Fundamentals" },
                    { 4, 2, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(2184), "This deck focuses on creating RESTful APIs using ASP.NET Core MVC and Entity Framework.", new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(2184), 2, 1, "Building REST APIs" },
                    { 5, 3, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(2185), "Discover the utility-first approach to CSS with TailwindCSS and how to get started with it.", new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(2186), 1, 2, "Introduction to TailwindCSS" },
                    { 6, 3, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(2187), "Learn advanced techniques in TailwindCSS for customizing designs and improving workflow.", new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(2187), 2, 1, "Advanced Tailwind Techniques" }
                });

            migrationBuilder.InsertData(
                table: "UserClasses",
                columns: new[] { "Id", "ClassId", "JoinedDate", "LastLearningDate", "MasteryScore", "Role", "TimeSpent", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1970), new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1971), 2, 1, 320L, new Guid("4b6519a1-21ae-44b7-874a-0da82c60ad59") },
                    { 2, 1, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1973), new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1973), 1, 2, 275L, new Guid("b2e1073e-5c78-4bbf-9a23-0d3a799a4f81") },
                    { 3, 1, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1975), new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1975), 5, 2, 150L, new Guid("d5c1b63d-cd34-47a6-9d18-9b0c5e457d2f") },
                    { 4, 1, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1976), new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1977), 5, 2, 480L, new Guid("9b12349d-16b4-43fc-945c-b1632f0bcbb1") },
                    { 5, 1, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1978), new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1979), 5, 2, 200L, new Guid("f12b876c-0e2d-4d39-b878-4d5b45e93557") },
                    { 6, 1, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1980), new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1981), 5, 2, 360L, new Guid("22c115dd-c912-4fb2-8d57-037d89e4b5e4") },
                    { 7, 1, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1982), new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1982), 1, 2, 110L, new Guid("5e5a20e3-3a49-48fc-8e7a-14d476403e94") },
                    { 8, 1, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1984), new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1984), 4, 2, 430L, new Guid("ff127b02-7f94-4ebd-8d99-91e69f4ab6ba") },
                    { 9, 2, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1985), new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1986), 5, 1, 120L, new Guid("3d1f9f41-8ac9-4c36-b85f-bcbe68d0f58c") },
                    { 10, 2, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1987), new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1988), 5, 2, 290L, new Guid("f8d170a5-02f7-4ff4-8c12-4eb83451fcd6") },
                    { 11, 2, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1989), new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1989), 5, 2, 240L, new Guid("7d3e98b2-8825-476e-b230-63a7d8d6500b") },
                    { 12, 2, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1990), new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1991), 5, 2, 310L, new Guid("139fcb97-bd85-4ee0-9849-cb77aeaa67da") },
                    { 13, 2, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1992), new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1992), 5, 2, 405L, new Guid("2a9ffb7d-89fd-4784-b7eb-1a1245d30ae6") },
                    { 14, 2, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1993), new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(1994), 5, 2, 500L, new Guid("5afbead9-e4a2-4e34-8eb9-ec9989ac31b5") },
                    { 15, 2, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(2009), new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(2010), 5, 2, 370L, new Guid("8ad18a18-2e0a-44a3-8898-ff2da1e6e6a4") },
                    { 16, 2, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(2012), new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(2012), 5, 2, 180L, new Guid("995dd243-3d72-44fc-b8f6-dfe9b1f4abaf") },
                    { 17, 3, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(2014), new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(2015), 5, 1, 300L, new Guid("bb7be635-3f9e-4af2-96d1-f232a717b39e") },
                    { 18, 3, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(2016), new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(2016), 5, 2, 110L, new Guid("cb00a417-417f-4d69-9ad1-e9c04e4f3d11") },
                    { 19, 3, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(2017), new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(2018), 5, 2, 410L, new Guid("deb20833-0427-4520-b0b9-2916b5d42d91") },
                    { 20, 3, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(2019), new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(2020), 5, 2, 450L, new Guid("1b8df37b-80cf-4182-8cc9-12de166b46e2") },
                    { 21, 3, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(2021), new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(2021), 5, 2, 215L, new Guid("237b98a8-9d2c-4dd7-8058-06a7c4909a6d") },
                    { 22, 3, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(2023), new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(2023), 2, 2, 170L, new Guid("c876965b-b849-4f4b-b1ae-4c78e5f9b3df") },
                    { 23, 3, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(2024), new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(2025), 4, 2, 275L, new Guid("7d3e98b2-8825-476e-b230-63a7d8d6500b") },
                    { 24, 3, new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(2026), new DateTime(2024, 10, 30, 10, 29, 53, 958, DateTimeKind.Local).AddTicks(2027), 4, 2, 350L, new Guid("f8d170a5-02f7-4ff4-8c12-4eb83451fcd6") }
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Answer", "AnswerClarifier", "AnswerFootnote", "AnswerImg", "CreatedDate", "CreatedUserId", "DeckId", "ModifiedDate", "ModifiedUserId", "Question", "QuestionClarifier", "QuestionFootnote", "QuestionImg", "SortOrder" },
                values: new object[,]
                {
                    { 1, "JSX is a syntax extension for JavaScript that allows you to write HTML-like code within JavaScript.", "JSX gets compiled to JavaScript.", "JSX is not mandatory in React.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4b6519a1-21ae-44b7-874a-0da82c60ad59"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4b6519a1-21ae-44b7-874a-0da82c60ad59"), "What is JSX?", "It's commonly used with React.", "JSX can be confused with HTML.", null, 1 },
                    { 2, "Components are independent, reusable pieces of code that return a React element.", "Components can manage their own state.", "They enhance reusability.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4b6519a1-21ae-44b7-874a-0da82c60ad59"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4b6519a1-21ae-44b7-874a-0da82c60ad59"), "What are components?", "They can be functional or class-based.", "Components can be nested within each other.", null, 2 },
                    { 3, "State is an object that holds data about the component's current situation.", "State updates trigger re-renders.", "State should be updated using setState.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4b6519a1-21ae-44b7-874a-0da82c60ad59"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4b6519a1-21ae-44b7-874a-0da82c60ad59"), "What is state?", "State allows components to create dynamic and interactive applications.", "State is managed within the component.", null, 3 },
                    { 4, "Props are inputs to React components that allow data to be passed down from parent to child.", "They enable component communication.", "Props do not change inside the component.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4b6519a1-21ae-44b7-874a-0da82c60ad59"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4b6519a1-21ae-44b7-874a-0da82c60ad59"), "What is a prop?", "Props are read-only.", "Props can be any type of data.", null, 4 },
                    { 5, "Lifecycle methods are hooks that allow you to run code at specific points in a component's life.", "Common methods include componentDidMount and componentWillUnmount.", "Hooks offer similar functionality in functional components.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4b6519a1-21ae-44b7-874a-0da82c60ad59"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4b6519a1-21ae-44b7-874a-0da82c60ad59"), "What is a lifecycle method?", "They include mounting, updating, and unmounting.", "Lifecycle methods are specific to class components.", null, 5 },
                    { 6, "ASP.NET Core is a cross-platform framework for building modern cloud-based web applications.", "ASP.NET Core is designed for high performance.", "ASP.NET Core can run on Windows, macOS, and Linux.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3d1f9f41-8ac9-4c36-b85f-bcbe68d0f58c"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3d1f9f41-8ac9-4c36-b85f-bcbe68d0f58c"), "What is ASP.NET Core?", "It is an open-source framework.", "It supports microservices architecture.", null, 1 },
                    { 7, "MVC stands for Model-View-Controller, a pattern used to separate application logic from the user interface.", "MVC divides an application into three interconnected components.", "Controllers handle user input.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3d1f9f41-8ac9-4c36-b85f-bcbe68d0f58c"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3d1f9f41-8ac9-4c36-b85f-bcbe68d0f58c"), "What is the MVC pattern?", "It helps in organizing code and making it maintainable.", "Models represent the data.", null, 2 },
                    { 8, "Entity Framework Core is an ORM (Object-Relational Mapper) for .NET applications.", "EF Core simplifies data access.", "EF Core can be used with various databases.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3d1f9f41-8ac9-4c36-b85f-bcbe68d0f58c"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3d1f9f41-8ac9-4c36-b85f-bcbe68d0f58c"), "What is Entity Framework Core?", "It allows developers to work with a database using .NET objects.", "It supports LINQ queries.", null, 3 },
                    { 9, "Middleware is software that connects different applications or services.", "Middleware can perform operations on HTTP requests.", "Common middleware includes authentication and logging.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3d1f9f41-8ac9-4c36-b85f-bcbe68d0f58c"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3d1f9f41-8ac9-4c36-b85f-bcbe68d0f58c"), "What is middleware?", "In ASP.NET Core, middleware are components that are assembled into an application pipeline.", "Middleware can be added in the Configure method.", null, 4 },
                    { 10, "Dependency injection is a technique for achieving Inversion of Control between classes and their dependencies.", "ASP.NET Core has built-in support for dependency injection.", "It reduces class dependencies.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3d1f9f41-8ac9-4c36-b85f-bcbe68d0f58c"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3d1f9f41-8ac9-4c36-b85f-bcbe68d0f58c"), "What is dependency injection?", "It helps in making components more decoupled.", "It promotes testability.", null, 5 },
                    { 11, "Tailwind CSS is a utility-first CSS framework for rapid UI development.", "Tailwind promotes a different workflow compared to traditional CSS.", "Tailwind's utility classes help in avoiding CSS bloat.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bb7be635-3f9e-4af2-96d1-f232a717b39e"), 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bb7be635-3f9e-4af2-96d1-f232a717b39e"), "What is Tailwind CSS?", "It enables developers to design directly in their markup.", "It is customizable through configuration.", null, 1 },
                    { 12, "You can install Tailwind CSS via npm, yarn, or by including a CDN in your HTML.", "Make sure to set up a build process for purging unused styles.", "A CDN link is available for quick setup.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bb7be635-3f9e-4af2-96d1-f232a717b39e"), 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bb7be635-3f9e-4af2-96d1-f232a717b39e"), "How to install Tailwind CSS?", "Using npm is the most common method.", "Install Tailwind with npm by running `npm install tailwindcss`.", null, 2 },
                    { 13, "Utility classes are single-purpose classes that apply one specific style.", "Each utility class has a specific function.", "They can be combined to create complex designs.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bb7be635-3f9e-4af2-96d1-f232a717b39e"), 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bb7be635-3f9e-4af2-96d1-f232a717b39e"), "What are utility classes?", "They help in creating designs without writing custom CSS.", "Utility classes are prefixed with relevant property names.", null, 3 },
                    { 14, "The configuration file allows customization of the default Tailwind styles.", "It is essential for theming.", "Configuration helps in optimizing the build.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bb7be635-3f9e-4af2-96d1-f232a717b39e"), 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bb7be635-3f9e-4af2-96d1-f232a717b39e"), "What is the purpose of Tailwind's configuration file?", "You can define your own colors, fonts, and breakpoints.", "The file is usually named `tailwind.config.js`.", null, 4 },
                    { 15, "To purge unused styles, configure the `purge` option in the Tailwind config file.", "Purge CSS scans your templates for classes.", "Use the `NODE_ENV` variable to control the purge in production.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bb7be635-3f9e-4af2-96d1-f232a717b39e"), 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bb7be635-3f9e-4af2-96d1-f232a717b39e"), "How to purge unused styles?", "This step reduces file size for production.", "Set up your purge options in `tailwind.config.js`.", null, 5 }
                });

            migrationBuilder.InsertData(
                table: "UserDeckStatistic",
                columns: new[] { "Id", "Day", "DeckId", "MasteryScore", "Month", "Note", "TimeSpent", "UserId", "Year" },
                values: new object[,]
                {
                    { 1, 30, 1, 5, 10, "Completed all sections.", 120L, new Guid("4b6519a1-21ae-44b7-874a-0da82c60ad59"), 2024 },
                    { 2, 30, 1, 4, 10, "Struggled with some concepts.", 150L, new Guid("b2e1073e-5c78-4bbf-9a23-0d3a799a4f81"), 2024 },
                    { 3, 30, 1, 3, 10, "Basic understanding.", 180L, new Guid("d5c1b63d-cd34-47a6-9d18-9b0c5e457d2f"), 2024 },
                    { 4, 30, 2, 4, 10, "Learned some advanced patterns.", 200L, new Guid("9b12349d-16b4-43fc-945c-b1632f0bcbb1"), 2024 },
                    { 5, 30, 2, 2, 10, "Need more practice.", 220L, new Guid("f12b876c-0e2d-4d39-b878-4d5b45e93557"), 2024 },
                    { 6, 30, 2, 1, 10, "Very confused about the concepts.", 260L, new Guid("22c115dd-c912-4fb2-8d57-037d89e4b5e4"), 2024 },
                    { 7, 30, 2, 3, 10, "Moderate understanding.", 230L, new Guid("5e5a20e3-3a49-48fc-8e7a-14d476403e94"), 2024 },
                    { 8, 30, 2, 4, 10, "Good grasp on the subject.", 210L, new Guid("ff127b02-7f94-4ebd-8d99-91e69f4ab6ba"), 2024 },
                    { 9, 30, 3, 5, 10, "Mastered the fundamentals.", 140L, new Guid("3d1f9f41-8ac9-4c36-b85f-bcbe68d0f58c"), 2024 },
                    { 10, 30, 3, 4, 10, "Good understanding of routing.", 160L, new Guid("f8d170a5-02f7-4ff4-8c12-4eb83451fcd6"), 2024 },
                    { 11, 30, 3, 3, 10, "Basic grasp of middleware.", 180L, new Guid("7d3e98b2-8825-476e-b230-63a7d8d6500b"), 2024 },
                    { 12, 30, 4, 4, 10, "Successfully built an API.", 190L, new Guid("139fcb97-bd85-4ee0-9849-cb77aeaa67da"), 2024 },
                    { 13, 30, 4, 2, 10, "Still learning the API concepts.", 210L, new Guid("2a9ffb7d-89fd-4784-b7eb-1a1245d30ae6"), 2024 },
                    { 14, 30, 4, 1, 10, "Completely lost on this.", 220L, new Guid("5afbead9-e4a2-4e34-8eb9-ec9989ac31b5"), 2024 },
                    { 15, 30, 4, 3, 10, "Moderate understanding.", 200L, new Guid("8ad18a18-2e0a-44a3-8898-ff2da1e6e6a4"), 2024 },
                    { 16, 30, 4, 4, 10, "Good grasp on API building.", 230L, new Guid("995dd243-3d72-44fc-b8f6-dfe9b1f4abaf"), 2024 },
                    { 17, 30, 5, 5, 10, "Perfectly understood the utility-first approach.", 130L, new Guid("bb7be635-3f9e-4af2-96d1-f232a717b39e"), 2024 },
                    { 18, 30, 5, 4, 10, "Nice introduction to TailwindCSS.", 150L, new Guid("cb00a417-417f-4d69-9ad1-e9c04e4f3d11"), 2024 },
                    { 19, 30, 5, 3, 10, "Need to work more on customization.", 170L, new Guid("deb20833-0427-4520-b0b9-2916b5d42d91"), 2024 },
                    { 20, 30, 6, 4, 10, "Good start with the framework.", 190L, new Guid("1b8df37b-80cf-4182-8cc9-12de166b46e2"), 2024 },
                    { 21, 30, 6, 2, 10, "Struggled with understanding the utility classes.", 210L, new Guid("237b98a8-9d2c-4dd7-8058-06a7c4909a6d"), 2024 },
                    { 22, 30, 6, 1, 10, "Completely lost in the initial stages.", 220L, new Guid("c876965b-b849-4f4b-b1ae-4c78e5f9b3df"), 2024 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cards_DeckId",
                table: "Cards",
                column: "DeckId");

            migrationBuilder.CreateIndex(
                name: "IX_Decks_ClassId",
                table: "Decks",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCardStatistic_CardId",
                table: "UserCardStatistic",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCardStatistic_UserId",
                table: "UserCardStatistic",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserClasses_ClassId",
                table: "UserClasses",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_UserClasses_UserId",
                table: "UserClasses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDeckStatistic_DeckId",
                table: "UserDeckStatistic",
                column: "DeckId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDeckStatistic_UserId",
                table: "UserDeckStatistic",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserCardStatistic");

            migrationBuilder.DropTable(
                name: "UserClasses");

            migrationBuilder.DropTable(
                name: "UserDeckStatistic");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Decks");

            migrationBuilder.DropTable(
                name: "Classes");
        }
    }
}
