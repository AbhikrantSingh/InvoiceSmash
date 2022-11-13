using Microsoft.EntityFrameworkCore.Migrations;

namespace Subscription.Migrations
{
    public partial class SubscriptionName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subscription_Name = table.Column<string>(nullable: true),
                    Is_Enabled = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "Is_Enabled", "Subscription_Name" },
                values: new object[,]
                {
                    { 1L, true, "invoice-smash-master-test@coupadev.com" },
                    { 2L, true, "invoice-smash-dashmaster3@coupadev.com" },
                    { 3L, true, "invoice-smash-master@coupadev.com" },
                    { 4L, true, "invoice-smash-mlgateKeeper@coupadev.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subscriptions");
        }
    }
}
