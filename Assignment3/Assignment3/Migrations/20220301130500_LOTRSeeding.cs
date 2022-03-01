using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment3.Migrations
{
    public partial class LOTRSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Alias", "Gender", "Name", "Picture" },
                values: new object[] { 4, null, "Male", "Bilbo Baggins", "https://static3.srcdn.com/wordpress/wp-content/uploads/2018/01/Bilbo-in-Fellowship-of-the-Ring.jpg" });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Alias", "Gender", "Name", "Picture" },
                values: new object[] { 5, null, "Male", "Frodo Baggins", "https://en.meming.world/images/en/8/8e/All_Right_Then%2C_Keep_Your_Secrets.jpg" });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Alias", "Gender", "Name", "Picture" },
                values: new object[] { 6, "Gollum", "Gollum", "Sméagol", "https://i.kym-cdn.com/entries/icons/original/000/019/367/gollum_395_394.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
