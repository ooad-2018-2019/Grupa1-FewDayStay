using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FewDayStay.Migrations
{
    public partial class PrvaMigracija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lokacija",
                columns: table => new
                {
                    LokacijaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Drzava = table.Column<string>(nullable: false),
                    Grad = table.Column<string>(nullable: false),
                    PostanskiBroj = table.Column<int>(nullable: false),
                    Adresa = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lokacija", x => x.LokacijaID);
                });

            migrationBuilder.CreateTable(
                name: "Osoba",
                columns: table => new
                {
                    OsobaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Sifra = table.Column<string>(nullable: false),
                    BrojTelefona = table.Column<string>(nullable: false),
                    Racun = table.Column<double>(nullable: false),
                    LokacijaID = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Osoba", x => x.OsobaID);
                    table.ForeignKey(
                        name: "FK_Osoba_Lokacija_LokacijaID",
                        column: x => x.LokacijaID,
                        principalTable: "Lokacija",
                        principalColumn: "LokacijaID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Objekat",
                columns: table => new
                {
                    ObjekatID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BrojKreveta = table.Column<int>(nullable: false),
                    Naziv = table.Column<string>(nullable: false),
                    Kvadratura = table.Column<int>(nullable: false),
                    CijenaPoNoci = table.Column<double>(nullable: false),
                    Ocjena = table.Column<double>(nullable: false),
                    VlasnikID = table.Column<int>(nullable: false),
                    LokacijaID = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    BrojSpratova = table.Column<int>(nullable: true),
                    ImaDvoriste = table.Column<bool>(nullable: true),
                    ImaBazen = table.Column<bool>(nullable: true),
                    BrojSprata = table.Column<int>(nullable: true),
                    ImeNaUlazu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objekat", x => x.ObjekatID);
                    table.ForeignKey(
                        name: "FK_Objekat_Lokacija_LokacijaID",
                        column: x => x.LokacijaID,
                        principalTable: "Lokacija",
                        principalColumn: "LokacijaID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Objekat_Osoba_VlasnikID",
                        column: x => x.VlasnikID,
                        principalTable: "Osoba",
                        principalColumn: "OsobaID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Iznajmljivanje",
                columns: table => new
                {
                    IznajmljivanjeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KorisnikID = table.Column<int>(nullable: false),
                    ObjekatID = table.Column<int>(nullable: false),
                    PocetniDatum = table.Column<DateTime>(nullable: false),
                    KrajnjiDatum = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iznajmljivanje", x => x.IznajmljivanjeID);
                    table.ForeignKey(
                        name: "FK_Iznajmljivanje_Osoba_KorisnikID",
                        column: x => x.KorisnikID,
                        principalTable: "Osoba",
                        principalColumn: "OsobaID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Iznajmljivanje_Objekat_ObjekatID",
                        column: x => x.ObjekatID,
                        principalTable: "Objekat",
                        principalColumn: "ObjekatID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Iznajmljivanje_KorisnikID",
                table: "Iznajmljivanje",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Iznajmljivanje_ObjekatID",
                table: "Iznajmljivanje",
                column: "ObjekatID");

            migrationBuilder.CreateIndex(
                name: "IX_Objekat_LokacijaID",
                table: "Objekat",
                column: "LokacijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Objekat_VlasnikID",
                table: "Objekat",
                column: "VlasnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Osoba_LokacijaID",
                table: "Osoba",
                column: "LokacijaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Iznajmljivanje");

            migrationBuilder.DropTable(
                name: "Objekat");

            migrationBuilder.DropTable(
                name: "Osoba");

            migrationBuilder.DropTable(
                name: "Lokacija");
        }
    }
}
