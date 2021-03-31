using BookStore.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Data
{
    public class DataContext : IdentityDbContext<IdentityUser>
    {
        public DataContext(DbContextOptions options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Publisher> Publishers { get; set; }

        public DbSet<ShoppingCart> ShoppingCarts { get; set; }

        public DbSet<WishList> WishLists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Data Seed
            #region Category
            modelBuilder.Entity<Category>().HasData(
                    new Category
                    { ID = 1, Name = "Fiction" },
                    new Category
                    { ID = 2, Name = "Action" },
                    new Category
                    { ID = 3, Name = "Crime" },
                    new Category
                    { ID = 4, Name = "Adventure" },
                    new Category
                    { ID = 5, Name = "Drama" },
                    new Category
                    { ID = 6, Name = "Fantasy" },
                    new Category
                    { ID = 7, Name = "Thriller" },
                    new Category
                    { ID = 8, Name = "General" },
                    new Category
                    { ID = 9, Name = "Horror" },
                    new Category
                    { ID = 10, Name = "Comedy" },
                    new Category
                    { ID = 11, Name = "Uncategorized" }
                    );
            #endregion
            #region Author
            modelBuilder.Entity<Author>().HasData(
            new Author
            {
                ID = 1,
                Name = "Agatha Christie",
                ShortDiscription = "Dame Agatha Mary Clarissa Christie, Lady Mallowan, DBE (née Miller; 15 September 1890 – 12 January 1976) " +
                    "was an English writer known for her 66 detective novels and 14 short story collections, particularly those revolving around " +
                    "fictional detectives Hercule Poirot and Miss Marple. She also wrote the world's longest-running play The Mousetrap and " +
                    "six romances under the pen name Mary Westmacott. In 1971, she was appointed a Dame Commander of the Order of the British Empire " +
                    "(DBE) for her contribution to literature",
                Popularity = false,
                Country = "Country1",
                Gender = "Female",
                DateBirth = DateTime.Now,
                Language = "English"

            },
                new Author
                {
                    ID = 2,
                    Name = "Stephen King",
                    ShortDiscription = "Stephen Edwin King (born September 21, 1947) is an American author of horror, " +
                    "supernatural fiction, suspense, and fantasy novels. His books have sold more than 350 million copies, " +
                    "many of which have been adapted into feature films, miniseries, television series, and comic books. " +
                    "King has published 61 novels (including seven under the pen name Richard Bachman) and six non-fiction books. " +
                    "He has written approximately 200 short stories, most of which have been published in book collections.",
                    Popularity = true,
                    Country = "Country2",
                    Gender = "Male",
                    DateBirth = DateTime.Now,
                    Language = "English"
                },
                new Author
                {
                    ID = 3,
                    Name = "William Shakespeare",
                    ShortDiscription = "William Shakespeare (bapt. 26 April 1564 – 23 April 1616) was an English poet, playwright, and actor, " +
                    "widely regarded as the greatest writer in the English language and the world's greatest dramatist. He is often called England's " +
                    "national poet and the \"Bard of Avon\" (or simply \"the Bard\"). His extant works, including collaborations, consist of some " +
                    "39 plays, 154 sonnets, two long narrative poems, and a few other verses, some of uncertain authorship. " +
                    "His plays have been translated into every major living language and are performed more often than those of any other playwright",
                    Popularity = false,
                    Country = "Country3",
                    Gender = "Male",
                    DateBirth = DateTime.Now,
                    Language = "English"
                },
                new Author
                {
                    ID = 4,
                    Name = "J. K. Rowling",
                    ShortDiscription = "Joanne Rowling CH, OBE, HonFRSE, FRCPE, FRSL, (born 31 July 1965), better known by her pen name J. K. Rowling, " +
                    "is a British author, film producer, television producer, screenwriter, and philanthropist. She is best known for writing the Harry Potter fantasy series," +
                    "which has won multiple awards and sold more than 500 million copies, becoming the best-selling book series in history. The books are the basis of a popular " +
                    "film series, over which Rowling had overall approval on the scripts and was a producer on the final films. She also writes crime fiction under the name Robert Galbraith.",
                    Popularity = false,
                    Country = "Country4",
                    Gender = "Female",
                    DateBirth = DateTime.Now,
                    Language = "English"
                },
                new Author
                {
                    ID = 5,
                    Name = "Leo Tolstoy",
                    ShortDiscription = "Count Lev Nikolayevich Tolstoy (9 September [O.S. 28 August] 1828 – 20 November [O.S. 7 November] 1910), usually referred to in English as Leo Tolstoy, " +
                    "was a Russian writer who is regarded as one of the greatest authors of all time. He received multiple nominations for the Nobel Prize in Literature every year " +
                    "from 1902 to 1906, and nominations for Nobel Peace Prize in 1901, 1902 and 1910, and the fact that he never won is a major Nobel prize controversy",
                    Popularity = false,
                    Country = "Country5",
                    Gender = "Male",
                    DateBirth = DateTime.Now,
                    Language = "English"
                },
                new Author
                {
                    ID = 6,
                    Name = "Paulo Coelho",
                    ShortDiscription = "Paulo Coelho de Souza (born 24 August 1947) is a Brazilian lyricist and novelist, best known for his novel The Alchemist. " +
                    "In 2014, he uploaded his personal papers online to create a virtual Paulo Coelho Foundation",
                    Popularity = false,
                    Country = "Country6",
                    Gender = "Male",
                    DateBirth = DateTime.Now,
                    Language = "English"
                },
                new Author
                {
                    ID = 7,
                    Name = "Jeffrey Archer",
                    ShortDiscription = "Jeffrey Howard Archer (born 15 April 1940) is an English novelist, former politician, convicted perjurer, and peer of the realm. " +
                    "Before becoming an author,Archer was a Member of Parliament(1969–1974), but did not seek re - election after a financial scandal that left him almost bankrupt." +
                    "He revived his fortunes as a best - selling novelist; his books have sold around 330 million copies worldwide",
                    Popularity = false,
                    Country = "Country7",
                    Gender = "Male",
                    DateBirth = DateTime.Now,
                    Language = "English"
                },
                new Author
                {
                    ID = 8,
                    Name = "Ian Fleming",
                    ShortDiscription = "Ian Lancaster Fleming (28 May 1908 – 12 August 1964) was an English author, journalist and naval intelligence officer who is best known " +
                    "for his James Bond series of spy novels. Fleming came from a wealthy family connected to the merchant bank Robert Fleming & Co., and his father was the " +
                    "Member of Parliament for Henley from 1910 until his death on the Western Front in 1917. Educated at Eton, Sandhurst and, briefly, the universities of Munich and Geneva, " +
                    "Fleming moved through several jobs before he started writing.",
                    Popularity = false,
                    Country = "Country8",
                    Gender = "Male",
                    DateBirth = DateTime.Now,
                    Language = "English"
                },
                new Author
                {
                    ID = 9,
                    Name = "Nicholas Sparks",
                    ShortDiscription = "Nicholas Charles Sparks (born December 31, 1965) is an American romance novelist and screenwriter. " +
                    "He has published twenty novels and two non-fiction books. Several of his novels have become international bestsellers, " +
                    "and eleven of his romantic-drama novels have been adapted to film all with multimillion-dollar box office grosses." +
                    "His novels feature stories of tragic love with happy endings.",
                    Popularity = false,
                    Country = "Country9",
                    Gender = "Male",
                    DateBirth = DateTime.Now,
                    Language = "English"
                },
                new Author
                {
                    ID = 10,
                    Name = "Dan Brown",
                    ShortDiscription = "Daniel Gerhard Brown (born June 22, 1964) is an American author best known for his thriller novels," +
                    " including the Robert Langdon novels Angels & Demons (2000), The Da Vinci Code (2003), The Lost Symbol (2009), Inferno (2013) and Origin (2017). " +
                    "His novels are treasure hunts that usually take place over a period of 24 hours.[2] They feature recurring themes of cryptography, art, " +
                    "and conspiracy theories. His books have been translated into 57 languages and, as of 2012, have sold over 200 million copies. " +
                    "Three of them, Angels & Demons, The Da Vinci Code, and Inferno, have been adapted into films.",
                    Popularity = false,
                    Country = "Country10",
                    Gender = "Male",
                    DateBirth = DateTime.Now,
                    Language = "English"
                });

            #endregion
            #region Publisher
            modelBuilder.Entity<Publisher>().HasData(
                new Publisher
                {
                    ID = 1,
                    Name = "William Morrow Paperbacks",
                    Country = "Ireland",
                    Year = "2020"
                },
                new Publisher
                {
                    ID = 2,
                    Name = "Scholastic",
                    Country = "USA",
                    Year = "2020"
                },
                new Publisher
                {
                    ID = 3,
                    Name = "Penguin Random House",
                    Country = "Not known",
                    Year = "2020"
                },
                new Publisher
                {
                    ID = 4,
                    Name = "Hachette Livre",
                    Country = "France",
                    Year = "2020"
                },
                new Publisher
                {
                    ID = 5,
                    Name = "HarperCollins",
                    Country = "USA",
                    Year = "2020"
                },
                new Publisher
                {
                    ID = 6,
                    Name = "Macmillan Publishers",
                    Country = "Germany",
                    Year = "2020"
                },
                new Publisher
                {
                    ID = 7,
                    Name = "Simon & Schuster",
                    Country = "USA",
                    Year = "2020"
                },
                new Publisher
                {
                    ID = 8,
                    Name = "McGraw-Hill Education",
                    Country = "USA",
                    Year = "2020"
                },
                new Publisher
                {
                    ID = 9,
                    Name = "Houghton Mifflin Harcourt",
                    Country = "USA",
                    Year = "2020"
                },
                new Publisher
                {
                    ID = 10,
                    Name = "Pearson Education",
                    Country = "USA",
                    Year = "2020"
                }
            );
            #endregion
            #region Books
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    ID = 1,
                    Title = "Murder On The Orient Express",
                    AuthorID = 1,
                    AuthorName = "Agatha Cristie",
                    BookType = "Paperback",
                    CategoryID = 1,
                    CategoryName = "Fiction",
                    Copies = 100,
                    Country = "UK",
                    Discription = "Book seed 1 Description",
                    Dimension = "12x12x20",
                    Genre = "Fiction",
                    Edition = 1,
                    Language = "English",
                    NumberOfPages = 586,
                    Price = 9.99,
                    PublisherID = 1,
                    PublisherName = "William Morrow Paperbacks",
                    Shipping = "Free",
                    Weight = 0.49,
                    YearOfIssue = new DateTime(2020, 02, 29, 23, 29, 25),
                    PhotoURL = "AgathaCristie_MurderOnTheOrientExpress.jpg",
                    SoldItems = 20,
                    DateAdded = DateTime.Now,
                    Rating = 3.5,
                    BookCoverType = "Paper",
                    UserID = 1
                },
                new Book
                {
                    ID = 2,
                    Title = "The Dark Tower I: The Gunslinger",
                    AuthorID = 2,
                    AuthorName = "Stephen King",
                    BookType = "Paperback",
                    CategoryID = 6,
                    CategoryName = "Fantasy",
                    Copies = 50,
                    Country = "",
                    Discription = "Now a major motion picture starring Matthew McConaughey and Idris Elba. " +
                    "An impressive work of mythic magnitude that may turn out to be Stephen King's greatest literary " +
                    "achievement (The Atlanta Journal-Constitution), The Gunslinger is the first volume in the epic Dark Tower Series. " +
                    "A #1 national bestseller, The Gunslinger introduces readers to one of Stephen King's most powerful creations, " +
                    "Roland of Gilead: The Last Gunslinger. He is a haunting figure, a loner on a spellbinding journey into good and evil. " +
                    "In his desolate world, which mirrors our own in frightening ways, Roland tracks The Man in Black, encounters an enticing " +
                    "woman named Alice, and begins a friendship with the boy from New York named Jake. Inspired in part by the Robert Browning narrative poem," +
                    "Childe Roland to the Dark Tower Came, The Gunslinger is a compelling whirlpool of a story that draws one irretrievable to its center ( Milwaukee Sentinel ). " +
                    "It is brilliant and fresh...and will leave you panting for more ( Booklist ).",
                    Dimension = "Not known",
                    Genre = "Fantasy",
                    Edition = 1,
                    Language = "English",
                    NumberOfPages = 586,
                    Price = 11.48,
                    PublisherID = 2,
                    PublisherName = "Scholastic",
                    Shipping = "Free",
                    Weight = 0.60,
                    YearOfIssue = new DateTime(2017, 06, 13, 00, 00, 00),
                    PhotoURL = "StephenKing_The_Dark_Tower.jpg",
                    SoldItems = 19,
                    DateAdded = DateTime.Now,
                    Rating = 3.5,
                    BookCoverType = "Paper",
                    UserID = 1
                },
                new Book
                {
                    ID = 3,
                    Title = "Dreamcatcher",
                    AuthorID = 2,
                    AuthorName = "Stephen King",
                    BookType = "Paperback",
                    CategoryID = 9,
                    CategoryName = "Horror",
                    Copies = 20,
                    Country = "USA",
                    Discription = "Once upon a time, in the haunted city of Derry (site of the classics \"It\" and \"Insomnia),\" four boys stood together " +
                    "and did a brave thing. Certainly a good thing, perhaps even a great thing. Something that changed them in ways they could never begin to understand. " +
                    "Twenty - five years later, the boys are now men with separate lives and separate troubles. But the ties endure. " +
                    "Each hunting season the foursome reunite in the woods of Maine. This year, a stranger stumbles into their camp, disoriented, " +
                    "mumbling something about lights in the sky. His incoherent ravings prove to be dis - turbingly prescient.Before long, these men will be plunged into a " +
                    "horrifying struggle with a creature from another world. Their only chance of survival is locked in their shared past-- and in the Dreamcatcher.",
                    Dimension = "6.51 x 9.56 x 2.01 inches",
                    Genre = "Horror",
                    Edition = 1,
                    Language = "English",
                    NumberOfPages = 624,
                    Price = 13.98,
                    PublisherID = 7,
                    PublisherName = "Simon & Schuster",
                    Shipping = "Free",
                    Weight = 2.22,
                    YearOfIssue = new DateTime(2020, 02, 29, 23, 29, 25),
                    PhotoURL = "StephenKing_Dreamcatcher.jpg",
                    SoldItems = 3,
                    DateAdded = DateTime.Now,
                    Rating = 3.5,
                    BookCoverType = "Paper",
                    UserID = 1

                },
                new Book
                {
                    ID = 4,
                    Title = "The Green Mile",
                    AuthorID = 2,
                    AuthorName = "Stephen King",
                    BookType = "Paperback",
                    CategoryID = 8,
                    CategoryName = "General",
                    Copies = 150,
                    Country = "USA",
                    Discription = "Stephen King's international bestselling - and highly acclaimed - novel, also a hugely successful film starring Tom Hanks",
                    Dimension = "5.12 x 7.80 x 1.22 inches",
                    Genre = "Drama",
                    Edition = 1,
                    Language = "English",
                    NumberOfPages = 480,
                    Price = 23.98,
                    PublisherID = 9,
                    PublisherName = "Houghton Mifflin Harcourt",
                    Shipping = "Free",
                    Weight = 0.49,
                    YearOfIssue = new DateTime(2005, 03, 24, 00, 00, 00),
                    PhotoURL = "StephenKing-The-Green-Mile.jpg",
                    SoldItems = 4,
                    DateAdded = DateTime.Now,
                    Rating = 3.5,
                    BookCoverType = "Paper",
                    UserID = 1
                },
                new Book
                {
                    ID = 5,
                    Title = "Insomnia",
                    AuthorID = 2,
                    AuthorName = "Stephen King",
                    BookType = "Paperback",
                    CategoryID = 9,
                    CategoryName = "Horror",
                    Copies = 200,
                    Country = "USA",
                    Discription = "Old Ralph Roberts hasn't been sleeping well lately. Every night he wakes just a little bit earlier, and pretty soon, he thinks, " +
                    "he won't get any sleep at all. It wouldn't be so bad, except for the strange hallucinations he's been having. " +
                    "Or, at least, he hopes they are hallucinations--because here in Derry, one never can tell. Part of the \"Books That Take You Anywhere You Want To Go\" " +
                    "Summer Reading Promotion.",
                    Dimension = "4.21 x 6.93 x 1.51 inches",
                    Genre = "Horror",
                    Edition = 1,
                    Language = "English",
                    NumberOfPages = 663,
                    Price = 12.98,
                    PublisherID = 5,
                    PublisherName = "HarperCollins",
                    Shipping = "Free",
                    Weight = 0.70,
                    YearOfIssue = new DateTime(1995, 09, 01, 00, 00, 00),
                    PhotoURL = "StephenKing_Insomnia.jpg",
                    SoldItems = 5,
                    DateAdded = DateTime.Now,
                    Rating = 3.5,
                    BookCoverType = "Paper",
                    UserID = 1
                },
                new Book
                {
                    ID = 6,
                    Title = "The Shining",
                    AuthorID = 2,
                    AuthorName = "Stephen King",
                    BookType = "Paperback",
                    CategoryID = 7,
                    CategoryName = "Thrillers",
                    Copies = 40,
                    Country = "USA",
                    Discription = "Evil forces try to destroy a boy with psychic powers.",
                    Dimension = "6.44 x 9.42 x 1.46 inches",
                    Genre = "Thriller",
                    Edition = 1,
                    Language = "English",
                    NumberOfPages = 450,
                    Price = 33.48,
                    PublisherID = 5,
                    PublisherName = "HarperCollins",
                    Shipping = "Free",
                    Weight = 1.68,
                    YearOfIssue = new DateTime(1990, 06, 01, 00, 00, 00),
                    PhotoURL = "StephenKing_The-Shining.jpg",
                    SoldItems = 6,
                    DateAdded = DateTime.Now,
                    Rating = 3.5,
                    BookCoverType = "Paper",
                    UserID = 1
                },
                new Book
                {
                    ID = 7,
                    Title = "Desperation",
                    AuthorID = 2,
                    AuthorName = "Stephen King",
                    BookType = "Paperback",
                    CategoryID = 9,
                    CategoryName = "Horror",
                    Copies = 230,
                    Country = "USA",
                    Discription = "Now repackaged with stunning new cover art, this #1 bestseller is a chilling story set in a lonely Nevada town " +
                    "where the evil embedded in the landscape is awesome--but so are the forces summoned to combat it. Reissue",
                    Dimension = "4.22 x 6.86 x 1.52 inches",
                    Genre = "Horror",
                    Edition = 1,
                    Language = "English",
                    NumberOfPages = 547,
                    Price = 22.98,
                    PublisherID = 10,
                    PublisherName = "Pearson Education",
                    Shipping = "Free",
                    Weight = 0.49,
                    YearOfIssue = new DateTime(2003, 04, 01, 00, 00, 00),
                    PhotoURL = "StephenKing_Desperation.jpg",
                    SoldItems = 7,
                    DateAdded = DateTime.Now,
                    Rating = 3.5,
                    BookCoverType = "Paper",
                    UserID = 1
                },
                new Book
                {
                    ID = 8,
                    Title = "Othello",
                    AuthorID = 3,
                    AuthorName = "William Shakespeare",
                    BookType = "Paperback",
                    CategoryID = 5,
                    CategoryName = "Drama",
                    Copies = 65,
                    Country = "UK",
                    Discription = "Shakespeare's tragedy about Othello the Moor is presented in this freshly edited text with full explanatory notes, " +
                    "scene-by-scene plot summaries, an Introduction to reading Shakespeare's language, and much more. Reissue.",
                    Dimension = "4.10 x 6.70 x 1.00 inches",
                    Genre = "Drama",
                    Edition = 1,
                    Language = "English",
                    NumberOfPages = 368,
                    Price = 5.98,
                    PublisherID = 7,
                    PublisherName = "Simon & Schuster",
                    Shipping = "Free",
                    Weight = 0.40,
                    YearOfIssue = new DateTime(2003, 12, 23, 00, 00, 00),
                    PhotoURL = "WilliamShakespeare_Othell...",
                    SoldItems = 5,
                    DateAdded = DateTime.Now,
                    Rating = 3.5,
                    BookCoverType = "Paper",
                    UserID = 1
                }
                );
            #endregion

                    base.OnModelCreating(modelBuilder);
        }
    }
}
