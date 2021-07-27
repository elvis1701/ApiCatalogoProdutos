using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiCatalogoProdutos.Migrations
{
    public partial class Populadb : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Categorias(Nome,ImagemUrl) Values('Bebidas',"+
                "'https://www.dinvo.com.br/blog/wp-content/uploads/2018/04/bebidas.jpg')");

            mb.Sql("Insert into Categorias(Nome,ImagemUrl) Values('Lanches'," +
                "'https://i2.wp.com/gkpb.com.br/wp-content/uploads/2020/01/whopper-voltou-2-por-15-burger-king.jpg?resize=696%2C385&ssl=1')");

            mb.Sql("Insert into Categorias(Nome,ImagemUrl) Values('Laticinios'," +
                "'https://cptstatic.s3.amazonaws.com/imagens/enviadas/materias/materia10723/Laticinios-01.jpg')");

            mb.Sql("Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,"+
                "DataCadastro,CategoriaId) Values ('Coca-Cola','Refrigerante Coca Cola Lata 350ml',"+
                "3.25,'https://www.farmaciaindiana.com.br/arquivos/ids/232767-700-1000/677510.jpg?v=637441644755670000',50,now()," +
                "(Select CategoriaId from Categorias where Nome='Bebidas'))");

            mb.Sql("Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque," +
                "DataCadastro,CategoriaId) Values ('Cheddar','pão integral com gergelim, cheddar cremoso, cebolas caramelizadas ao molho shoyu e hambúrguer de carne grelhado no fogo como churrasco.'," +
                "9.90,'https://bk-cms-dev.s3.amazonaws.com/cheddar-d.jpg?mtime=20210204172206&focal=none',50,now()," +
                "(Select CategoriaId from Categorias where Nome='Lanches'))");

            mb.Sql("Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque," +
                "DataCadastro,CategoriaId) Values ('Queijo Mussarela','queijo mussarela fatiado 3kg.'," +
                "24.50,'https://carrefourbr.vtexassets.com/arquivos/ids/15283353-720-720?v=637526284609900000',50,now()," +
                "(Select CategoriaId from Categorias where Nome='Laticinios'))");

        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Categorias");
            mb.Sql("Delete from Produtos");
        }
    }
}
