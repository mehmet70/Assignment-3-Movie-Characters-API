using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment3.Migrations
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Alias = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Picture = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Franchises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Franchises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ReleaseYear = table.Column<int>(type: "int", nullable: false),
                    Director = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Picture = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Trailer = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    FranchiseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Franchises_FranchiseId",
                        column: x => x.FranchiseId,
                        principalTable: "Franchises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CharacterMovie",
                columns: table => new
                {
                    MoviesId = table.Column<int>(type: "int", nullable: false),
                    CharactersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterMovie", x => new { x.MoviesId, x.CharactersId });
                    table.ForeignKey(
                        name: "FK_CharacterMovie_Characters_CharactersId",
                        column: x => x.CharactersId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterMovie_Movies_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Alias", "Gender", "Name", "Picture" },
                values: new object[,]
                {
                    { 1, "Darth Vader", "Male", "Anakin Skywalker", "https://img.buzzfeed.com/buzzfeed-static/static/2017-04/16/12/asset/buzzfeed-prod-fastlane-02/sub-buzz-24075-1492359365-1.jpg" },
                    { 2, null, "Male", "Luke Skywalker", "https://www.meme-arsenal.com/memes/c8e524b0b8bdcaed3b70bb345cd0e908.jpg" },
                    { 3, "Ben Kenobi", "Male", "Obi-Wan Kenobi", "https://i.kym-cdn.com/entries/icons/mobile/000/024/965/well.jpg" },
                    { 4, null, "Male", "Bilbo Baggins", "https://static3.srcdn.com/wordpress/wp-content/uploads/2018/01/Bilbo-in-Fellowship-of-the-Ring.jpg" },
                    { 5, null, "Male", "Frodo Baggins", "https://en.meming.world/images/en/8/8e/All_Right_Then%2C_Keep_Your_Secrets.jpg" },
                    { 6, "Gollum", "Gollum", "Sméagol", "https://i.kym-cdn.com/entries/icons/original/000/019/367/gollum_395_394.jpg" },
                    { 7, null, "Male", "Kevin McCallister", "https://images0.persgroep.net/rcs/OEtfvPQu1Jbi2gg2oWKZcKcbxOM/diocontent/109256902/_fill/597/900/?appId=21791a8992982cd8da851550a453bd7f&quality=0.9" },
                    { 8, "Wet Bandit", "Male", "Harry Lyme", "https://www.nme.com/wp-content/uploads/2016/09/2015_HomeAlone_13_111615-2.jpg" },
                    { 9, "Wet Bandit", "Male", "Marv Murchins", "https://www.cheatsheet.com/wp-content/uploads/2017/12/home-alone-iron.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Franchises",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Star Wars is an American epic space opera multimedia franchise created by George Lucas, which began with the eponymous 1977 film and quickly became a worldwide pop-culture phenomenon. The franchise has been expanded into various films and other media, including television series, video games, novels, comic books, theme park attractions, and themed areas, comprising an all-encompassing fictional universe.", "Star Wars" },
                    { 2, "The Lord of the Rings is a series of three epic fantasy adventure films directed by Peter Jackson, based on the novel written by J. R. R. Tolkien. The films are subtitled The Fellowship of the Ring (2001), The Two Towers (2002), and The Return of the King (2003). Produced and distributed by New Line Cinema with the co-production of WingNut Films, it is an international venture between New Zealand and the United States. The films feature an ensemble cast including Elijah Wood, Ian McKellen, Liv Tyler, Viggo Mortensen, Sean Astin, Cate Blanchett, John Rhys-Davies, Christopher Lee, Billy Boyd, Dominic Monaghan, Orlando Bloom, Hugo Weaving, Andy Serkis and Sean Bean.", "The Lord of the Rings" },
                    { 3, "Home Alone is a series of American Christmas family comedy films originally created by John Hughes, and directed by Chris Columbus (1 and 2), Raja Gosnell (3), Rod Daniel (4), Peter Hewitt (5), and Dan Mazer (6). The films revolve around the adventures surrounding children who find themselves alone during the holiday season and are faced with the challenge of defending their family's house or themselves from invading burglars and criminals.", "Home Alone" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "FranchiseId", "Genre", "Picture", "ReleaseYear", "Title", "Trailer" },
                values: new object[,]
                {
                    { 1, "George Lucas", 1, "Action,Adventure,Fantasy,Sci-Fi", "https://upload.wikimedia.org/wikipedia/en/4/40/Star_Wars_Phantom_Menace_poster.jpg?20181008114735", 1999, "Star Wars: Episode I - The Phantom Menace", "https://www.youtube.com/watch?v=bD7bpG-zDJQ" },
                    { 2, "George Lucas", 1, "Action,Adventure,Fantasy,Sci-Fi", "https://upload.wikimedia.org/wikipedia/en/3/32/Star_Wars_-_Episode_II_Attack_of_the_Clones_%28movie_poster%29.jpg", 2002, "Star Wars: Episode II - Attack of the Clones", "https://www.youtube.com/watch?v=gYbW1F_c9eM" },
                    { 3, "George Lucas", 1, "Action,Adventure,Fantasy,Sci-Fi", "https://upload.wikimedia.org/wikipedia/en/9/93/Star_Wars_Episode_III_Revenge_of_the_Sith_poster.jpg", 2005, "Star Wars: Episode III - Revenge of the Sith", "https://www.youtube.com/watch?v=5UnjrG_N8hU" },
                    { 4, "George Lucas", 1, "Action,Adventure,Fantasy,Sci-Fi", "https://upload.wikimedia.org/wikipedia/en/4/40/Star_Wars_Phantom_Menace_poster.jpg?20181008114735", 1977, "Star Wars: Episode IV - A New Hope", "https://www.youtube.com/watch?v=vZ734NWnAHA" },
                    { 5, "Irvin Kershner", 1, "Action,Adventure,Fantasy,Sci-Fi", "https://upload.wikimedia.org/wikipedia/en/4/40/Star_Wars_Phantom_Menace_poster.jpg?20181008114735", 1980, "Star Wars: Episode V - The Empire Strikes Back", "https://www.youtube.com/watch?v=JNwNXF9Y6kY" },
                    { 6, "Richard Marquand", 1, "Action,Adventure,Fantasy,Sci-Fi", "https://upload.wikimedia.org/wikipedia/en/4/40/Star_Wars_Phantom_Menace_poster.jpg?20181008114735", 1983, "Star Wars: Episode VI - Return of the Jedi", "https://www.youtube.com/watch?v=XgB4gaY2dWE" },
                    { 7, "Peter Jackson", 2, "Action,Adventure,Drama,Fantasy", "https://upload.wikimedia.org/wikipedia/en/8/8a/The_Lord_of_the_Rings_The_Fellowship_of_the_Ring_%282001%29.jpg", 2001, "The Lord of the Rings: The Fellowship of the Ring", "https://www.youtube.com/watch?v=_nZdmwHrcnw" },
                    { 8, "Peter Jackson", 2, "Action,Adventure,Drama,Fantasy", "https://upload.wikimedia.org/wikipedia/en/d/d0/Lord_of_the_Rings_-_The_Two_Towers_%282002%29.jpg", 2002, "The Lord of the Rings: The Two Towers", "https://www.youtube.com/watch?v=nuTU5XcZTLA" },
                    { 9, "Peter Jackson", 2, "Action,Adventure,Drama,Fantasy", "https://upload.wikimedia.org/wikipedia/en/b/be/The_Lord_of_the_Rings_-_The_Return_of_the_King_%282003%29.jpg", 2003, "The Lord of the Rings: The Fellowship of the Ring", "https://www.youtube.com/watch?v=zckJCxYxn1g" },
                    { 10, "Chris Columbus", 3, "Comedy,Family", "https://upload.wikimedia.org/wikipedia/en/7/76/Home_alone_poster.jpg", 1990, "Home Alone", "https://www.youtube.com/watch?v=jEDaVHmw7r4" },
                    { 11, "Chris Columbus", 3, "Adventure,Comedy,Crime,Family", "https://upload.wikimedia.org/wikipedia/en/thumb/5/50/Home_Alone_2.jpg/220px-Home_Alone_2.jpg", 1992, "Home Alone 2: Lost in New York", "https://www.youtube.com/watch?v=5h9VDUNtoto" }
                });

            migrationBuilder.InsertData(
                table: "CharacterMovie",
                columns: new[] { "CharactersId", "MoviesId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 7, 11 },
                    { 9, 10 },
                    { 8, 10 },
                    { 7, 10 },
                    { 6, 9 },
                    { 5, 9 },
                    { 4, 9 },
                    { 6, 8 },
                    { 5, 8 },
                    { 6, 7 },
                    { 5, 7 },
                    { 4, 7 },
                    { 3, 6 },
                    { 2, 6 },
                    { 1, 6 },
                    { 3, 5 },
                    { 2, 5 },
                    { 1, 5 },
                    { 3, 4 },
                    { 2, 4 },
                    { 1, 4 },
                    { 3, 3 },
                    { 2, 3 },
                    { 1, 3 },
                    { 3, 2 },
                    { 1, 2 },
                    { 3, 1 },
                    { 8, 11 },
                    { 9, 11 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterMovie_CharactersId",
                table: "CharacterMovie",
                column: "CharactersId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_FranchiseId",
                table: "Movies",
                column: "FranchiseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterMovie");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Franchises");
        }
    }
}
