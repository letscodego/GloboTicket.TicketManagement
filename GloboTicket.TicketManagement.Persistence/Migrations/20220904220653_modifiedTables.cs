using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GloboTicket.TicketManagement.Persistence.Migrations
{
    public partial class modifiedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Artist",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("6313179f-7837-473a-a4d5-a5571b43e6a6"),
                column: "CreatedDate",
                value: new DateTime(2022, 9, 4, 15, 6, 52, 948, DateTimeKind.Local).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dde"),
                column: "CreatedDate",
                value: new DateTime(2022, 9, 4, 15, 6, 52, 948, DateTimeKind.Local).AddTicks(5245));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("bf3f3002-7e53-441e-8b76-f6280be284aa"),
                column: "CreatedDate",
                value: new DateTime(2022, 9, 4, 15, 6, 52, 948, DateTimeKind.Local).AddTicks(5343));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("fe98f549-e790-4e9f-aa16-18c2292a2ee9"),
                column: "CreatedDate",
                value: new DateTime(2022, 9, 4, 15, 6, 52, 948, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("1babd057-e980-4cb3-9cd2-7fdd9e525668"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2022, 9, 4, 15, 6, 52, 948, DateTimeKind.Local).AddTicks(5452), new DateTime(2023, 7, 4, 15, 6, 52, 948, DateTimeKind.Local).AddTicks(5449) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3448d5a4-0f72-4dd7-bf15-c14a46b26c00"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2022, 9, 4, 15, 6, 52, 948, DateTimeKind.Local).AddTicks(5400), new DateTime(2023, 6, 4, 15, 6, 52, 948, DateTimeKind.Local).AddTicks(5396) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("62787623-4c52-43fe-b0c9-b7044fb5929b"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2022, 9, 4, 15, 6, 52, 948, DateTimeKind.Local).AddTicks(5435), new DateTime(2023, 1, 4, 15, 6, 52, 948, DateTimeKind.Local).AddTicks(5431) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("adc42c09-08c1-4d2c-9f96-2d15bb1af299"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2022, 9, 4, 15, 6, 52, 948, DateTimeKind.Local).AddTicks(5473), new DateTime(2023, 5, 4, 15, 6, 52, 948, DateTimeKind.Local).AddTicks(5469) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b419a7ca-3321-4f38-be8e-4d7b6a529319"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2022, 9, 4, 15, 6, 52, 948, DateTimeKind.Local).AddTicks(5418), new DateTime(2023, 1, 4, 15, 6, 52, 948, DateTimeKind.Local).AddTicks(5414) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ee272f8b-6096-4cb6-8625-bb4bb2d89e8b"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2022, 9, 4, 15, 6, 52, 948, DateTimeKind.Local).AddTicks(5375), new DateTime(2023, 3, 4, 15, 6, 52, 948, DateTimeKind.Local).AddTicks(5370) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("3dcb3ea0-80b1-4781-b5c0-4d85c41e55a6"),
                columns: new[] { "CreatedDate", "OrderPlaced" },
                values: new object[] { new DateTime(2022, 9, 4, 15, 6, 52, 948, DateTimeKind.Local).AddTicks(5553), new DateTime(2022, 9, 4, 15, 6, 52, 948, DateTimeKind.Local).AddTicks(5549) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("771cca4b-066c-4ac7-b3df-4d12837fe7e0"),
                columns: new[] { "CreatedDate", "OrderPlaced" },
                values: new object[] { new DateTime(2022, 9, 4, 15, 6, 52, 948, DateTimeKind.Local).AddTicks(5538), new DateTime(2022, 9, 4, 15, 6, 52, 948, DateTimeKind.Local).AddTicks(5533) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7e94bc5b-71a5-4c8c-bc3b-71bb7976237e"),
                columns: new[] { "CreatedDate", "OrderPlaced" },
                values: new object[] { new DateTime(2022, 9, 4, 15, 6, 52, 948, DateTimeKind.Local).AddTicks(5498), new DateTime(2022, 9, 4, 15, 6, 52, 948, DateTimeKind.Local).AddTicks(5494) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("86d3a045-b42d-4854-8150-d6a374948b6e"),
                columns: new[] { "CreatedDate", "OrderPlaced" },
                values: new object[] { new DateTime(2022, 9, 4, 15, 6, 52, 948, DateTimeKind.Local).AddTicks(5520), new DateTime(2022, 9, 4, 15, 6, 52, 948, DateTimeKind.Local).AddTicks(5515) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ba0eb0ef-b69b-46fd-b8e2-41b4178ae7cb"),
                columns: new[] { "CreatedDate", "OrderPlaced" },
                values: new object[] { new DateTime(2022, 9, 4, 15, 6, 52, 948, DateTimeKind.Local).AddTicks(5604), new DateTime(2022, 9, 4, 15, 6, 52, 948, DateTimeKind.Local).AddTicks(5601) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e6a2679c-79a3-4ef1-a478-6f4c91b405b6"),
                columns: new[] { "CreatedDate", "OrderPlaced" },
                values: new object[] { new DateTime(2022, 9, 4, 15, 6, 52, 948, DateTimeKind.Local).AddTicks(5570), new DateTime(2022, 9, 4, 15, 6, 52, 948, DateTimeKind.Local).AddTicks(5566) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f5a6a3a0-4227-4973-abb5-a63fbe725923"),
                columns: new[] { "CreatedDate", "OrderPlaced" },
                values: new object[] { new DateTime(2022, 9, 4, 15, 6, 52, 948, DateTimeKind.Local).AddTicks(5588), new DateTime(2022, 9, 4, 15, 6, 52, 948, DateTimeKind.Local).AddTicks(5584) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                table: "Events",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Events",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Events",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Artist",
                table: "Events",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("6313179f-7837-473a-a4d5-a5571b43e6a6"),
                column: "CreatedDate",
                value: new DateTime(2022, 9, 2, 22, 58, 22, 216, DateTimeKind.Local).AddTicks(4434));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dde"),
                column: "CreatedDate",
                value: new DateTime(2022, 9, 2, 22, 58, 22, 216, DateTimeKind.Local).AddTicks(4322));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("bf3f3002-7e53-441e-8b76-f6280be284aa"),
                column: "CreatedDate",
                value: new DateTime(2022, 9, 2, 22, 58, 22, 216, DateTimeKind.Local).AddTicks(4448));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("fe98f549-e790-4e9f-aa16-18c2292a2ee9"),
                column: "CreatedDate",
                value: new DateTime(2022, 9, 2, 22, 58, 22, 216, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("1babd057-e980-4cb3-9cd2-7fdd9e525668"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2022, 9, 2, 22, 58, 22, 216, DateTimeKind.Local).AddTicks(4646), new DateTime(2023, 7, 2, 22, 58, 22, 216, DateTimeKind.Local).AddTicks(4643) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3448d5a4-0f72-4dd7-bf15-c14a46b26c00"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2022, 9, 2, 22, 58, 22, 216, DateTimeKind.Local).AddTicks(4505), new DateTime(2023, 6, 2, 22, 58, 22, 216, DateTimeKind.Local).AddTicks(4501) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("62787623-4c52-43fe-b0c9-b7044fb5929b"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2022, 9, 2, 22, 58, 22, 216, DateTimeKind.Local).AddTicks(4628), new DateTime(2023, 1, 2, 22, 58, 22, 216, DateTimeKind.Local).AddTicks(4625) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("adc42c09-08c1-4d2c-9f96-2d15bb1af299"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2022, 9, 2, 22, 58, 22, 216, DateTimeKind.Local).AddTicks(4666), new DateTime(2023, 5, 2, 22, 58, 22, 216, DateTimeKind.Local).AddTicks(4663) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b419a7ca-3321-4f38-be8e-4d7b6a529319"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2022, 9, 2, 22, 58, 22, 216, DateTimeKind.Local).AddTicks(4610), new DateTime(2023, 1, 2, 22, 58, 22, 216, DateTimeKind.Local).AddTicks(4606) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ee272f8b-6096-4cb6-8625-bb4bb2d89e8b"),
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2022, 9, 2, 22, 58, 22, 216, DateTimeKind.Local).AddTicks(4480), new DateTime(2023, 3, 2, 22, 58, 22, 216, DateTimeKind.Local).AddTicks(4475) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("3dcb3ea0-80b1-4781-b5c0-4d85c41e55a6"),
                columns: new[] { "CreatedDate", "OrderPlaced" },
                values: new object[] { new DateTime(2022, 9, 2, 22, 58, 22, 216, DateTimeKind.Local).AddTicks(4739), new DateTime(2022, 9, 2, 22, 58, 22, 216, DateTimeKind.Local).AddTicks(4737) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("771cca4b-066c-4ac7-b3df-4d12837fe7e0"),
                columns: new[] { "CreatedDate", "OrderPlaced" },
                values: new object[] { new DateTime(2022, 9, 2, 22, 58, 22, 216, DateTimeKind.Local).AddTicks(4725), new DateTime(2022, 9, 2, 22, 58, 22, 216, DateTimeKind.Local).AddTicks(4722) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7e94bc5b-71a5-4c8c-bc3b-71bb7976237e"),
                columns: new[] { "CreatedDate", "OrderPlaced" },
                values: new object[] { new DateTime(2022, 9, 2, 22, 58, 22, 216, DateTimeKind.Local).AddTicks(4692), new DateTime(2022, 9, 2, 22, 58, 22, 216, DateTimeKind.Local).AddTicks(4687) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("86d3a045-b42d-4854-8150-d6a374948b6e"),
                columns: new[] { "CreatedDate", "OrderPlaced" },
                values: new object[] { new DateTime(2022, 9, 2, 22, 58, 22, 216, DateTimeKind.Local).AddTicks(4711), new DateTime(2022, 9, 2, 22, 58, 22, 216, DateTimeKind.Local).AddTicks(4707) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ba0eb0ef-b69b-46fd-b8e2-41b4178ae7cb"),
                columns: new[] { "CreatedDate", "OrderPlaced" },
                values: new object[] { new DateTime(2022, 9, 2, 22, 58, 22, 216, DateTimeKind.Local).AddTicks(4784), new DateTime(2022, 9, 2, 22, 58, 22, 216, DateTimeKind.Local).AddTicks(4780) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e6a2679c-79a3-4ef1-a478-6f4c91b405b6"),
                columns: new[] { "CreatedDate", "OrderPlaced" },
                values: new object[] { new DateTime(2022, 9, 2, 22, 58, 22, 216, DateTimeKind.Local).AddTicks(4753), new DateTime(2022, 9, 2, 22, 58, 22, 216, DateTimeKind.Local).AddTicks(4750) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f5a6a3a0-4227-4973-abb5-a63fbe725923"),
                columns: new[] { "CreatedDate", "OrderPlaced" },
                values: new object[] { new DateTime(2022, 9, 2, 22, 58, 22, 216, DateTimeKind.Local).AddTicks(4770), new DateTime(2022, 9, 2, 22, 58, 22, 216, DateTimeKind.Local).AddTicks(4766) });
        }
    }
}
