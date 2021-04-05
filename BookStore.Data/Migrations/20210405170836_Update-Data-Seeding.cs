using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Data.Migrations
{
    public partial class UpdateDataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 1,
                column: "DateBirth",
                value: new DateTime(2021, 4, 5, 19, 8, 36, 245, DateTimeKind.Local).AddTicks(1012));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 2,
                column: "DateBirth",
                value: new DateTime(2021, 4, 5, 19, 8, 36, 245, DateTimeKind.Local).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateBirth", "ShortDiscription" },
                values: new object[] { new DateTime(2021, 4, 5, 19, 8, 36, 245, DateTimeKind.Local).AddTicks(1752), "William Shakespeare (bapt. 26 April 1564 – 23 April 1616) was an English poet, playwright, and actor, wIDely regarded as the greatest writer in the English language and the world's greatest dramatist. He is often called England's national poet and the \"Bard of Avon\" (or simply \"the Bard\"). His extant works, including collaborations, consist of some 39 plays, 154 sonnets, two long narrative poems, and a few other verses, some of uncertain authorship. His plays have been translated into every major living language and are performed more often than those of any other playwright" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 4,
                column: "DateBirth",
                value: new DateTime(2021, 4, 5, 19, 8, 36, 245, DateTimeKind.Local).AddTicks(1756));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 5,
                column: "DateBirth",
                value: new DateTime(2021, 4, 5, 19, 8, 36, 245, DateTimeKind.Local).AddTicks(1758));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 6,
                column: "DateBirth",
                value: new DateTime(2021, 4, 5, 19, 8, 36, 245, DateTimeKind.Local).AddTicks(1761));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateBirth", "ShortDiscription" },
                values: new object[] { new DateTime(2021, 4, 5, 19, 8, 36, 245, DateTimeKind.Local).AddTicks(1764), "Jeffrey Howard Archer (born 15 April 1940) is an English novelist, former politician, convicted perjurer, and peer of the realm. Before becoming an author,Archer was a Member of Parliament(1969–1974), but dID not seek re - election after a financial scandal that left him almost bankrupt.He revived his fortunes as a best - selling novelist; his books have sold around 330 million copies worldwIDe" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 8,
                column: "DateBirth",
                value: new DateTime(2021, 4, 5, 19, 8, 36, 245, DateTimeKind.Local).AddTicks(1766));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 9,
                column: "DateBirth",
                value: new DateTime(2021, 4, 5, 19, 8, 36, 245, DateTimeKind.Local).AddTicks(1769));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 10,
                column: "DateBirth",
                value: new DateTime(2021, 4, 5, 19, 8, 36, 245, DateTimeKind.Local).AddTicks(1772));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "Discription" },
                values: new object[] { new DateTime(2021, 4, 5, 19, 8, 36, 246, DateTimeKind.Local).AddTicks(1062), "Book seed 1 Discription" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "Discription" },
                values: new object[] { new DateTime(2021, 4, 5, 19, 8, 36, 246, DateTimeKind.Local).AddTicks(2435), "Now a major motion picture starring Matthew McConaughey and IDris Elba. An impressive work of mythic magnitude that may turn out to be Stephen King's greatest literary achievement (The Atlanta Journal-Constitution), The Gunslinger is the first volume in the epic Dark Tower Series. A #1 national bestseller, The Gunslinger introduces readers to one of Stephen King's most powerful creations, Roland of Gilead: The Last Gunslinger. He is a haunting figure, a loner on a spellbinding journey into good and evil. In his desolate world, which mirrors our own in frightening ways, Roland tracks The Man in Black, encounters an enticing woman named Alice, and begins a friendship with the boy from New York named Jake. Inspired in part by the Robert Browning narrative poem,Childe Roland to the Dark Tower Came, The Gunslinger is a compelling whirlpool of a story that draws one irretrievable to its center ( Milwaukee Sentinel ). It is brilliant and fresh...and will leave you panting for more ( Booklist )." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "Discription" },
                values: new object[] { new DateTime(2021, 4, 5, 19, 8, 36, 246, DateTimeKind.Local).AddTicks(2472), "Once upon a time, in the haunted city of Derry (site of the classics \"It\" and \"Insomnia),\" four boys stood together and dID a brave thing. Certainly a good thing, perhaps even a great thing. Something that changed them in ways they could never begin to understand. Twenty - five years later, the boys are now men with separate lives and separate troubles. But the ties endure. Each hunting season the foursome reunite in the woods of Maine. This year, a stranger stumbles into their camp, disoriented, mumbling something about lights in the sky. His incoherent ravings prove to be dis - turbingly prescient.Before long, these men will be plunged into a horrifying struggle with a creature from another world. Their only chance of survival is locked in their shared past-- and in the Dreamcatcher." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2021, 4, 5, 19, 8, 36, 246, DateTimeKind.Local).AddTicks(2477));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2021, 4, 5, 19, 8, 36, 246, DateTimeKind.Local).AddTicks(2506));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2021, 4, 5, 19, 8, 36, 246, DateTimeKind.Local).AddTicks(2510));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2021, 4, 5, 19, 8, 36, 246, DateTimeKind.Local).AddTicks(2515));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "SoldItems" },
                values: new object[] { new DateTime(2021, 4, 5, 19, 8, 36, 246, DateTimeKind.Local).AddTicks(2520), 18 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ID", "AuthorID", "AuthorName", "BookCoverType", "BookType", "CategoryID", "CategoryName", "Copies", "Country", "DateAdded", "Dimension", "Discription", "Edition", "Genre", "Language", "NumberOfPages", "PhotoURL", "Price", "PublisherID", "PublisherName", "Rating", "Shipping", "SoldItems", "Title", "UserID", "Weight", "YearOfIssue" },
                values: new object[,]
                {
                    { 20, 1, "Agatha Christie", "Paper", "Paperback", 7, "Thrillers", 70, "UK", new DateTime(2021, 4, 5, 19, 8, 36, 246, DateTimeKind.Local).AddTicks(2582), "5.82 x 8.52 x 0.94 inches", "When Alice Ascher is murdered in Andover, Hercule Poirot is already onto the clues. Alphabetically speaking, it's one down, 25 to go. This classic mystery is now repackaged in a digest-sized edition for young adults. Reissue.", 1, "Thriller", "English", 256, "AgathaCristie_TheABCMurders.jpg", 8.4800000000000004, 7, "Simon & Schuster", 3.5, "Free", 11, "The A.B.C. Murders", 1, 0.98999999999999999, new DateTime(2006, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 6, "Paulo Coelho", "Paper", "Paperback", 1, "Fiction", 222, "UK", new DateTime(2021, 4, 5, 19, 8, 36, 246, DateTimeKind.Local).AddTicks(2531), "5.36 x 8.02 x 0.56 inches", "This international bestseller about the shepherd boy Santiago who learns how to live his dreams includes an inspiring afterword by the author.", 1, "Fiction", "English", 197, "PauloCoelho_The-Alchemist.jpg", 6.9800000000000004, 1, "William Morrow Paperbacks", 3.5, "Free", 16, "The Alchemist", 1, 0.48999999999999999, new DateTime(2006, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 6, "Paulo Coelho", "Paper", "Paperback", 1, "Fiction", 34, "USA", new DateTime(2021, 4, 5, 19, 8, 36, 246, DateTimeKind.Local).AddTicks(2537), "5.32 x 8.04 x 0.77 inches", "This gripping and daring novel by the author of the bestselling \"The Alchemist\" sensitively explores the sacred nature of sex and love. \"Sensual. . . for-adults - only fairytale.\"--\"Washington Post.\"", 1, "Fiction", "English", 320, "PauloCoelho_Eleven-Minutes.jpg", 12.48, 5, "HarperCollins", 3.5, "Free", 8, "Eleven Minutes", 1, 0.52000000000000002, new DateTime(2005, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 7, "Jeffrey Archer", "Paper", "Paperback", 1, "Fiction", 87, "USA", new DateTime(2021, 4, 5, 19, 8, 36, 246, DateTimeKind.Local).AddTicks(2544), "4.32 x 6.04 x 0.57 inches", "Jeffrey Archer's mesmerizing saga of the Clifton and Barrington families continues... 1945, London. The vote in the House of Lords as to who should inherit the Barrington family fortune has ended in a tie. The Lord Chancellor's decIDing vote will cast a long shadow on the lives of Harry Clifton and Giles Barrington. Harry returns to America to promote his latest novel, while his beloved Emma goes in search of the little girl who was found abandoned in her father's office on the night he was killed. When the general election is called, Giles Barrington has to defend his seat in the House of Commons and is horrified to discover who the Conservatives select to stand against him. But it is Sebastian Clifton, Harry and Emma's son, who ultimately influences his uncle's fate. In 1957, Sebastian wins a scholarship to CambrIDge, and a new generation of the Clifton family marches onto the page. But after Sebastian is expelled from school, he unwittingly becomes caught up in an international art fraud involving a Rodin statue that is worth far more than the sum it raises at auction. Does he become a millionaire? Does he go to CambrIDge? Is his life in danger?", 1, "Fiction", "English", 423, "ArcherJeffrey-Best-Kept-Secret.jpg", 14.48, 4, "Hachette Livre", 3.5, "Free", 9, "Best Kept Secret (The Clifton Chronicles)", 1, 0.56999999999999995, new DateTime(2014, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 8, "Ian Fleming", "Paper", "Paperback", 2, "Action", 122, "UK", new DateTime(2021, 4, 5, 19, 8, 36, 246, DateTimeKind.Local).AddTicks(2548), "4.32 x 6.04 x 0.57 inches", "In the novel that introduced James Bond to the world, Ian Fleming's agent 007 is dispatched to a French casino in Royale-les-Eaux. His mission? Bankrupt a ruthless Russian agent who's been on a bad luck streak at the baccarat table. One of SMERSH's most deadly operatives, the man known only as ?Le Chiffre, ? has been a prime target of the British Secret Service for years. If Bond can wipe out his bankroll, Le Chiffre will likely be ?retired? by his paymasters in Moscow. But what if the cards won't cooperate? After a brutal night at the gaming tables, Bond soon finds himself dodging would-be assassins, fighting off brutal torturers, and going all-in to save the life of his beautiful female counterpart, Vesper Lynd. Taut, tense, and effortlessly stylish, Ian Fleming's inaugural James Bond adventure has all the hallmarks that made the series a touchstone for a generation of readers.", 1, "Action", "English", 486, "IanFlemming_Casino_Royale.jpg", 13.48, 3, "Penguin Random House", 3.5, "Free", 15, "Casino Royale", 1, 0.29999999999999999, new DateTime(2012, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 8, "Ian Fleming", "Paper", "Paperback", 2, "Action", 10, "UK", new DateTime(2021, 4, 5, 19, 8, 36, 246, DateTimeKind.Local).AddTicks(2557), "5.12 x 7.72 x 0.53 inches", "The lethal SMERSH organization in Russia has targeted Agent 007 for elimination. But when James Bond allows himself to be lured to Istanbul and walks willingly into a trap, a game of cross and double-cross ensues, with Bond as both the stakes and the prize.", 1, "Action", "English", 272, "IanFleming_From-Russia-with-Love.jpg", 6.4800000000000004, 3, "Penguin Random House", 3.5, "Free", 14, "From Russia with Love", 1, 0.41999999999999998, new DateTime(2002, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 10, "Dan Brown", "Paper", "Paperback", 7, "Thrillers", 111, "USA", new DateTime(2021, 4, 5, 19, 8, 36, 246, DateTimeKind.Local).AddTicks(2569), "4.28 x 7.54 x 1.33 inches", "PREMIUM MASS MARKET EDITION #1 WorldwIDe Bestseller--More Than 80 Million Copies Sold As millions of readers around the globe have already discovered, The Da Vinci Code is a reading experience unlike any other.Simultaneously lightning - paced, intelligent,and intricately layered with remarkable research and detail, Dan Brown's novel is a thrilling masterpiece--from its opening pages to its stunning conclusion.", 2, "Thriller", "English", 608, "Dan-Brown_The-Da-Vinci-Code.jpg", 12.98, 6, "Macmillan Publishers", 3.5, "Free", 12, "The Da Vinci Code", 1, 0.48999999999999999, new DateTime(2009, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 9, "Nicholas Sparks", "Paper", "Paperback", 1, "Fiction", 44, "UK", new DateTime(2021, 4, 5, 19, 8, 36, 246, DateTimeKind.Local).AddTicks(2566), "4.10 x 6.70 x 1.00 inches", "#1 bestselling author Nicholas Sparks's new novel is at once a compelling family drama and a heartrending tale of young love.Seventeen year old Veronica \"Ronnie\" Miller's life was turned upsIDe-down when her parents divorced and her father moved from New York City to Wilmington, North Carolina. Three years later, she remains angry and alientated from her parents, especially her father...until her mother decIDes it would be in everyone's best interest if she spent the summer in Wilmington with him. Ronnie's father, a former concert pianist and teacher, is living a quiet life in the beach town, immersed in creating a work of art that will become the centerpiece of a local church.The tale that unfolds is an unforgettable story of love on many levels--first love, love between parents and children -- that demonstrates, as only a Nicholas Sparks novel can, the many ways that love can break our hearts...and heal them.", 1, "Romance", "English", 463, "NicolasSparks_The-Last-Song.jpg", 8.9800000000000004, 4, "Hachette Livre", 3.5, "Free", 10, "The Last Song", 1, 0.5, new DateTime(2010, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 10, "Dan Brown", "Paper", "Paperback", 7, "Thrillers", 100, "USA", new DateTime(2021, 4, 5, 19, 8, 36, 246, DateTimeKind.Local).AddTicks(2574), "4.28 x 7.54 x 1.33 inches", "#1 WORLDWIDE BESTSELLER Harvard professor of symbology Robert Langdon awakens in an Italian hospital, disoriented and with no recollection of the past thirty-six hours, including the origin of the macabre object hIDden in his belongings. With a relentless female assassin trailing them through Florence, he and his resourceful doctor, Sienna Brooks, are forced to flee. Embarking on a harrowing journey, they must unravel a series of codes, which are the work of a brilliant scientist whose obsession with the end of the world is matched only by his passion for one of the most influential masterpieces ever written, Dante Alighieri's \"The Inferno.\" Dan Brown has raised the bar yet again, combining classical Italian art, history, and literature with cutting-edge science in this sumptuously entertaining thriller.", 1, "Thriller", "English", 648, "Dan-Brown_Inferno.jpg", 5.9800000000000004, 6, "Macmillan Publishers", 3.5, "Free", 11, "Inferno", 1, 0.5, new DateTime(2014, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 1, "Agatha Christie", "Paper", "Paperback", 7, "Thrillers", 300, "UK", new DateTime(2021, 4, 5, 19, 8, 36, 246, DateTimeKind.Local).AddTicks(2579), "5.82 x 8.52 x 0.94 inches", "No Discription is available.", 1, "Thriller", "English", 256, "AgathaCristie_13_Problems.jpg", 17.48, 7, "Simon & Schuster", 3.5, "Free", 11, "The Thirteen Problems", 1, 0.34999999999999998, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 9, "Nicholas Sparks", "Paper", "Paperback", 1, "Fiction", 37, "UK", new DateTime(2021, 4, 5, 19, 8, 36, 246, DateTimeKind.Local).AddTicks(2561), "4.10 x 6.70 x 1.00 inches", "No Discription is available.", 1, "Romance", "English", 463, "NicolasSparks_Every13Breath.jpg", 8.9800000000000004, 4, "Hachette Livre", 3.5, "Free", 13, "Every Breath", 1, 0.5, new DateTime(2010, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 4, "J. K. Rowling", "Paper", "Paperback", 1, "Fiction", 131, "UK", new DateTime(2021, 4, 5, 19, 8, 36, 246, DateTimeKind.Local).AddTicks(2526), "4.45 x 7.01 x 0.87 inches", "The one that started the biggest publishing phenomenon of our time", 1, "Fiction", "English", 336, "Harry-Potter-and-the-Philosopher-s-Stone-Rowling-J-K.jpg", 9.9800000000000004, 1, "William Morrow Paperbacks", 3.5, "Free", 17, "Harry Potter and the Philosopher's Stone", 1, 0.34999999999999998, new DateTime(2004, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 11,
                column: "Name",
                value: "Uncategorised");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 1,
                column: "DateBirth",
                value: new DateTime(2021, 4, 2, 19, 3, 36, 488, DateTimeKind.Local).AddTicks(2708));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 2,
                column: "DateBirth",
                value: new DateTime(2021, 4, 2, 19, 3, 36, 490, DateTimeKind.Local).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateBirth", "ShortDiscription" },
                values: new object[] { new DateTime(2021, 4, 2, 19, 3, 36, 490, DateTimeKind.Local).AddTicks(250), "William Shakespeare (bapt. 26 April 1564 – 23 April 1616) was an English poet, playwright, and actor, widely regarded as the greatest writer in the English language and the world's greatest dramatist. He is often called England's national poet and the \"Bard of Avon\" (or simply \"the Bard\"). His extant works, including collaborations, consist of some 39 plays, 154 sonnets, two long narrative poems, and a few other verses, some of uncertain authorship. His plays have been translated into every major living language and are performed more often than those of any other playwright" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 4,
                column: "DateBirth",
                value: new DateTime(2021, 4, 2, 19, 3, 36, 490, DateTimeKind.Local).AddTicks(256));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 5,
                column: "DateBirth",
                value: new DateTime(2021, 4, 2, 19, 3, 36, 490, DateTimeKind.Local).AddTicks(259));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 6,
                column: "DateBirth",
                value: new DateTime(2021, 4, 2, 19, 3, 36, 490, DateTimeKind.Local).AddTicks(262));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateBirth", "ShortDiscription" },
                values: new object[] { new DateTime(2021, 4, 2, 19, 3, 36, 490, DateTimeKind.Local).AddTicks(265), "Jeffrey Howard Archer (born 15 April 1940) is an English novelist, former politician, convicted perjurer, and peer of the realm. Before becoming an author,Archer was a Member of Parliament(1969–1974), but did not seek re - election after a financial scandal that left him almost bankrupt.He revived his fortunes as a best - selling novelist; his books have sold around 330 million copies worldwide" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 8,
                column: "DateBirth",
                value: new DateTime(2021, 4, 2, 19, 3, 36, 490, DateTimeKind.Local).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 9,
                column: "DateBirth",
                value: new DateTime(2021, 4, 2, 19, 3, 36, 490, DateTimeKind.Local).AddTicks(271));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 10,
                column: "DateBirth",
                value: new DateTime(2021, 4, 2, 19, 3, 36, 490, DateTimeKind.Local).AddTicks(275));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "Discription" },
                values: new object[] { new DateTime(2021, 4, 2, 19, 3, 36, 490, DateTimeKind.Local).AddTicks(9642), "Book seed 1 Description" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "Discription" },
                values: new object[] { new DateTime(2021, 4, 2, 19, 3, 36, 491, DateTimeKind.Local).AddTicks(965), "Now a major motion picture starring Matthew McConaughey and Idris Elba. An impressive work of mythic magnitude that may turn out to be Stephen King's greatest literary achievement (The Atlanta Journal-Constitution), The Gunslinger is the first volume in the epic Dark Tower Series. A #1 national bestseller, The Gunslinger introduces readers to one of Stephen King's most powerful creations, Roland of Gilead: The Last Gunslinger. He is a haunting figure, a loner on a spellbinding journey into good and evil. In his desolate world, which mirrors our own in frightening ways, Roland tracks The Man in Black, encounters an enticing woman named Alice, and begins a friendship with the boy from New York named Jake. Inspired in part by the Robert Browning narrative poem,Childe Roland to the Dark Tower Came, The Gunslinger is a compelling whirlpool of a story that draws one irretrievable to its center ( Milwaukee Sentinel ). It is brilliant and fresh...and will leave you panting for more ( Booklist )." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "Discription" },
                values: new object[] { new DateTime(2021, 4, 2, 19, 3, 36, 491, DateTimeKind.Local).AddTicks(1002), "Once upon a time, in the haunted city of Derry (site of the classics \"It\" and \"Insomnia),\" four boys stood together and did a brave thing. Certainly a good thing, perhaps even a great thing. Something that changed them in ways they could never begin to understand. Twenty - five years later, the boys are now men with separate lives and separate troubles. But the ties endure. Each hunting season the foursome reunite in the woods of Maine. This year, a stranger stumbles into their camp, disoriented, mumbling something about lights in the sky. His incoherent ravings prove to be dis - turbingly prescient.Before long, these men will be plunged into a horrifying struggle with a creature from another world. Their only chance of survival is locked in their shared past-- and in the Dreamcatcher." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2021, 4, 2, 19, 3, 36, 491, DateTimeKind.Local).AddTicks(1008));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2021, 4, 2, 19, 3, 36, 491, DateTimeKind.Local).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2021, 4, 2, 19, 3, 36, 491, DateTimeKind.Local).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2021, 4, 2, 19, 3, 36, 491, DateTimeKind.Local).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "SoldItems" },
                values: new object[] { new DateTime(2021, 4, 2, 19, 3, 36, 491, DateTimeKind.Local).AddTicks(1024), 5 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 11,
                column: "Name",
                value: "Uncategorized");
        }
    }
}
