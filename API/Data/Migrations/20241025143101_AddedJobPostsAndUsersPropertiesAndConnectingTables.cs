using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedJobPostsAndUsersPropertiesAndConnectingTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_AspNetUsers_AppUserId",
                table: "Documents");

            migrationBuilder.RenameColumn(
                name: "LookingFor",
                table: "AspNetUsers",
                newName: "ProfileMinifiedUrl");

            migrationBuilder.RenameColumn(
                name: "Interests",
                table: "AspNetUsers",
                newName: "PreferedTimezones");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "AspNetUsers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "AspNetUsers",
                newName: "FirstName");

            migrationBuilder.AlterColumn<int>(
                name: "AppUserId",
                table: "Documents",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "JobPostId",
                table: "Documents",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "AspNetUsers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "CityOfResidency",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CountryOfResidency",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateOnly>(
                name: "DateAvailable",
                table: "AspNetUsers",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailNotifications",
                table: "AspNetUsers",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Hobbies",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdentificationDocumentNumber",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdentificationDocumentType",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "IdentificationDocumentValidity",
                table: "AspNetUsers",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdentityHash",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IndexClusterId",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsAvailable",
                table: "AspNetUsers",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsOnAutoMessage",
                table: "AspNetUsers",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsOnAutoSelection",
                table: "AspNetUsers",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsRecruiter",
                table: "AspNetUsers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "JobPostId",
                table: "AspNetUsers",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Locations",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nationality",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PreferredAgreementType",
                table: "AspNetUsers",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SalaryExpectationsAnnually",
                table: "AspNetUsers",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SalaryExpectationsDaily",
                table: "AspNetUsers",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SalaryExpectationsHourly",
                table: "AspNetUsers",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "YearsOfExperience",
                table: "AspNetUsers",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isRemote",
                table: "AspNetUsers",
                type: "boolean",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Badges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BadgeName = table.Column<string>(type: "text", nullable: false),
                    BadgeDescription = table.Column<string>(type: "text", nullable: true),
                    BadgeIcon = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Badges", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Education",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    YearStart = table.Column<int>(type: "integer", nullable: false),
                    MonthStart = table.Column<int>(type: "integer", nullable: false),
                    YearEnd = table.Column<int>(type: "integer", nullable: true),
                    MonthEnd = table.Column<int>(type: "integer", nullable: true),
                    Title = table.Column<string>(type: "text", nullable: false),
                    InstitutionName = table.Column<string>(type: "text", nullable: false),
                    CourseName = table.Column<string>(type: "text", nullable: true),
                    Url = table.Column<string>(type: "text", nullable: false),
                    IsOngoing = table.Column<bool>(type: "boolean", nullable: true),
                    AppUserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Education", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Education_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    YearStart = table.Column<int>(type: "integer", nullable: false),
                    MonthStart = table.Column<int>(type: "integer", nullable: false),
                    YearEnd = table.Column<int>(type: "integer", nullable: true),
                    MonthEnd = table.Column<int>(type: "integer", nullable: true),
                    Title = table.Column<string>(type: "text", nullable: false),
                    CompanyName = table.Column<string>(type: "text", nullable: false),
                    CompanyUrl = table.Column<string>(type: "text", nullable: false),
                    IsOngoing = table.Column<bool>(type: "boolean", nullable: true),
                    AppUserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employment_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobPosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedDateUtc = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDateUtc = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<int>(type: "integer", nullable: false),
                    SelectedCandidateId = table.Column<int>(type: "integer", nullable: true),
                    ApplyUrl = table.Column<string>(type: "text", nullable: true),
                    Position = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    HowToApply = table.Column<string>(type: "text", nullable: true),
                    CompanyName = table.Column<string>(type: "text", nullable: true),
                    CompanyUrl = table.Column<string>(type: "text", nullable: true),
                    OnSiteRemoteHybrid = table.Column<int>(type: "integer", nullable: false),
                    PayRange = table.Column<string>(type: "text", nullable: true),
                    Salary = table.Column<string>(type: "text", nullable: true),
                    Currency = table.Column<string>(type: "text", nullable: true),
                    IsUnder10Applicants = table.Column<bool>(type: "boolean", nullable: true),
                    ProcessPhase = table.Column<string>(type: "text", nullable: true),
                    Industry = table.Column<string>(type: "text", nullable: true),
                    IsReposted = table.Column<bool>(type: "boolean", nullable: true),
                    DatePosted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DateReposted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    NumberOfApplicants = table.Column<int>(type: "integer", nullable: true),
                    NumberOfViews = table.Column<int>(type: "integer", nullable: true),
                    IsEasyApply = table.Column<bool>(type: "boolean", nullable: true),
                    NumberOfCompanyEmployees = table.Column<int>(type: "integer", nullable: true),
                    NumberOfTeamMembers = table.Column<int>(type: "integer", nullable: true),
                    Methodology = table.Column<string>(type: "text", nullable: true),
                    IsActivelyRecruiting = table.Column<bool>(type: "boolean", nullable: true),
                    IsComplete = table.Column<bool>(type: "boolean", nullable: true),
                    IsPromoted = table.Column<bool>(type: "boolean", nullable: true),
                    JobType = table.Column<int>(type: "integer", nullable: true),
                    ExperienceLevel = table.Column<int>(type: "integer", nullable: true),
                    Locations = table.Column<string>(type: "text", nullable: true),
                    MainCountry = table.Column<string>(type: "text", nullable: true),
                    MainCity = table.Column<string>(type: "text", nullable: true),
                    PreferedTimezones = table.Column<string>(type: "text", nullable: true),
                    ImageLogoUrl = table.Column<string>(type: "text", nullable: true),
                    CompanyEmail = table.Column<string>(type: "text", nullable: true),
                    InvoiceEmail = table.Column<string>(type: "text", nullable: true),
                    InvoiceAddress = table.Column<string>(type: "text", nullable: true),
                    InvoiceNotes = table.Column<string>(type: "text", nullable: true),
                    FeedbackAboutWebsite = table.Column<string>(type: "text", nullable: true),
                    ProfileMinifiedUrl = table.Column<string>(type: "text", nullable: true),
                    IndexClusterId = table.Column<string>(type: "text", nullable: true),
                    IsOnAutoMessage = table.Column<bool>(type: "boolean", nullable: true),
                    IsOnAutoSelection = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobPosts_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobPosts_AspNetUsers_SelectedCandidateId",
                        column: x => x.SelectedCandidateId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LanguageName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SideProject",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    YearStart = table.Column<int>(type: "integer", nullable: false),
                    MonthStart = table.Column<int>(type: "integer", nullable: false),
                    YearEnd = table.Column<int>(type: "integer", nullable: true),
                    MonthEnd = table.Column<int>(type: "integer", nullable: true),
                    ProjectName = table.Column<string>(type: "text", nullable: false),
                    Url = table.Column<string>(type: "text", nullable: false),
                    IsOngoing = table.Column<bool>(type: "boolean", nullable: true),
                    AppUserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SideProject", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SideProject_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SkillName = table.Column<string>(type: "text", nullable: false),
                    Proficiency = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Social",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Website = table.Column<string>(type: "text", nullable: true),
                    Telegram = table.Column<string>(type: "text", nullable: true),
                    Github = table.Column<string>(type: "text", nullable: true),
                    Facebook = table.Column<string>(type: "text", nullable: true),
                    Instagram = table.Column<string>(type: "text", nullable: true),
                    LinkedIn = table.Column<string>(type: "text", nullable: true),
                    Twitter = table.Column<string>(type: "text", nullable: true),
                    AppUserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Social", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Social_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserBadge",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AppUserId = table.Column<int>(type: "integer", nullable: false),
                    BadgeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBadge", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserBadge_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserBadge_Badges_BadgeId",
                        column: x => x.BadgeId,
                        principalTable: "Badges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Benefits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BenefitName = table.Column<string>(type: "text", nullable: false),
                    JobPostId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Benefits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Benefits_JobPosts_JobPostId",
                        column: x => x.JobPostId,
                        principalTable: "JobPosts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "JobPostLanguages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    JobPostId = table.Column<int>(type: "integer", nullable: false),
                    LanguageId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPostLanguages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobPostLanguages_JobPosts_JobPostId",
                        column: x => x.JobPostId,
                        principalTable: "JobPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobPostLanguages_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLanguages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AppUserId = table.Column<int>(type: "integer", nullable: false),
                    LanguageId = table.Column<int>(type: "integer", nullable: false),
                    Proficiency = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLanguages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserLanguages_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserLanguages_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobPostSkills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    JobPostId = table.Column<int>(type: "integer", nullable: false),
                    SkillId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPostSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobPostSkills_JobPosts_JobPostId",
                        column: x => x.JobPostId,
                        principalTable: "JobPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobPostSkills_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserSkills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AppUserId = table.Column<int>(type: "integer", nullable: false),
                    SkillId = table.Column<int>(type: "integer", nullable: false),
                    Proficiency = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSkills_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSkills_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobPostBenefits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    JobPostId = table.Column<int>(type: "integer", nullable: false),
                    BenefitId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPostBenefits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobPostBenefits_Benefits_BenefitId",
                        column: x => x.BenefitId,
                        principalTable: "Benefits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobPostBenefits_JobPosts_JobPostId",
                        column: x => x.JobPostId,
                        principalTable: "JobPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserPreferedBenefits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AppUserId = table.Column<int>(type: "integer", nullable: false),
                    BenefitId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPreferedBenefits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserPreferedBenefits_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPreferedBenefits_Benefits_BenefitId",
                        column: x => x.BenefitId,
                        principalTable: "Benefits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Documents_JobPostId",
                table: "Documents",
                column: "JobPostId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_JobPostId",
                table: "AspNetUsers",
                column: "JobPostId");

            migrationBuilder.CreateIndex(
                name: "IX_Benefits_JobPostId",
                table: "Benefits",
                column: "JobPostId");

            migrationBuilder.CreateIndex(
                name: "IX_Education_AppUserId",
                table: "Education",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Employment_AppUserId",
                table: "Employment",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPostBenefits_BenefitId",
                table: "JobPostBenefits",
                column: "BenefitId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPostBenefits_JobPostId",
                table: "JobPostBenefits",
                column: "JobPostId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPostLanguages_JobPostId",
                table: "JobPostLanguages",
                column: "JobPostId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPostLanguages_LanguageId",
                table: "JobPostLanguages",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPosts_CreatedById",
                table: "JobPosts",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_JobPosts_SelectedCandidateId",
                table: "JobPosts",
                column: "SelectedCandidateId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPostSkills_JobPostId",
                table: "JobPostSkills",
                column: "JobPostId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPostSkills_SkillId",
                table: "JobPostSkills",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_SideProject_AppUserId",
                table: "SideProject",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Social_AppUserId",
                table: "Social",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserBadge_AppUserId",
                table: "UserBadge",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserBadge_BadgeId",
                table: "UserBadge",
                column: "BadgeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLanguages_AppUserId",
                table: "UserLanguages",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLanguages_LanguageId",
                table: "UserLanguages",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPreferedBenefits_AppUserId",
                table: "UserPreferedBenefits",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPreferedBenefits_BenefitId",
                table: "UserPreferedBenefits",
                column: "BenefitId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSkills_AppUserId",
                table: "UserSkills",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSkills_SkillId",
                table: "UserSkills",
                column: "SkillId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_JobPosts_JobPostId",
                table: "AspNetUsers",
                column: "JobPostId",
                principalTable: "JobPosts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_AspNetUsers_AppUserId",
                table: "Documents",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_JobPosts_JobPostId",
                table: "Documents",
                column: "JobPostId",
                principalTable: "JobPosts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_JobPosts_JobPostId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Documents_AspNetUsers_AppUserId",
                table: "Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_Documents_JobPosts_JobPostId",
                table: "Documents");

            migrationBuilder.DropTable(
                name: "Education");

            migrationBuilder.DropTable(
                name: "Employment");

            migrationBuilder.DropTable(
                name: "JobPostBenefits");

            migrationBuilder.DropTable(
                name: "JobPostLanguages");

            migrationBuilder.DropTable(
                name: "JobPostSkills");

            migrationBuilder.DropTable(
                name: "SideProject");

            migrationBuilder.DropTable(
                name: "Social");

            migrationBuilder.DropTable(
                name: "UserBadge");

            migrationBuilder.DropTable(
                name: "UserLanguages");

            migrationBuilder.DropTable(
                name: "UserPreferedBenefits");

            migrationBuilder.DropTable(
                name: "UserSkills");

            migrationBuilder.DropTable(
                name: "Badges");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Benefits");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "JobPosts");

            migrationBuilder.DropIndex(
                name: "IX_Documents_JobPostId",
                table: "Documents");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_JobPostId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "JobPostId",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "CityOfResidency",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CountryOfResidency",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DateAvailable",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EmailNotifications",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Hobbies",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IdentificationDocumentNumber",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IdentificationDocumentType",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IdentificationDocumentValidity",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IdentityHash",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IndexClusterId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsAvailable",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsOnAutoMessage",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsOnAutoSelection",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsRecruiter",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "JobPostId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Locations",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Nationality",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PreferredAgreementType",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SalaryExpectationsAnnually",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SalaryExpectationsDaily",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SalaryExpectationsHourly",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "YearsOfExperience",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "isRemote",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "ProfileMinifiedUrl",
                table: "AspNetUsers",
                newName: "LookingFor");

            migrationBuilder.RenameColumn(
                name: "PreferedTimezones",
                table: "AspNetUsers",
                newName: "Interests");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "AspNetUsers",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "AspNetUsers",
                newName: "City");

            migrationBuilder.AlterColumn<int>(
                name: "AppUserId",
                table: "Documents",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_AspNetUsers_AppUserId",
                table: "Documents",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
