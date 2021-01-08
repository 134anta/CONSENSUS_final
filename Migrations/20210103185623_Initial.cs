using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI_Consensus.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProduccionDiaria",
                columns: table => new
                {
                    idProd = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cuadradoQty = table.Column<int>(type: "int", nullable: false),
                    rectanguloQty = table.Column<int>(type: "int", nullable: false),
                    trianguloQty = table.Column<int>(type: "int", nullable: false),
                    circuloQty = table.Column<int>(type: "int", nullable: false),
                    produccionGenerada = table.Column<int>(type: "int", nullable: false),
                    fechaProd = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProduccionDiaria", x => x.idProd);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProduccionDiaria");
        }
    }
}
