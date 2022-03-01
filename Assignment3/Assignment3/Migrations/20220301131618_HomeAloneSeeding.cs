using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment3.Migrations
{
    public partial class HomeAloneSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Alias", "Gender", "Name", "Picture" },
                values: new object[] { 7, null, "Male", "Kevin McCallister", "https://images0.persgroep.net/rcs/OEtfvPQu1Jbi2gg2oWKZcKcbxOM/diocontent/109256902/_fill/597/900/?appId=21791a8992982cd8da851550a453bd7f&quality=0.9" });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Alias", "Gender", "Name", "Picture" },
                values: new object[] { 8, "Wet Bandit", "Male", "Harry Lyme", "https://www.nme.com/wp-content/uploads/2016/09/2015_HomeAlone_13_111615-2.jpg" });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Alias", "Gender", "Name", "Picture" },
                values: new object[] { 9, "Wet Bandit", "Male", "Marv Murchins", "https://www.cheatsheet.com/wp-content/uploads/2017/12/home-alone-iron.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
