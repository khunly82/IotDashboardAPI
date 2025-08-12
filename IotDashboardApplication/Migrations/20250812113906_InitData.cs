using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IotDashboardApplication.Migrations
{
    /// <inheritdoc />
    public partial class InitData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Datas",
                columns: new[] { "Id", "Date", "Humidity", "Temperature" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 8, 12, 11, 0, 0, 0, DateTimeKind.Unspecified), 50.0, 22.0 },
                    { 2, new DateTime(2025, 8, 12, 11, 1, 0, 0, DateTimeKind.Unspecified), 50.100000000000001, 22.100000000000001 },
                    { 3, new DateTime(2025, 8, 12, 11, 2, 0, 0, DateTimeKind.Unspecified), 50.200000000000003, 22.199999999999999 },
                    { 4, new DateTime(2025, 8, 12, 11, 3, 0, 0, DateTimeKind.Unspecified), 50.299999999999997, 22.300000000000001 },
                    { 5, new DateTime(2025, 8, 12, 11, 4, 0, 0, DateTimeKind.Unspecified), 50.399999999999999, 22.399999999999999 },
                    { 6, new DateTime(2025, 8, 12, 11, 5, 0, 0, DateTimeKind.Unspecified), 50.5, 22.5 },
                    { 7, new DateTime(2025, 8, 12, 11, 6, 0, 0, DateTimeKind.Unspecified), 50.600000000000001, 22.600000000000001 },
                    { 8, new DateTime(2025, 8, 12, 11, 7, 0, 0, DateTimeKind.Unspecified), 50.700000000000003, 22.699999999999999 },
                    { 9, new DateTime(2025, 8, 12, 11, 8, 0, 0, DateTimeKind.Unspecified), 50.799999999999997, 22.800000000000001 },
                    { 10, new DateTime(2025, 8, 12, 11, 9, 0, 0, DateTimeKind.Unspecified), 50.899999999999999, 22.899999999999999 },
                    { 11, new DateTime(2025, 8, 12, 11, 10, 0, 0, DateTimeKind.Unspecified), 51.0, 23.0 },
                    { 12, new DateTime(2025, 8, 12, 11, 11, 0, 0, DateTimeKind.Unspecified), 51.100000000000001, 23.100000000000001 },
                    { 13, new DateTime(2025, 8, 12, 11, 12, 0, 0, DateTimeKind.Unspecified), 51.200000000000003, 23.199999999999999 },
                    { 14, new DateTime(2025, 8, 12, 11, 13, 0, 0, DateTimeKind.Unspecified), 51.299999999999997, 23.300000000000001 },
                    { 15, new DateTime(2025, 8, 12, 11, 14, 0, 0, DateTimeKind.Unspecified), 51.399999999999999, 23.399999999999999 },
                    { 16, new DateTime(2025, 8, 12, 11, 15, 0, 0, DateTimeKind.Unspecified), 51.5, 23.5 },
                    { 17, new DateTime(2025, 8, 12, 11, 16, 0, 0, DateTimeKind.Unspecified), 51.600000000000001, 23.600000000000001 },
                    { 18, new DateTime(2025, 8, 12, 11, 17, 0, 0, DateTimeKind.Unspecified), 51.700000000000003, 23.699999999999999 },
                    { 19, new DateTime(2025, 8, 12, 11, 18, 0, 0, DateTimeKind.Unspecified), 51.799999999999997, 23.800000000000001 },
                    { 20, new DateTime(2025, 8, 12, 11, 19, 0, 0, DateTimeKind.Unspecified), 51.899999999999999, 23.899999999999999 },
                    { 21, new DateTime(2025, 8, 12, 11, 20, 0, 0, DateTimeKind.Unspecified), 52.0, 24.0 },
                    { 22, new DateTime(2025, 8, 12, 11, 21, 0, 0, DateTimeKind.Unspecified), 52.100000000000001, 24.100000000000001 },
                    { 23, new DateTime(2025, 8, 12, 11, 22, 0, 0, DateTimeKind.Unspecified), 52.200000000000003, 24.199999999999999 },
                    { 24, new DateTime(2025, 8, 12, 11, 23, 0, 0, DateTimeKind.Unspecified), 52.299999999999997, 24.300000000000001 },
                    { 25, new DateTime(2025, 8, 12, 11, 24, 0, 0, DateTimeKind.Unspecified), 52.399999999999999, 24.399999999999999 },
                    { 26, new DateTime(2025, 8, 12, 11, 25, 0, 0, DateTimeKind.Unspecified), 52.5, 24.5 },
                    { 27, new DateTime(2025, 8, 12, 11, 26, 0, 0, DateTimeKind.Unspecified), 52.600000000000001, 24.600000000000001 },
                    { 28, new DateTime(2025, 8, 12, 11, 27, 0, 0, DateTimeKind.Unspecified), 52.700000000000003, 24.699999999999999 },
                    { 29, new DateTime(2025, 8, 12, 11, 28, 0, 0, DateTimeKind.Unspecified), 52.799999999999997, 24.800000000000001 },
                    { 30, new DateTime(2025, 8, 12, 11, 29, 0, 0, DateTimeKind.Unspecified), 52.899999999999999, 24.899999999999999 },
                    { 31, new DateTime(2025, 8, 12, 11, 30, 0, 0, DateTimeKind.Unspecified), 53.0, 25.0 },
                    { 32, new DateTime(2025, 8, 12, 11, 31, 0, 0, DateTimeKind.Unspecified), 53.100000000000001, 25.100000000000001 },
                    { 33, new DateTime(2025, 8, 12, 11, 32, 0, 0, DateTimeKind.Unspecified), 53.200000000000003, 25.199999999999999 },
                    { 34, new DateTime(2025, 8, 12, 11, 33, 0, 0, DateTimeKind.Unspecified), 53.299999999999997, 25.300000000000001 },
                    { 35, new DateTime(2025, 8, 12, 11, 34, 0, 0, DateTimeKind.Unspecified), 53.399999999999999, 25.399999999999999 },
                    { 36, new DateTime(2025, 8, 12, 11, 35, 0, 0, DateTimeKind.Unspecified), 53.5, 25.5 },
                    { 37, new DateTime(2025, 8, 12, 11, 36, 0, 0, DateTimeKind.Unspecified), 53.600000000000001, 25.600000000000001 },
                    { 38, new DateTime(2025, 8, 12, 11, 37, 0, 0, DateTimeKind.Unspecified), 53.700000000000003, 25.699999999999999 },
                    { 39, new DateTime(2025, 8, 12, 11, 38, 0, 0, DateTimeKind.Unspecified), 53.799999999999997, 25.800000000000001 },
                    { 40, new DateTime(2025, 8, 12, 11, 39, 0, 0, DateTimeKind.Unspecified), 53.899999999999999, 25.899999999999999 },
                    { 41, new DateTime(2025, 8, 12, 11, 40, 0, 0, DateTimeKind.Unspecified), 54.0, 26.0 },
                    { 42, new DateTime(2025, 8, 12, 11, 41, 0, 0, DateTimeKind.Unspecified), 54.100000000000001, 26.100000000000001 },
                    { 43, new DateTime(2025, 8, 12, 11, 42, 0, 0, DateTimeKind.Unspecified), 54.200000000000003, 26.199999999999999 },
                    { 44, new DateTime(2025, 8, 12, 11, 43, 0, 0, DateTimeKind.Unspecified), 54.299999999999997, 26.300000000000001 },
                    { 45, new DateTime(2025, 8, 12, 11, 44, 0, 0, DateTimeKind.Unspecified), 54.399999999999999, 26.399999999999999 },
                    { 46, new DateTime(2025, 8, 12, 11, 45, 0, 0, DateTimeKind.Unspecified), 54.5, 26.5 },
                    { 47, new DateTime(2025, 8, 12, 11, 46, 0, 0, DateTimeKind.Unspecified), 54.600000000000001, 26.600000000000001 },
                    { 48, new DateTime(2025, 8, 12, 11, 47, 0, 0, DateTimeKind.Unspecified), 54.700000000000003, 26.699999999999999 },
                    { 49, new DateTime(2025, 8, 12, 11, 48, 0, 0, DateTimeKind.Unspecified), 54.799999999999997, 26.800000000000001 },
                    { 50, new DateTime(2025, 8, 12, 11, 49, 0, 0, DateTimeKind.Unspecified), 54.899999999999999, 26.899999999999999 },
                    { 51, new DateTime(2025, 8, 12, 11, 50, 0, 0, DateTimeKind.Unspecified), 55.0, 27.0 },
                    { 52, new DateTime(2025, 8, 12, 11, 51, 0, 0, DateTimeKind.Unspecified), 55.100000000000001, 27.100000000000001 },
                    { 53, new DateTime(2025, 8, 12, 11, 52, 0, 0, DateTimeKind.Unspecified), 55.200000000000003, 27.199999999999999 },
                    { 54, new DateTime(2025, 8, 12, 11, 53, 0, 0, DateTimeKind.Unspecified), 55.299999999999997, 27.300000000000001 },
                    { 55, new DateTime(2025, 8, 12, 11, 54, 0, 0, DateTimeKind.Unspecified), 55.399999999999999, 27.399999999999999 },
                    { 56, new DateTime(2025, 8, 12, 11, 55, 0, 0, DateTimeKind.Unspecified), 55.5, 27.5 },
                    { 57, new DateTime(2025, 8, 12, 11, 56, 0, 0, DateTimeKind.Unspecified), 55.600000000000001, 27.600000000000001 },
                    { 58, new DateTime(2025, 8, 12, 11, 57, 0, 0, DateTimeKind.Unspecified), 55.700000000000003, 27.699999999999999 },
                    { 59, new DateTime(2025, 8, 12, 11, 58, 0, 0, DateTimeKind.Unspecified), 55.799999999999997, 27.800000000000001 },
                    { 60, new DateTime(2025, 8, 12, 11, 59, 0, 0, DateTimeKind.Unspecified), 55.899999999999999, 27.899999999999999 },
                    { 61, new DateTime(2025, 8, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), 56.0, 28.0 },
                    { 62, new DateTime(2025, 8, 12, 12, 1, 0, 0, DateTimeKind.Unspecified), 56.100000000000001, 28.100000000000001 },
                    { 63, new DateTime(2025, 8, 12, 12, 2, 0, 0, DateTimeKind.Unspecified), 56.200000000000003, 28.199999999999999 },
                    { 64, new DateTime(2025, 8, 12, 12, 3, 0, 0, DateTimeKind.Unspecified), 56.299999999999997, 28.300000000000001 },
                    { 65, new DateTime(2025, 8, 12, 12, 4, 0, 0, DateTimeKind.Unspecified), 56.399999999999999, 28.399999999999999 },
                    { 66, new DateTime(2025, 8, 12, 12, 5, 0, 0, DateTimeKind.Unspecified), 56.5, 28.5 },
                    { 67, new DateTime(2025, 8, 12, 12, 6, 0, 0, DateTimeKind.Unspecified), 56.600000000000001, 28.600000000000001 },
                    { 68, new DateTime(2025, 8, 12, 12, 7, 0, 0, DateTimeKind.Unspecified), 56.700000000000003, 28.699999999999999 },
                    { 69, new DateTime(2025, 8, 12, 12, 8, 0, 0, DateTimeKind.Unspecified), 56.799999999999997, 28.800000000000001 },
                    { 70, new DateTime(2025, 8, 12, 12, 9, 0, 0, DateTimeKind.Unspecified), 56.899999999999999, 28.899999999999999 },
                    { 71, new DateTime(2025, 8, 12, 12, 10, 0, 0, DateTimeKind.Unspecified), 57.0, 29.0 },
                    { 72, new DateTime(2025, 8, 12, 12, 11, 0, 0, DateTimeKind.Unspecified), 57.100000000000001, 29.100000000000001 },
                    { 73, new DateTime(2025, 8, 12, 12, 12, 0, 0, DateTimeKind.Unspecified), 57.200000000000003, 29.199999999999999 },
                    { 74, new DateTime(2025, 8, 12, 12, 13, 0, 0, DateTimeKind.Unspecified), 57.299999999999997, 29.300000000000001 },
                    { 75, new DateTime(2025, 8, 12, 12, 14, 0, 0, DateTimeKind.Unspecified), 57.399999999999999, 29.399999999999999 },
                    { 76, new DateTime(2025, 8, 12, 12, 15, 0, 0, DateTimeKind.Unspecified), 57.5, 29.5 },
                    { 77, new DateTime(2025, 8, 12, 12, 16, 0, 0, DateTimeKind.Unspecified), 57.600000000000001, 29.600000000000001 },
                    { 78, new DateTime(2025, 8, 12, 12, 17, 0, 0, DateTimeKind.Unspecified), 57.700000000000003, 29.699999999999999 },
                    { 79, new DateTime(2025, 8, 12, 12, 18, 0, 0, DateTimeKind.Unspecified), 57.799999999999997, 29.800000000000001 },
                    { 80, new DateTime(2025, 8, 12, 12, 19, 0, 0, DateTimeKind.Unspecified), 57.899999999999999, 29.899999999999999 },
                    { 81, new DateTime(2025, 8, 12, 12, 20, 0, 0, DateTimeKind.Unspecified), 58.0, 30.0 },
                    { 82, new DateTime(2025, 8, 12, 12, 21, 0, 0, DateTimeKind.Unspecified), 58.100000000000001, 30.100000000000001 },
                    { 83, new DateTime(2025, 8, 12, 12, 22, 0, 0, DateTimeKind.Unspecified), 58.200000000000003, 30.200000000000003 },
                    { 84, new DateTime(2025, 8, 12, 12, 23, 0, 0, DateTimeKind.Unspecified), 58.299999999999997, 30.300000000000001 },
                    { 85, new DateTime(2025, 8, 12, 12, 24, 0, 0, DateTimeKind.Unspecified), 58.399999999999999, 30.399999999999999 },
                    { 86, new DateTime(2025, 8, 12, 12, 25, 0, 0, DateTimeKind.Unspecified), 58.5, 30.5 },
                    { 87, new DateTime(2025, 8, 12, 12, 26, 0, 0, DateTimeKind.Unspecified), 58.600000000000001, 30.600000000000001 },
                    { 88, new DateTime(2025, 8, 12, 12, 27, 0, 0, DateTimeKind.Unspecified), 58.700000000000003, 30.700000000000003 },
                    { 89, new DateTime(2025, 8, 12, 12, 28, 0, 0, DateTimeKind.Unspecified), 58.799999999999997, 30.800000000000001 },
                    { 90, new DateTime(2025, 8, 12, 12, 29, 0, 0, DateTimeKind.Unspecified), 58.899999999999999, 30.899999999999999 },
                    { 91, new DateTime(2025, 8, 12, 12, 30, 0, 0, DateTimeKind.Unspecified), 59.0, 31.0 },
                    { 92, new DateTime(2025, 8, 12, 12, 31, 0, 0, DateTimeKind.Unspecified), 59.100000000000001, 31.100000000000001 },
                    { 93, new DateTime(2025, 8, 12, 12, 32, 0, 0, DateTimeKind.Unspecified), 59.200000000000003, 31.200000000000003 },
                    { 94, new DateTime(2025, 8, 12, 12, 33, 0, 0, DateTimeKind.Unspecified), 59.299999999999997, 31.300000000000001 },
                    { 95, new DateTime(2025, 8, 12, 12, 34, 0, 0, DateTimeKind.Unspecified), 59.399999999999999, 31.399999999999999 },
                    { 96, new DateTime(2025, 8, 12, 12, 35, 0, 0, DateTimeKind.Unspecified), 59.5, 31.5 },
                    { 97, new DateTime(2025, 8, 12, 12, 36, 0, 0, DateTimeKind.Unspecified), 59.600000000000001, 31.600000000000001 },
                    { 98, new DateTime(2025, 8, 12, 12, 37, 0, 0, DateTimeKind.Unspecified), 59.700000000000003, 31.700000000000003 },
                    { 99, new DateTime(2025, 8, 12, 12, 38, 0, 0, DateTimeKind.Unspecified), 59.799999999999997, 31.800000000000001 },
                    { 100, new DateTime(2025, 8, 12, 12, 39, 0, 0, DateTimeKind.Unspecified), 59.899999999999999, 31.899999999999999 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Datas",
                keyColumn: "Id",
                keyValue: 100);
        }
    }
}
