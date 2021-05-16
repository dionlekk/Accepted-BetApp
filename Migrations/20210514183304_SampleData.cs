using Microsoft.EntityFrameworkCore.Migrations;

namespace BetApp.Migrations
{
    public partial class SampleData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Odd",
                table: "MatchOdds",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "MatchId", "Description", "MatchDate", "MatchTime", "Sport", "TeamA", "TeamB" },
                values: new object[] { 1, "OSFP-PAO", "19/03/2021", "15:00", "1", "OSFP", "PAO" });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "MatchId", "Description", "MatchDate", "MatchTime", "Sport", "TeamA", "TeamB" },
                values: new object[] { 2, "AEK-PAOK", "20/03/2021", "17:00", "2", "AEK", "PAOK" });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "MatchId", "Description", "MatchDate", "MatchTime", "Sport", "TeamA", "TeamB" },
                values: new object[] { 3, "ARIS-PAOK", "21/03/2021", "21:00", "1", "ARIS", "PAOK" });

            migrationBuilder.InsertData(
                table: "MatchOdds",
                columns: new[] { "MatchOddId", "MatchId", "Odd", "Specifier" },
                values: new object[] { 1, 1, 2.0, "X" });

            migrationBuilder.InsertData(
                table: "MatchOdds",
                columns: new[] { "MatchOddId", "MatchId", "Odd", "Specifier" },
                values: new object[] { 2, 2, 2.0, "1" });

            migrationBuilder.InsertData(
                table: "MatchOdds",
                columns: new[] { "MatchOddId", "MatchId", "Odd", "Specifier" },
                values: new object[] { 3, 3, 2.0, "X" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "MatchOddId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "MatchOddId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "MatchOddId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "MatchId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "MatchId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "MatchId",
                keyValue: 3);

            migrationBuilder.AlterColumn<int>(
                name: "Odd",
                table: "MatchOdds",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
