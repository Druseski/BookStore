using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Data.Migrations
{
    public partial class initial_data_seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Country = table.Column<string>(maxLength: 100, nullable: true),
                    DateBirth = table.Column<DateTime>(nullable: false),
                    ShortDiscription = table.Column<string>(maxLength: 1500, nullable: true),
                    Language = table.Column<string>(maxLength: 50, nullable: true),
                    Gender = table.Column<string>(maxLength: 50, nullable: true),
                    Popularity = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<string>(nullable: true),
                    BookTitle = table.Column<string>(nullable: true),
                    BookAuthor = table.Column<string>(nullable: true),
                    BookCountry = table.Column<string>(nullable: true),
                    BookPublisher = table.Column<string>(nullable: true),
                    BookCategory = table.Column<string>(nullable: true),
                    BookType = table.Column<string>(nullable: true),
                    BookDimension = table.Column<string>(nullable: true),
                    BookWeight = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    ShippedDate = table.Column<DateTime>(nullable: false),
                    DeliveryDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Country = table.Column<string>(maxLength: 100, nullable: true),
                    Year = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<string>(nullable: true),
                    BookID = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Discount = table.Column<double>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WishLists",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<string>(nullable: true),
                    BookID = table.Column<int>(nullable: false),
                    AuthorID = table.Column<int>(nullable: false),
                    CategoryID = table.Column<int>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishLists", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 350, nullable: true),
                    AuthorName = table.Column<string>(maxLength: 350, nullable: true),
                    AuthorID = table.Column<int>(nullable: false),
                    YearOfIssue = table.Column<DateTime>(nullable: false),
                    NumberOfPages = table.Column<int>(nullable: false),
                    PublisherName = table.Column<string>(maxLength: 350, nullable: true),
                    PublisherID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    Genre = table.Column<string>(maxLength: 150, nullable: true),
                    CategoryName = table.Column<string>(nullable: true),
                    CategoryID = table.Column<int>(nullable: false),
                    BookType = table.Column<string>(maxLength: 50, nullable: true),
                    BookCoverType = table.Column<string>(maxLength: 50, nullable: true),
                    Price = table.Column<double>(nullable: false),
                    Discription = table.Column<string>(maxLength: 1500, nullable: true),
                    Language = table.Column<string>(maxLength: 50, nullable: true),
                    Country = table.Column<string>(maxLength: 150, nullable: true),
                    Edition = table.Column<int>(nullable: false),
                    Dimension = table.Column<string>(maxLength: 50, nullable: true),
                    Weight = table.Column<double>(nullable: false),
                    Copies = table.Column<int>(nullable: false),
                    Shipping = table.Column<string>(maxLength: 50, nullable: true),
                    PhotoURL = table.Column<string>(nullable: true),
                    SoldItems = table.Column<int>(nullable: false),
                    Rating = table.Column<double>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorID",
                        column: x => x.AuthorID,
                        principalTable: "Authors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Publishers_PublisherID",
                        column: x => x.PublisherID,
                        principalTable: "Publishers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "ID", "Country", "DateBirth", "Gender", "Language", "Name", "Popularity", "ShortDiscription" },
                values: new object[,]
                {
                    { 1, "Country1", new DateTime(2021, 3, 31, 18, 22, 42, 406, DateTimeKind.Local).AddTicks(2054), "Female", "English", "Agatha Christie", false, "Dame Agatha Mary Clarissa Christie, Lady Mallowan, DBE (née Miller; 15 September 1890 – 12 January 1976) was an English writer known for her 66 detective novels and 14 short story collections, particularly those revolving around fictional detectives Hercule Poirot and Miss Marple. She also wrote the world's longest-running play The Mousetrap and six romances under the pen name Mary Westmacott. In 1971, she was appointed a Dame Commander of the Order of the British Empire (DBE) for her contribution to literature" },
                    { 2, "Country2", new DateTime(2021, 3, 31, 18, 22, 42, 407, DateTimeKind.Local).AddTicks(9522), "Male", "English", "Stephen King", true, "Stephen Edwin King (born September 21, 1947) is an American author of horror, supernatural fiction, suspense, and fantasy novels. His books have sold more than 350 million copies, many of which have been adapted into feature films, miniseries, television series, and comic books. King has published 61 novels (including seven under the pen name Richard Bachman) and six non-fiction books. He has written approximately 200 short stories, most of which have been published in book collections." },
                    { 3, "Country3", new DateTime(2021, 3, 31, 18, 22, 42, 407, DateTimeKind.Local).AddTicks(9562), "Male", "English", "William Shakespeare", false, "William Shakespeare (bapt. 26 April 1564 – 23 April 1616) was an English poet, playwright, and actor, widely regarded as the greatest writer in the English language and the world's greatest dramatist. He is often called England's national poet and the \"Bard of Avon\" (or simply \"the Bard\"). His extant works, including collaborations, consist of some 39 plays, 154 sonnets, two long narrative poems, and a few other verses, some of uncertain authorship. His plays have been translated into every major living language and are performed more often than those of any other playwright" },
                    { 4, "Country4", new DateTime(2021, 3, 31, 18, 22, 42, 407, DateTimeKind.Local).AddTicks(9567), "Female", "English", "J. K. Rowling", false, "Joanne Rowling CH, OBE, HonFRSE, FRCPE, FRSL, (born 31 July 1965), better known by her pen name J. K. Rowling, is a British author, film producer, television producer, screenwriter, and philanthropist. She is best known for writing the Harry Potter fantasy series,which has won multiple awards and sold more than 500 million copies, becoming the best-selling book series in history. The books are the basis of a popular film series, over which Rowling had overall approval on the scripts and was a producer on the final films. She also writes crime fiction under the name Robert Galbraith." },
                    { 5, "Country5", new DateTime(2021, 3, 31, 18, 22, 42, 407, DateTimeKind.Local).AddTicks(9570), "Male", "English", "Leo Tolstoy", false, "Count Lev Nikolayevich Tolstoy (9 September [O.S. 28 August] 1828 – 20 November [O.S. 7 November] 1910), usually referred to in English as Leo Tolstoy, was a Russian writer who is regarded as one of the greatest authors of all time. He received multiple nominations for the Nobel Prize in Literature every year from 1902 to 1906, and nominations for Nobel Peace Prize in 1901, 1902 and 1910, and the fact that he never won is a major Nobel prize controversy" },
                    { 6, "Country6", new DateTime(2021, 3, 31, 18, 22, 42, 407, DateTimeKind.Local).AddTicks(9573), "Male", "English", "Paulo Coelho", false, "Paulo Coelho de Souza (born 24 August 1947) is a Brazilian lyricist and novelist, best known for his novel The Alchemist. In 2014, he uploaded his personal papers online to create a virtual Paulo Coelho Foundation" },
                    { 7, "Country7", new DateTime(2021, 3, 31, 18, 22, 42, 407, DateTimeKind.Local).AddTicks(9603), "Male", "English", "Jeffrey Archer", false, "Jeffrey Howard Archer (born 15 April 1940) is an English novelist, former politician, convicted perjurer, and peer of the realm. Before becoming an author,Archer was a Member of Parliament(1969–1974), but did not seek re - election after a financial scandal that left him almost bankrupt.He revived his fortunes as a best - selling novelist; his books have sold around 330 million copies worldwide" },
                    { 8, "Country8", new DateTime(2021, 3, 31, 18, 22, 42, 407, DateTimeKind.Local).AddTicks(9607), "Male", "English", "Ian Fleming", false, "Ian Lancaster Fleming (28 May 1908 – 12 August 1964) was an English author, journalist and naval intelligence officer who is best known for his James Bond series of spy novels. Fleming came from a wealthy family connected to the merchant bank Robert Fleming & Co., and his father was the Member of Parliament for Henley from 1910 until his death on the Western Front in 1917. Educated at Eton, Sandhurst and, briefly, the universities of Munich and Geneva, Fleming moved through several jobs before he started writing." },
                    { 9, "Country9", new DateTime(2021, 3, 31, 18, 22, 42, 407, DateTimeKind.Local).AddTicks(9609), "Male", "English", "Nicholas Sparks", false, "Nicholas Charles Sparks (born December 31, 1965) is an American romance novelist and screenwriter. He has published twenty novels and two non-fiction books. Several of his novels have become international bestsellers, and eleven of his romantic-drama novels have been adapted to film all with multimillion-dollar box office grosses.His novels feature stories of tragic love with happy endings." },
                    { 10, "Country10", new DateTime(2021, 3, 31, 18, 22, 42, 407, DateTimeKind.Local).AddTicks(9612), "Male", "English", "Dan Brown", false, "Daniel Gerhard Brown (born June 22, 1964) is an American author best known for his thriller novels, including the Robert Langdon novels Angels & Demons (2000), The Da Vinci Code (2003), The Lost Symbol (2009), Inferno (2013) and Origin (2017). His novels are treasure hunts that usually take place over a period of 24 hours.[2] They feature recurring themes of cryptography, art, and conspiracy theories. His books have been translated into 57 languages and, as of 2012, have sold over 200 million copies. Three of them, Angels & Demons, The Da Vinci Code, and Inferno, have been adapted into films." }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 11, "Uncategorized" },
                    { 10, "Comedy" },
                    { 9, "Horror" },
                    { 8, "General" },
                    { 7, "Thriller" },
                    { 6, "Fantasy" },
                    { 5, "Drama" },
                    { 4, "Adventure" },
                    { 3, "Crime" },
                    { 2, "Action" },
                    { 1, "Fiction" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "ID", "Country", "Name", "Year" },
                values: new object[,]
                {
                    { 1, "Ireland", "William Morrow Paperbacks", "2020" },
                    { 2, "USA", "Scholastic", "2020" },
                    { 3, "Not known", "Penguin Random House", "2020" },
                    { 4, "France", "Hachette Livre", "2020" },
                    { 5, "USA", "HarperCollins", "2020" },
                    { 6, "Germany", "Macmillan Publishers", "2020" },
                    { 7, "USA", "Simon & Schuster", "2020" },
                    { 8, "USA", "McGraw-Hill Education", "2020" },
                    { 9, "USA", "Houghton Mifflin Harcourt", "2020" },
                    { 10, "USA", "Pearson Education", "2020" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ID", "AuthorID", "AuthorName", "BookCoverType", "BookType", "CategoryID", "CategoryName", "Copies", "Country", "DateAdded", "Dimension", "Discription", "Edition", "Genre", "Language", "NumberOfPages", "PhotoURL", "Price", "PublisherID", "PublisherName", "Rating", "Shipping", "SoldItems", "Title", "UserID", "Weight", "YearOfIssue" },
                values: new object[,]
                {
                    { 1, 1, "Agatha Cristie", "Paper", "Paperback", 1, "Fiction", 100, "UK", new DateTime(2021, 3, 31, 18, 22, 42, 408, DateTimeKind.Local).AddTicks(8425), "12x12x20", "Book seed 1 Description", 1, "Fiction", "English", 586, "AgathaCristie_MurderOnTheOrientExpress.jpg", 9.9900000000000002, 1, "William Morrow Paperbacks", 3.5, "Free", 20, "Murder On The Orient Express", 1, 0.48999999999999999, new DateTime(2020, 2, 29, 23, 29, 25, 0, DateTimeKind.Unspecified) },
                    { 2, 2, "Stephen King", "Paper", "Paperback", 6, "Fantasy", 50, "", new DateTime(2021, 3, 31, 18, 22, 42, 408, DateTimeKind.Local).AddTicks(9748), "Not known", "Now a major motion picture starring Matthew McConaughey and Idris Elba. An impressive work of mythic magnitude that may turn out to be Stephen King's greatest literary achievement (The Atlanta Journal-Constitution), The Gunslinger is the first volume in the epic Dark Tower Series. A #1 national bestseller, The Gunslinger introduces readers to one of Stephen King's most powerful creations, Roland of Gilead: The Last Gunslinger. He is a haunting figure, a loner on a spellbinding journey into good and evil. In his desolate world, which mirrors our own in frightening ways, Roland tracks The Man in Black, encounters an enticing woman named Alice, and begins a friendship with the boy from New York named Jake. Inspired in part by the Robert Browning narrative poem,Childe Roland to the Dark Tower Came, The Gunslinger is a compelling whirlpool of a story that draws one irretrievable to its center ( Milwaukee Sentinel ). It is brilliant and fresh...and will leave you panting for more ( Booklist ).", 1, "Fantasy", "English", 586, "StephenKing_The_Dark_Tower.jpg", 11.48, 2, "Scholastic", 3.5, "Free", 19, "The Dark Tower I: The Gunslinger", 1, 0.59999999999999998, new DateTime(2017, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 2, "Stephen King", "Paper", "Paperback", 9, "Horror", 200, "USA", new DateTime(2021, 3, 31, 18, 22, 42, 408, DateTimeKind.Local).AddTicks(9792), "4.21 x 6.93 x 1.51 inches", "Old Ralph Roberts hasn't been sleeping well lately. Every night he wakes just a little bit earlier, and pretty soon, he thinks, he won't get any sleep at all. It wouldn't be so bad, except for the strange hallucinations he's been having. Or, at least, he hopes they are hallucinations--because here in Derry, one never can tell. Part of the \"Books That Take You Anywhere You Want To Go\" Summer Reading Promotion.", 1, "Horror", "English", 663, "StephenKing_Insomnia.jpg", 12.98, 5, "HarperCollins", 3.5, "Free", 5, "Insomnia", 1, 0.69999999999999996, new DateTime(1995, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 2, "Stephen King", "Paper", "Paperback", 7, "Thrillers", 40, "USA", new DateTime(2021, 3, 31, 18, 22, 42, 408, DateTimeKind.Local).AddTicks(9795), "6.44 x 9.42 x 1.46 inches", "Evil forces try to destroy a boy with psychic powers.", 1, "Thriller", "English", 450, "StephenKing_The-Shining.jpg", 33.479999999999997, 5, "HarperCollins", 3.5, "Free", 6, "The Shining", 1, 1.6799999999999999, new DateTime(1990, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 2, "Stephen King", "Paper", "Paperback", 9, "Horror", 20, "USA", new DateTime(2021, 3, 31, 18, 22, 42, 408, DateTimeKind.Local).AddTicks(9782), "6.51 x 9.56 x 2.01 inches", "Once upon a time, in the haunted city of Derry (site of the classics \"It\" and \"Insomnia),\" four boys stood together and did a brave thing. Certainly a good thing, perhaps even a great thing. Something that changed them in ways they could never begin to understand. Twenty - five years later, the boys are now men with separate lives and separate troubles. But the ties endure. Each hunting season the foursome reunite in the woods of Maine. This year, a stranger stumbles into their camp, disoriented, mumbling something about lights in the sky. His incoherent ravings prove to be dis - turbingly prescient.Before long, these men will be plunged into a horrifying struggle with a creature from another world. Their only chance of survival is locked in their shared past-- and in the Dreamcatcher.", 1, "Horror", "English", 624, "StephenKing_Dreamcatcher.jpg", 13.98, 7, "Simon & Schuster", 3.5, "Free", 3, "Dreamcatcher", 1, 2.2200000000000002, new DateTime(2020, 2, 29, 23, 29, 25, 0, DateTimeKind.Unspecified) },
                    { 8, 3, "William Shakespeare", "Paper", "Paperback", 5, "Drama", 65, "UK", new DateTime(2021, 3, 31, 18, 22, 42, 408, DateTimeKind.Local).AddTicks(9803), "4.10 x 6.70 x 1.00 inches", "Shakespeare's tragedy about Othello the Moor is presented in this freshly edited text with full explanatory notes, scene-by-scene plot summaries, an Introduction to reading Shakespeare's language, and much more. Reissue.", 1, "Drama", "English", 368, "WilliamShakespeare_Othell...", 5.9800000000000004, 7, "Simon & Schuster", 3.5, "Free", 5, "Othello", 1, 0.40000000000000002, new DateTime(2003, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 2, "Stephen King", "Paper", "Paperback", 8, "General", 150, "USA", new DateTime(2021, 3, 31, 18, 22, 42, 408, DateTimeKind.Local).AddTicks(9788), "5.12 x 7.80 x 1.22 inches", "Stephen King's international bestselling - and highly acclaimed - novel, also a hugely successful film starring Tom Hanks", 1, "Drama", "English", 480, "StephenKing-The-Green-Mile.jpg", 23.98, 9, "Houghton Mifflin Harcourt", 3.5, "Free", 4, "The Green Mile", 1, 0.48999999999999999, new DateTime(2005, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 2, "Stephen King", "Paper", "Paperback", 9, "Horror", 230, "USA", new DateTime(2021, 3, 31, 18, 22, 42, 408, DateTimeKind.Local).AddTicks(9799), "4.22 x 6.86 x 1.52 inches", "Now repackaged with stunning new cover art, this #1 bestseller is a chilling story set in a lonely Nevada town where the evil embedded in the landscape is awesome--but so are the forces summoned to combat it. Reissue", 1, "Horror", "English", 547, "StephenKing_Desperation.jpg", 22.98, 10, "Pearson Education", 3.5, "Free", 7, "Desperation", 1, 0.48999999999999999, new DateTime(2003, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorID",
                table: "Books",
                column: "AuthorID");

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryID",
                table: "Books",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Books_PublisherID",
                table: "Books",
                column: "PublisherID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.DropTable(
                name: "WishLists");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Publishers");
        }
    }
}
