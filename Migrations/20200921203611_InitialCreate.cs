using Microsoft.EntityFrameworkCore.Migrations;

namespace Tankop.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tanks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(nullable: true),
                    Class = table.Column<string>(nullable: true),
                    Tier = table.Column<int>(nullable: false),
                    TankName = table.Column<string>(nullable: true),
                    HitPoints = table.Column<int>(nullable: false),
                    ROF = table.Column<float>(nullable: false),
                    AimTime = table.Column<float>(nullable: false),
                    Accuracy = table.Column<float>(nullable: false),
                    AvgPenetration = table.Column<int>(nullable: false),
                    AvgDamage = table.Column<int>(nullable: false),
                    Dpm = table.Column<float>(nullable: false),
                    HullArmor = table.Column<string>(nullable: true),
                    TurretArmor = table.Column<string>(nullable: true),
                    ImgSrc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tanks", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tanks");
        }
    }
}
