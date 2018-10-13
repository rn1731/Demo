using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SsoDemo.Authorization.Data.Migrations
{
    public partial class InitialTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Key = table.Column<string>(nullable: false),
                    Secret = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientId);
                });

            migrationBuilder.CreateTable(
                name: "Scopes",
                columns: table => new
                {
                    ScopeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    System = table.Column<string>(nullable: false),
                    Api = table.Column<string>(nullable: true),
                    Method = table.Column<string>(nullable: true),
                    Access = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scopes", x => x.ScopeId);
                });

            migrationBuilder.CreateTable(
                name: "UserAccounts",
                columns: table => new
                {
                    DomainId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    PasswordSalt = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAccounts", x => x.DomainId);
                });

            migrationBuilder.CreateTable(
                name: "ClientScopeAllocations",
                columns: table => new
                {
                    ClientRoleAllocationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClientId = table.Column<int>(nullable: false),
                    ScopeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientScopeAllocations", x => x.ClientRoleAllocationId);
                    table.ForeignKey(
                        name: "FK_ClientScopeAllocations_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientScopeAllocations_Scopes_ScopeId",
                        column: x => x.ScopeId,
                        principalTable: "Scopes",
                        principalColumn: "ScopeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAccountScopeAllocations",
                columns: table => new
                {
                    UserAccountScopeAllocationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserAccountId = table.Column<int>(nullable: false),
                    ScopeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAccountScopeAllocations", x => x.UserAccountScopeAllocationId);
                    table.ForeignKey(
                        name: "FK_UserAccountScopeAllocations_Scopes_ScopeId",
                        column: x => x.ScopeId,
                        principalTable: "Scopes",
                        principalColumn: "ScopeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAccountScopeAllocations_UserAccounts_UserAccountId",
                        column: x => x.UserAccountId,
                        principalTable: "UserAccounts",
                        principalColumn: "DomainId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserGrantedClientScopeAllocations",
                columns: table => new
                {
                    UserGrantedClientScopeAllocationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserAccountId = table.Column<int>(nullable: false),
                    ClientId = table.Column<int>(nullable: false),
                    ScopeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGrantedClientScopeAllocations", x => x.UserGrantedClientScopeAllocationId);
                    table.ForeignKey(
                        name: "FK_UserGrantedClientScopeAllocations_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserGrantedClientScopeAllocations_Scopes_ScopeId",
                        column: x => x.ScopeId,
                        principalTable: "Scopes",
                        principalColumn: "ScopeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserGrantedClientScopeAllocations_UserAccounts_UserAccountId",
                        column: x => x.UserAccountId,
                        principalTable: "UserAccounts",
                        principalColumn: "DomainId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientScopeAllocations_ClientId",
                table: "ClientScopeAllocations",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientScopeAllocations_ScopeId",
                table: "ClientScopeAllocations",
                column: "ScopeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAccountScopeAllocations_ScopeId",
                table: "UserAccountScopeAllocations",
                column: "ScopeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAccountScopeAllocations_UserAccountId",
                table: "UserAccountScopeAllocations",
                column: "UserAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_UserGrantedClientScopeAllocations_ClientId",
                table: "UserGrantedClientScopeAllocations",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_UserGrantedClientScopeAllocations_ScopeId",
                table: "UserGrantedClientScopeAllocations",
                column: "ScopeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserGrantedClientScopeAllocations_UserAccountId",
                table: "UserGrantedClientScopeAllocations",
                column: "UserAccountId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientScopeAllocations");

            migrationBuilder.DropTable(
                name: "UserAccountScopeAllocations");

            migrationBuilder.DropTable(
                name: "UserGrantedClientScopeAllocations");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Scopes");

            migrationBuilder.DropTable(
                name: "UserAccounts");
        }
    }
}
