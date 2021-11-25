using Microsoft.EntityFrameworkCore.Migrations;

namespace IMDB.Migrations
{
    public partial class change : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CrewMovie_Actors_MovieActorsCrewID",
                table: "CrewMovie");

            migrationBuilder.DropForeignKey(
                name: "FK_LocationMovie_Writers_MovieLocationsLocationID",
                table: "LocationMovie");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieReview_Directors_MovieReviewsReviewID",
                table: "MovieReview");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Writers",
                table: "Writers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Directors",
                table: "Directors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actors",
                table: "Actors");

            migrationBuilder.RenameTable(
                name: "Writers",
                newName: "Location");

            migrationBuilder.RenameTable(
                name: "Directors",
                newName: "Review");

            migrationBuilder.RenameTable(
                name: "Actors",
                newName: "Crew");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Location",
                table: "Location",
                column: "LocationID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Review",
                table: "Review",
                column: "ReviewID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Crew",
                table: "Crew",
                column: "CrewID");

            migrationBuilder.AddForeignKey(
                name: "FK_CrewMovie_Crew_MovieActorsCrewID",
                table: "CrewMovie",
                column: "MovieActorsCrewID",
                principalTable: "Crew",
                principalColumn: "CrewID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LocationMovie_Location_MovieLocationsLocationID",
                table: "LocationMovie",
                column: "MovieLocationsLocationID",
                principalTable: "Location",
                principalColumn: "LocationID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieReview_Review_MovieReviewsReviewID",
                table: "MovieReview",
                column: "MovieReviewsReviewID",
                principalTable: "Review",
                principalColumn: "ReviewID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CrewMovie_Crew_MovieActorsCrewID",
                table: "CrewMovie");

            migrationBuilder.DropForeignKey(
                name: "FK_LocationMovie_Location_MovieLocationsLocationID",
                table: "LocationMovie");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieReview_Review_MovieReviewsReviewID",
                table: "MovieReview");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Review",
                table: "Review");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Location",
                table: "Location");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Crew",
                table: "Crew");

            migrationBuilder.RenameTable(
                name: "Review",
                newName: "Directors");

            migrationBuilder.RenameTable(
                name: "Location",
                newName: "Writers");

            migrationBuilder.RenameTable(
                name: "Crew",
                newName: "Actors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Directors",
                table: "Directors",
                column: "ReviewID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Writers",
                table: "Writers",
                column: "LocationID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actors",
                table: "Actors",
                column: "CrewID");

            migrationBuilder.AddForeignKey(
                name: "FK_CrewMovie_Actors_MovieActorsCrewID",
                table: "CrewMovie",
                column: "MovieActorsCrewID",
                principalTable: "Actors",
                principalColumn: "CrewID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LocationMovie_Writers_MovieLocationsLocationID",
                table: "LocationMovie",
                column: "MovieLocationsLocationID",
                principalTable: "Writers",
                principalColumn: "LocationID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieReview_Directors_MovieReviewsReviewID",
                table: "MovieReview",
                column: "MovieReviewsReviewID",
                principalTable: "Directors",
                principalColumn: "ReviewID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
