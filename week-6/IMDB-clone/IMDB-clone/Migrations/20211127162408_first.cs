using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IMDB_clone.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Crew",
                columns: table => new
                {
                    CrewID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    crewType = table.Column<int>(type: "int", nullable: false),
                    CrewName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CrewSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CrewAge = table.Column<int>(type: "int", nullable: false),
                    CrewBio = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crew", x => x.CrewID);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    LocationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocationID);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    ReviewID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReviewPerson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewText = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.ReviewID);
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
                        name: "FK_CrewMovie_Crew_MovieActorsCrewID",
                        column: x => x.MovieActorsCrewID,
                        principalTable: "Crew",
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
                        name: "FK_LocationMovie_Location_MovieLocationsLocationID",
                        column: x => x.MovieLocationsLocationID,
                        principalTable: "Location",
                        principalColumn: "LocationID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocationMovie_Movies_MovieLocationsId",
                        column: x => x.MovieLocationsId,
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
                        name: "FK_MovieReview_Movies_MovieReviewsId",
                        column: x => x.MovieReviewsId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieReview_Review_MovieReviewsReviewID",
                        column: x => x.MovieReviewsReviewID,
                        principalTable: "Review",
                        principalColumn: "ReviewID",
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
                name: "Crew");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Review");
        }
    }
}
