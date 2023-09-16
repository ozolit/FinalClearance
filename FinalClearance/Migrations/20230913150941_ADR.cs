using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalClearance.Migrations
{
    /// <inheritdoc />
    public partial class ADR : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ADMISSIONTYPE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ADMISSIONTYPE", x => x.Id);
                });

            //migrationBuilder.CreateTable(
            //    name: "AspNetRoles",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
            //        NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
            //        ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetRoles", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetUsers",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //        FirstName = table.Column<string>(type: "nvarchar(100)", nullable: true),
            //        LastName = table.Column<string>(type: "nvarchar(100)", nullable: true),
            //        UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
            //        NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
            //        Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
            //        NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
            //        EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
            //        PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
            //        TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
            //        LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
            //        LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
            //        AccessFailedCount = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUsers", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "FACULTY",
            //    columns: table => new
            //    {
            //        Id = table.Column<long>(type: "bigint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_FACULTY", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "FEETYPE",
            //    columns: table => new
            //    {
            //        Id = table.Column<long>(type: "bigint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_FEETYPE", x => x.Id);
            //    });

            migrationBuilder.CreateTable(
                name: "GENDER",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GENDER", x => x.Id);
                });

            //migrationBuilder.CreateTable(
            //    name: "LEVEL",
            //    columns: table => new
            //    {
            //        Id = table.Column<long>(type: "bigint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_LEVEL", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "PERSONTYPE",
            //    columns: table => new
            //    {
            //        Id = table.Column<long>(type: "bigint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_PERSONTYPE", x => x.Id);
            //    });

            migrationBuilder.CreateTable(
                name: "RELATIONSHIP",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RELATIONSHIP", x => x.Id);
                });

            //migrationBuilder.CreateTable(
            //    name: "SEMESTER",
            //    columns: table => new
            //    {
            //        Id = table.Column<long>(type: "bigint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SEMESTER", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SESSION",
            //    columns: table => new
            //    {
            //        Id = table.Column<long>(type: "bigint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SESSION", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetRoleClaims",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //        ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
            //            column: x => x.RoleId,
            //            principalTable: "AspNetRoles",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetUserClaims",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //        ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_AspNetUserClaims_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetUserLogins",
            //    columns: table => new
            //    {
            //        LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
            //        ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
            //        ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
            //        table.ForeignKey(
            //            name: "FK_AspNetUserLogins_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetUserRoles",
            //    columns: table => new
            //    {
            //        UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //        RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
            //        table.ForeignKey(
            //            name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
            //            column: x => x.RoleId,
            //            principalTable: "AspNetRoles",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_AspNetUserRoles_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetUserTokens",
            //    columns: table => new
            //    {
            //        UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //        LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
            //        Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
            //        table.ForeignKey(
            //            name: "FK_AspNetUserTokens_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "DEPARTMENT",
            //    columns: table => new
            //    {
            //        Id = table.Column<long>(type: "bigint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        FacultyId = table.Column<long>(type: "bigint", nullable: false),
            //        DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_DEPARTMENT", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_DEPARTMENT_FACULTY_FacultyId",
            //            column: x => x.FacultyId,
            //            principalTable: "FACULTY",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "PROGRAMME",
            //    columns: table => new
            //    {
            //        Id = table.Column<long>(type: "bigint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        FacultyId = table.Column<long>(type: "bigint", nullable: false),
            //        DepartmentId = table.Column<long>(type: "bigint", nullable: false),
            //        DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_PROGRAMME", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_PROGRAMME_DEPARTMENT_DepartmentId",
            //            column: x => x.DepartmentId,
            //            principalTable: "DEPARTMENT",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_PROGRAMME_FACULTY_FacultyId",
            //            column: x => x.FacultyId,
            //            principalTable: "FACULTY",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "PERSON",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        RegNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        OtherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        AdmissionTypeId = table.Column<int>(type: "int", nullable: true),
            //        SemesterId = table.Column<long>(type: "bigint", nullable: true),
            //        SessionId = table.Column<long>(type: "bigint", nullable: true),
            //        LevelId = table.Column<long>(type: "bigint", nullable: true),
            //        FacultyId = table.Column<long>(type: "bigint", nullable: true),
            //        DepartmentId = table.Column<long>(type: "bigint", nullable: true),
            //        ProgrammeId = table.Column<long>(type: "bigint", nullable: true),
            //        personTypeId = table.Column<long>(type: "bigint", nullable: true),
            //        NextOfKinName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        NextOfKinPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        NextOfKinAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        NextOfKinRelationship = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_PERSON", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_PERSON_ADMISSIONTYPE_AdmissionTypeId",
            //            column: x => x.AdmissionTypeId,
            //            principalTable: "ADMISSIONTYPE",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_PERSON_DEPARTMENT_DepartmentId",
            //            column: x => x.DepartmentId,
            //            principalTable: "DEPARTMENT",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_PERSON_FACULTY_FacultyId",
            //            column: x => x.FacultyId,
            //            principalTable: "FACULTY",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_PERSON_LEVEL_LevelId",
            //            column: x => x.LevelId,
            //            principalTable: "LEVEL",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_PERSON_PERSONTYPE_personTypeId",
            //            column: x => x.personTypeId,
            //            principalTable: "PERSONTYPE",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_PERSON_PROGRAMME_ProgrammeId",
            //            column: x => x.ProgrammeId,
            //            principalTable: "PROGRAMME",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_PERSON_SEMESTER_SemesterId",
            //            column: x => x.SemesterId,
            //            principalTable: "SEMESTER",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_PERSON_SESSION_SessionId",
            //            column: x => x.SessionId,
            //            principalTable: "SESSION",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "STUDENTRECEIPT",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        PersonId = table.Column<int>(type: "int", nullable: false),
            //        LevelId = table.Column<long>(type: "bigint", nullable: true),
            //        FeeTypeId = table.Column<long>(type: "bigint", nullable: true),
            //        IsFullTuition = table.Column<bool>(type: "bit", nullable: false),
            //        SemesterId = table.Column<long>(type: "bigint", nullable: true),
            //        SessionId = table.Column<long>(type: "bigint", nullable: true),
            //        CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        LastEdited = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        IsAproved = table.Column<bool>(type: "bit", nullable: false),
            //        IsReceiptViewed = table.Column<bool>(type: "bit", nullable: false),
            //        ApprovedById = table.Column<int>(type: "int", nullable: true),
            //        Approved = table.Column<DateTime>(type: "datetime2", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_STUDENTRECEIPT", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_STUDENTRECEIPT_FEETYPE_FeeTypeId",
            //            column: x => x.FeeTypeId,
            //            principalTable: "FEETYPE",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_STUDENTRECEIPT_LEVEL_LevelId",
            //            column: x => x.LevelId,
            //            principalTable: "LEVEL",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_STUDENTRECEIPT_PERSON_ApprovedById",
            //            column: x => x.ApprovedById,
            //            principalTable: "PERSON",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_STUDENTRECEIPT_PERSON_PersonId",
            //            column: x => x.PersonId,
            //            principalTable: "PERSON",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_STUDENTRECEIPT_SEMESTER_SemesterId",
            //            column: x => x.SemesterId,
            //            principalTable: "SEMESTER",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_STUDENTRECEIPT_SESSION_SessionId",
            //            column: x => x.SessionId,
            //            principalTable: "SESSION",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "CORMMENT",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        StudentReceiptId = table.Column<int>(type: "int", nullable: false),
            //        IsCommentRead = table.Column<bool>(type: "bit", nullable: false),
            //        CommentedById = table.Column<int>(type: "int", nullable: true),
            //        Commented = table.Column<DateTime>(type: "datetime2", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_CORMMENT", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_CORMMENT_PERSON_CommentedById",
            //            column: x => x.CommentedById,
            //            principalTable: "PERSON",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_CORMMENT_STUDENTRECEIPT_StudentReceiptId",
            //            column: x => x.StudentReceiptId,
            //            principalTable: "STUDENTRECEIPT",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

        //    migrationBuilder.CreateIndex(
        //        name: "IX_AspNetRoleClaims_RoleId",
        //        table: "AspNetRoleClaims",
        //        column: "RoleId");

        //    migrationBuilder.CreateIndex(
        //        name: "RoleNameIndex",
        //        table: "AspNetRoles",
        //        column: "NormalizedName",
        //        unique: true,
        //        filter: "[NormalizedName] IS NOT NULL");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_AspNetUserClaims_UserId",
        //        table: "AspNetUserClaims",
        //        column: "UserId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_AspNetUserLogins_UserId",
        //        table: "AspNetUserLogins",
        //        column: "UserId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_AspNetUserRoles_RoleId",
        //        table: "AspNetUserRoles",
        //        column: "RoleId");

        //    migrationBuilder.CreateIndex(
        //        name: "EmailIndex",
        //        table: "AspNetUsers",
        //        column: "NormalizedEmail");

        //    migrationBuilder.CreateIndex(
        //        name: "UserNameIndex",
        //        table: "AspNetUsers",
        //        column: "NormalizedUserName",
        //        unique: true,
        //        filter: "[NormalizedUserName] IS NOT NULL");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_CORMMENT_CommentedById",
        //        table: "CORMMENT",
        //        column: "CommentedById");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_CORMMENT_StudentReceiptId",
        //        table: "CORMMENT",
        //        column: "StudentReceiptId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_DEPARTMENT_FacultyId",
        //        table: "DEPARTMENT",
        //        column: "FacultyId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_PERSON_AdmissionTypeId",
        //        table: "PERSON",
        //        column: "AdmissionTypeId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_PERSON_DepartmentId",
        //        table: "PERSON",
        //        column: "DepartmentId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_PERSON_FacultyId",
        //        table: "PERSON",
        //        column: "FacultyId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_PERSON_LevelId",
        //        table: "PERSON",
        //        column: "LevelId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_PERSON_personTypeId",
        //        table: "PERSON",
        //        column: "personTypeId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_PERSON_ProgrammeId",
        //        table: "PERSON",
        //        column: "ProgrammeId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_PERSON_SemesterId",
        //        table: "PERSON",
        //        column: "SemesterId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_PERSON_SessionId",
        //        table: "PERSON",
        //        column: "SessionId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_PROGRAMME_DepartmentId",
        //        table: "PROGRAMME",
        //        column: "DepartmentId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_PROGRAMME_FacultyId",
        //        table: "PROGRAMME",
        //        column: "FacultyId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_STUDENTRECEIPT_ApprovedById",
        //        table: "STUDENTRECEIPT",
        //        column: "ApprovedById");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_STUDENTRECEIPT_FeeTypeId",
        //        table: "STUDENTRECEIPT",
        //        column: "FeeTypeId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_STUDENTRECEIPT_LevelId",
        //        table: "STUDENTRECEIPT",
        //        column: "LevelId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_STUDENTRECEIPT_PersonId",
        //        table: "STUDENTRECEIPT",
        //        column: "PersonId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_STUDENTRECEIPT_SemesterId",
        //        table: "STUDENTRECEIPT",
        //        column: "SemesterId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_STUDENTRECEIPT_SessionId",
        //        table: "STUDENTRECEIPT",
        //        column: "SessionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CORMMENT");

            migrationBuilder.DropTable(
                name: "GENDER");

            migrationBuilder.DropTable(
                name: "RELATIONSHIP");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "STUDENTRECEIPT");

            migrationBuilder.DropTable(
                name: "FEETYPE");

            migrationBuilder.DropTable(
                name: "PERSON");

            migrationBuilder.DropTable(
                name: "ADMISSIONTYPE");

            migrationBuilder.DropTable(
                name: "LEVEL");

            migrationBuilder.DropTable(
                name: "PERSONTYPE");

            migrationBuilder.DropTable(
                name: "PROGRAMME");

            migrationBuilder.DropTable(
                name: "SEMESTER");

            migrationBuilder.DropTable(
                name: "SESSION");

            migrationBuilder.DropTable(
                name: "DEPARTMENT");

            migrationBuilder.DropTable(
                name: "FACULTY");
        }
    }
}
