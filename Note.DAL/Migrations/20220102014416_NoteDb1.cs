﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Note.DAL.Migrations
{
    public partial class NoteDb1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notices",
                columns: table => new
                {
                    NoticeNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoticeTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NOticeContents = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoticeWriteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NoticeViewCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notices", x => x.NoticeNo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notices");
        }
    }
}
