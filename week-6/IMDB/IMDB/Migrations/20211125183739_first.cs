using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace IMDB.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    CrewID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CrewName = table.Column<string>(type: "text", nullable: true),
                    CrewSurname = table.Column<string>(type: "text", nullable: true),
                    CrewAge = table.Column<int>(type: "int", nullable: false),
                    CrewBio = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.CrewID);
                });

            migrationBuilder.CreateTable(
                name: "Directors",
                columns: table => new
                {
                    ReviewID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ReviewPerson = table.Column<string>(type: "text", nullable: true),
                    ReviewText = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directors", x => x.ReviewID);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Writers",
                columns: table => new
                {
                    LocationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    LocationName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Writers", x => x.LocationID);
                });

            migrationBuilder.CreateTable(
                name: "CrewMovie",
                columns: table => new
                {
                    MovieActorsCrewID = table.Column<int>(type: "int", nullable: false),
                    MovieActorsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrewMovie", x => new { x.MovieActorsCrewID, x.MovieActorsId });
                    table.ForeignKey(
                        name: "FK_CrewMovie_Actors_MovieActorsCrewID",
                        column: x => x.MovieActorsCrewID,
                        principalTable: "Actors",
                        principalColumn: "CrewID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CrewMovie_Movies_MovieActorsId",
                        column: x => x.MovieActorsId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieReview",
                columns: table => new
                {
                    MovieReviewsId = table.Column<int>(type: "int", nullable: false),
                    MovieReviewsReviewID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieReview", x => new { x.MovieReviewsId, x.MovieReviewsReviewID });
                    table.ForeignKey(
                        name: "FK_MovieReview_Directors_MovieReviewsReviewID",
                        column: x => x.MovieReviewsReviewID,
                        principalTable: "Directors",
                        principalColumn: "ReviewID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieReview_Movies_MovieReviewsId",
                        column: x => x.MovieReviewsId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocationMovie",
                columns: table => new
                {
                    MovieLocationsId = table.Column<int>(type: "int", nullable: false),
                    MovieLocationsLocationID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationMovie", x => new { x.MovieLocationsId, x.MovieLocationsLocationID });
                    table.ForeignKey(
                        name: "FK_LocationMovie_Movies_MovieLocationsId",
                        column: x => x.MovieLocationsId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocationMovie_Writers_MovieLocationsLocationID",
                        column: x => x.MovieLocationsLocationID,
                        principalTable: "Writers",
                        principalColumn: "LocationID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CrewMovie_MovieActorsId",
                table: "CrewMovie",
                column: "MovieActorsId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationMovie_MovieLocationsLocationID",
                table: "LocationMovie",
                column: "MovieLocationsLocationID");

            migrationBuilder.CreateIndex(
                name: "IX_MovieReview_MovieReviewsReviewID",
                table: "MovieReview",
                column: "MovieReviewsReviewID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CrewMovie");

            migrationBuilder.DropTable(
                name: "LocationMovie");

            migrationBuilder.DropTable(
                name: "MovieReview");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Writers");

            migrationBuilder.DropTable(
                name: "Directors");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
