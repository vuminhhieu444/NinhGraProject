using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduateSolution.Migrations
{
    public partial class InitialSchoolDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ADMIN",
                columns: table => new
                {
                    MAADMIN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TENADMIN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GHICHU = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ADMIN", x => x.MAADMIN);
                });

            migrationBuilder.CreateTable(
                name: "anh",
                columns: table => new
                {
                    MAANH = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TENANH = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MAADM = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HINHANH = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NOIDUNG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MATINBAI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TRANGTHAI = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_anh", x => x.MAANH);
                });

            migrationBuilder.CreateTable(
                name: "danh_muc",
                columns: table => new
                {
                    MADM = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TENDM = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MOTA = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_danh_muc", x => x.MADM);
                });

            migrationBuilder.CreateTable(
                name: "danh_muc_con",
                columns: table => new
                {
                    MADMC = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MADM = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TENDMC = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MOTA = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_danh_muc_con", x => x.MADMC);
                });

            migrationBuilder.CreateTable(
                name: "nguoi_dung",
                columns: table => new
                {
                    MANGUOIDUNG = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TENNGUOIDUNG = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MAADMIN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TIEUDE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NOIDUNG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TRANGTHAI = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table_1", x => x.MANGUOIDUNG);
                });

            migrationBuilder.CreateTable(
                name: "tin_bai",
                columns: table => new
                {
                    MATINBAI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TENTINBAI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MADM = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MADMC = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MAADM = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TIEUDE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NOIDUNG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    THOIGIANDANG = table.Column<DateTime>(type: "datetime", nullable: true),
                    TRANGTHAI = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tin_bai", x => x.MATINBAI);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ADMIN");

            migrationBuilder.DropTable(
                name: "anh");

            migrationBuilder.DropTable(
                name: "danh_muc");

            migrationBuilder.DropTable(
                name: "danh_muc_con");

            migrationBuilder.DropTable(
                name: "nguoi_dung");

            migrationBuilder.DropTable(
                name: "tin_bai");
        }
    }
}
