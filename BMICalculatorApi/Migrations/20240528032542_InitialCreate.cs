﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BMICalculatorApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BMIRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<double>(type: "float", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Bmi = table.Column<double>(type: "float", nullable: false),
                    RecordedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()") // Use GETDATE() as default value
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BMIRecords", x => x.Id);
                });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BMIRecords");
        }
    }
}
