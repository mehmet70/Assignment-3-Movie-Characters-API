using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment3.Migrations
{
    public partial class MovieSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Genre",
                table: "Movies",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Genre", "Picture", "ReleaseYear", "Title", "Trailer" },
                values: new object[,]
                {
                    { 1, "George Lucas", "Action,Adventure,Fantasy,Sci-Fi", "https://upload.wikimedia.org/wikipedia/en/4/40/Star_Wars_Phantom_Menace_poster.jpg?20181008114735", 1999, "Star Wars: Episode I - The Phantom Menace", "https://www.youtube.com/watch?v=bD7bpG-zDJQ" },
                    { 2, "George Lucas", "Action,Adventure,Fantasy,Sci-Fi", "https://upload.wikimedia.org/wikipedia/en/3/32/Star_Wars_-_Episode_II_Attack_of_the_Clones_%28movie_poster%29.jpg", 2002, "Star Wars: Episode II - Attack of the Clones", "https://www.youtube.com/watch?v=gYbW1F_c9eM" },
                    { 3, "George Lucas", "Action,Adventure,Fantasy,Sci-Fi", "https://upload.wikimedia.org/wikipedia/en/9/93/Star_Wars_Episode_III_Revenge_of_the_Sith_poster.jpg", 2005, "Star Wars: Episode III - Revenge of the Sith", "https://www.youtube.com/watch?v=5UnjrG_N8hU" },
                    { 4, "George Lucas", "Action,Adventure,Fantasy,Sci-Fi", "https://upload.wikimedia.org/wikipedia/en/4/40/Star_Wars_Phantom_Menace_poster.jpg?20181008114735", 1977, "Star Wars: Episode IV - A New Hope", "https://www.youtube.com/watch?v=vZ734NWnAHA" },
                    { 5, "Irvin Kershner", "Action,Adventure,Fantasy,Sci-Fi", "https://upload.wikimedia.org/wikipedia/en/4/40/Star_Wars_Phantom_Menace_poster.jpg?20181008114735", 1980, "Star Wars: Episode V - The Empire Strikes Back", "https://www.youtube.com/watch?v=JNwNXF9Y6kY" },
                    { 6, "Richard Marquand", "Action,Adventure,Fantasy,Sci-Fi", "https://upload.wikimedia.org/wikipedia/en/4/40/Star_Wars_Phantom_Menace_poster.jpg?20181008114735", 1983, "Star Wars: Episode VI - Return of the Jedi", "https://www.youtube.com/watch?v=XgB4gaY2dWE" },
                    { 7, "Peter Jackson", "Action,Adventure,Drama,Fantasy", "https://upload.wikimedia.org/wikipedia/en/8/8a/The_Lord_of_the_Rings_The_Fellowship_of_the_Ring_%282001%29.jpg", 2001, "The Lord of the Rings: The Fellowship of the Ring", "https://www.youtube.com/watch?v=_nZdmwHrcnw" },
                    { 8, "Peter Jackson", "Action,Adventure,Drama,Fantasy", "https://upload.wikimedia.org/wikipedia/en/d/d0/Lord_of_the_Rings_-_The_Two_Towers_%282002%29.jpg", 2002, "The Lord of the Rings: The Two Towers", "https://www.youtube.com/watch?v=nuTU5XcZTLA" },
                    { 9, "Peter Jackson", "Action,Adventure,Drama,Fantasy", "https://upload.wikimedia.org/wikipedia/en/b/be/The_Lord_of_the_Rings_-_The_Return_of_the_King_%282003%29.jpg", 2003, "The Lord of the Rings: The Fellowship of the Ring", "https://www.youtube.com/watch?v=zckJCxYxn1g" },
                    { 10, "Chris Columbus", "Comedy,Family", "https://upload.wikimedia.org/wikipedia/en/7/76/Home_alone_poster.jpg", 1990, "Home Alone", "https://www.youtube.com/watch?v=jEDaVHmw7r4" },
                    { 11, "Chris Columbus", "Comedy,Family", "https://upload.wikimedia.org/wikipedia/en/thumb/5/50/Home_Alone_2.jpg/220px-Home_Alone_2.jpg", 1992, "Home Alone 2: Lost in New York", "https://www.youtube.com/watch?v=5h9VDUNtoto" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.AlterColumn<string>(
                name: "Genre",
                table: "Movies",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);
        }
    }
}
