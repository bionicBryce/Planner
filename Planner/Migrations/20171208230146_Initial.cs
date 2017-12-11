using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Planner.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sacrament",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClosingHymn = table.Column<string>(nullable: true),
                    Conducting = table.Column<string>(nullable: true),
                    Convocation = table.Column<string>(nullable: true),
                    FirstSpeaker = table.Column<string>(nullable: true),
                    Invocation = table.Column<string>(nullable: true),
                    OpeningHymn = table.Column<string>(nullable: true),
                    RestHymn = table.Column<string>(nullable: true),
                    SacramentDate = table.Column<DateTime>(nullable: false),
                    SacramentHymn = table.Column<string>(nullable: true),
                    SecondSpeaker = table.Column<string>(nullable: true),
                    ThirdSeaker = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sacrament", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sacrament");
        }
    }
}
