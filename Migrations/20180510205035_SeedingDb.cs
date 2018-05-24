using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BenWeb.Migrations
{
    public partial class SeedingDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Owners (Name,Surname,Phone) VALUES ('Benek', 'Mistrzu', '587877344')");
            migrationBuilder.Sql("INSERT INTO Owners (Name,Surname,Phone) VALUES ('Aneta', 'Misztrzyni', '328489234')");

            migrationBuilder.Sql("INSERT INTO Addresses (Street,City) VALUES ('Złota', 'Pszczyna')");
            migrationBuilder.Sql("INSERT INTO Addresses (Street,City) VALUES ('Szara', 'Tychy')");

            migrationBuilder.Sql("INSERT INTO Properties (Type,Description,Rooms,Area,Washer,Refrigerator,Iron,AddressId,OwnerId) VALUES (0,'Text',3,170,1,1,0,1,1)");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Owners");
            migrationBuilder.Sql("DELETE FROM Addresses");
            migrationBuilder.Sql("DELETE FROM Properties");
        }
    }
}
