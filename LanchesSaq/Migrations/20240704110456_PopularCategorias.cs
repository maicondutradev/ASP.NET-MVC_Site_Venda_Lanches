﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesSaq.Migrations
{
    public partial class PopularCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias( CategoriaNome, Descricao )" +
                "VALUES ('Normal','lanche feito com ingredientes normais') ");

            migrationBuilder.Sql("INSERT INTO Categorias( CategoriaNome, Descricao )" +
                "VALUES ('Natural','lanche feito com ingredientes integrais e naturais') ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
