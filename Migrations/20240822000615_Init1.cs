using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Day6task.Migrations
{
    /// <inheritdoc />
    public partial class Init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    manager = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Isdeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    degree = table.Column<double>(type: "float", nullable: false),
                    mindegree = table.Column<double>(type: "float", nullable: false),
                    departmentid = table.Column<int>(type: "int", nullable: false),
                    Isdeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.id);
                    table.ForeignKey(
                        name: "FK_Courses_Departments_departmentid",
                        column: x => x.departmentid,
                        principalTable: "Departments",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Trainees",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    imageurl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    grade = table.Column<double>(type: "float", nullable: false),
                    departmentid = table.Column<int>(type: "int", nullable: false),
                    Isdeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainees", x => x.id);
                    table.ForeignKey(
                        name: "FK_Trainees_Departments_departmentid",
                        column: x => x.departmentid,
                        principalTable: "Departments",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    imageurl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    departmentid = table.Column<int>(type: "int", nullable: false),
                    courseid = table.Column<int>(type: "int", nullable: false),
                    Isdeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.id);
                    table.ForeignKey(
                        name: "FK_Instructors_Courses_courseid",
                        column: x => x.courseid,
                        principalTable: "Courses",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Instructors_Departments_departmentid",
                        column: x => x.departmentid,
                        principalTable: "Departments",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "courseResults",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    degree = table.Column<double>(type: "float", nullable: false),
                    courseid = table.Column<int>(type: "int", nullable: false),
                    traineeid = table.Column<int>(type: "int", nullable: false),
                    Isdeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courseResults", x => x.id);
                    table.ForeignKey(
                        name: "FK_courseResults_Courses_courseid",
                        column: x => x.courseid,
                        principalTable: "Courses",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_courseResults_Trainees_traineeid",
                        column: x => x.traineeid,
                        principalTable: "Trainees",
                        principalColumn: "id");
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "id", "Isdeleted", "Name", "manager" },
                values: new object[,]
                {
                    { 1, false, "dotnet", "rania mostafa" },
                    { 2, false, "devops", "ahmed mohsen" },
                    { 3, false, "AI", "yousef menesi" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "id", "Isdeleted", "degree", "departmentid", "mindegree", "name" },
                values: new object[,]
                {
                    { 1, false, 40.0, 1, 60.0, "C#" },
                    { 2, false, 30.0, 1, 40.0, "SQL" },
                    { 3, false, 60.0, 1, 80.0, "MCV" },
                    { 4, false, 40.0, 2, 60.0, "Docker" },
                    { 5, false, 30.0, 2, 40.0, "Kubernets" },
                    { 6, false, 60.0, 2, 80.0, "Ansible" },
                    { 7, false, 40.0, 3, 60.0, "deep learning" },
                    { 8, false, 30.0, 3, 40.0, "data structures" },
                    { 9, false, 60.0, 3, 80.0, "python" }
                });

            migrationBuilder.InsertData(
                table: "Trainees",
                columns: new[] { "id", "Isdeleted", "Name", "address", "departmentid", "grade", "imageurl" },
                values: new object[,]
                {
                    { 1, false, "adel hamdy ", "talkha", 1, 4.5, "10.jpg" },
                    { 2, false, "hussien kamel ", "talkha", 1, 4.0999999999999996, "11.jpg" },
                    { 3, false, "tarek mohamed ", "talkha", 1, 2.2999999999999998, "12.jpg" },
                    { 4, false, "omar nasif ", "talkha", 2, 2.5, "13.jpg" },
                    { 5, false, "layla nazmy ", "talkha", 2, 1.3, "14.jpg" },
                    { 6, false, "kadry mohamed ", "talkha", 3, 3.6000000000000001, "15.jpg" },
                    { 7, false, "adel tarek ", "talkha", 3, 4.7000000000000002, "16.jpg" },
                    { 8, false, "dena tawakol ", "talkha", 3, 4.9000000000000004, "17.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "id", "Isdeleted", "Name", "address", "courseid", "departmentid", "imageurl" },
                values: new object[,]
                {
                    { 1, false, "mohamed saber", "Sedi_Beshr Alex", 1, 1, "1.jpg" },
                    { 2, false, "mohamed hagar", " Elsheikh zayed", 2, 1, "2.jpg" },
                    { 3, false, "wael tabaey", "alzahraa - Nasr city", 3, 1, "3.jpg" },
                    { 4, false, "nada sadek", "Albahr al aazam", 4, 2, "4.jpg" },
                    { 5, false, "mahmoud mohamed", "Elgamalia", 5, 2, "5.jpg" },
                    { 6, false, "yasmeen nael", "Sedi_Beshr Alex", 6, 2, "6.jpg" },
                    { 7, false, "Ali Elgayar", "Albahr al aazam", 7, 3, "7.jpg" },
                    { 8, false, "khaled hanafy", "Sedi_Beshr Alex", 8, 3, "8.jpg" },
                    { 9, false, "mohamed nassem", "Albahr al aazam", 9, 3, "9.jpg" }
                });

            migrationBuilder.InsertData(
                table: "courseResults",
                columns: new[] { "id", "Isdeleted", "courseid", "degree", "traineeid" },
                values: new object[,]
                {
                    { 1, false, 1, 20.0, 1 },
                    { 2, false, 1, 59.0, 2 },
                    { 3, false, 1, 44.0, 3 },
                    { 4, false, 2, 20.0, 1 },
                    { 5, false, 2, 25.0, 2 },
                    { 6, false, 2, 39.0, 3 },
                    { 7, false, 3, 70.0, 1 },
                    { 8, false, 3, 30.0, 2 },
                    { 9, false, 3, 60.0, 3 },
                    { 10, false, 4, 20.0, 4 },
                    { 11, false, 4, 45.0, 5 },
                    { 12, false, 5, 35.0, 4 },
                    { 13, false, 5, 20.0, 5 },
                    { 14, false, 6, 76.0, 4 },
                    { 15, false, 6, 45.0, 5 },
                    { 16, false, 7, 20.0, 6 },
                    { 17, false, 7, 59.0, 7 },
                    { 18, false, 7, 44.0, 8 },
                    { 19, false, 8, 20.0, 6 },
                    { 20, false, 8, 25.0, 7 },
                    { 21, false, 8, 39.0, 8 },
                    { 22, false, 9, 70.0, 6 },
                    { 23, false, 9, 30.0, 7 },
                    { 24, false, 9, 60.0, 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_courseResults_courseid",
                table: "courseResults",
                column: "courseid");

            migrationBuilder.CreateIndex(
                name: "IX_courseResults_traineeid",
                table: "courseResults",
                column: "traineeid");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_departmentid",
                table: "Courses",
                column: "departmentid");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_courseid",
                table: "Instructors",
                column: "courseid");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_departmentid",
                table: "Instructors",
                column: "departmentid");

            migrationBuilder.CreateIndex(
                name: "IX_Trainees_departmentid",
                table: "Trainees",
                column: "departmentid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "courseResults");

            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropTable(
                name: "Trainees");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
