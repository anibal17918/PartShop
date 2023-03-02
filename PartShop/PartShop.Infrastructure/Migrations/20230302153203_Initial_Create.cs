using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PartShop.Infrastructure.Migrations
{
    public partial class Initial_Create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    IdCategoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    FechaRegistro = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CATEGORI__A3C02A10A6E6D2F3", x => x.IdCategoria);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoDocumento = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NumeroDocumento = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Direccion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Telefono = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    FechaRegistro = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CLIENTE__D59466424840A808", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    IdMenu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    Icono = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    FechaRegistro = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__MENU__4D7EA8E1DDB412F0", x => x.IdMenu);
                });

            migrationBuilder.CreateTable(
                name: "Proveedor",
                columns: table => new
                {
                    IdProveedor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RNC = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    RazonSocial = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Telefono = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Correo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Direccion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    FechaRegistro = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PROVEEDO__E8B631AF5AC20624", x => x.IdProveedor);
                });

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    IdRol = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    FechaRegistro = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ROL__2A49584CCF834DF6", x => x.IdRol);
                });

            migrationBuilder.CreateTable(
                name: "Tienda",
                columns: table => new
                {
                    IdTienda = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RNC = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Nombre = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    Direccion = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Telefono = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    FechaRegistro = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TIENDA__5A1EB96B8757EB7F", x => x.IdTienda);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    IdProducto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ValorCodigo = table.Column<int>(type: "int", nullable: true),
                    Nombre = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Descripcion = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    IdCategoria = table.Column<int>(type: "int", nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    FechaRegistro = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PRODUCTO__0988921092E65D85", x => x.IdProducto);
                    table.ForeignKey(
                        name: "FK__PRODUCTO__IdCate__7D439ABD",
                        column: x => x.IdCategoria,
                        principalTable: "Categoria",
                        principalColumn: "IdCategoria");
                });

            migrationBuilder.CreateTable(
                name: "Submenu",
                columns: table => new
                {
                    IdSubMenu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdMenu = table.Column<int>(type: "int", nullable: true),
                    Nombre = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    NombreFormulario = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    FechaRegistro = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SUBMENU__CFDCE01ADBEDBD61", x => x.IdSubMenu);
                    table.ForeignKey(
                        name: "FK__SUBMENU__IdMenu__00200768",
                        column: x => x.IdMenu,
                        principalTable: "Menu",
                        principalColumn: "IdMenu");
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    Apellidos = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    Correo = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    Usuario = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    Clave = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    IdTienda = table.Column<int>(type: "int", nullable: true),
                    IdRol = table.Column<int>(type: "int", nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    FechaRegistro = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__USUARIO__5B65BF97C1E56415", x => x.IdUsuario);
                    table.ForeignKey(
                        name: "FK__USUARIO__IdRol__01142BA1",
                        column: x => x.IdRol,
                        principalTable: "Rol",
                        principalColumn: "IdRol");
                    table.ForeignKey(
                        name: "FK__USUARIO__IdTiend__47DBAE45",
                        column: x => x.IdTienda,
                        principalTable: "Tienda",
                        principalColumn: "IdTienda");
                });

            migrationBuilder.CreateTable(
                name: "ProductoTienda",
                columns: table => new
                {
                    IdProductoTienda = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProducto = table.Column<int>(type: "int", nullable: true),
                    IdTienda = table.Column<int>(type: "int", nullable: true),
                    PrecioUnidadCompra = table.Column<double>(type: "float", nullable: true, defaultValueSql: "((0))"),
                    PrecioUnidadVenta = table.Column<double>(type: "float", nullable: true, defaultValueSql: "((0))"),
                    Stock = table.Column<long>(type: "bigint", nullable: true, defaultValueSql: "((0))"),
                    Activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    Iniciado = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    FechaRegistro = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PRODUCTO__CE9B4C832D28B20F", x => x.IdProductoTienda);
                    table.ForeignKey(
                        name: "FK__PRODUCTO___IdPro__7E37BEF6",
                        column: x => x.IdProducto,
                        principalTable: "Producto",
                        principalColumn: "IdProducto");
                    table.ForeignKey(
                        name: "FK__PRODUCTO___IdTie__60A75C0F",
                        column: x => x.IdTienda,
                        principalTable: "Tienda",
                        principalColumn: "IdTienda");
                });

            migrationBuilder.CreateTable(
                name: "Permiso",
                columns: table => new
                {
                    IdPermisos = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdRol = table.Column<int>(type: "int", nullable: true),
                    IdSubMenu = table.Column<int>(type: "int", nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    FechaRegistro = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PERMISOS__CE7ED38D68B1795B", x => x.IdPermisos);
                    table.ForeignKey(
                        name: "FK__PERMISOS__IdRol__7B5B524B",
                        column: x => x.IdRol,
                        principalTable: "Rol",
                        principalColumn: "IdRol");
                    table.ForeignKey(
                        name: "FK__PERMISOS__IdSubM__7C4F7684",
                        column: x => x.IdSubMenu,
                        principalTable: "Submenu",
                        principalColumn: "IdSubMenu");
                });

            migrationBuilder.CreateTable(
                name: "Compra",
                columns: table => new
                {
                    IdCompra = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUsuario = table.Column<int>(type: "int", nullable: true),
                    IdProveedor = table.Column<int>(type: "int", nullable: true),
                    IdTienda = table.Column<int>(type: "int", nullable: true),
                    TotalCosto = table.Column<double>(type: "float", nullable: true, defaultValueSql: "((0))"),
                    TipoComprobante = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true, defaultValueSql: "('Boleta')"),
                    Activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    FechaRegistro = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__COMPRA__0A5CDB5C65B0F13C", x => x.IdCompra);
                    table.ForeignKey(
                        name: "FK__COMPRA__IdProvee__74AE54BC",
                        column: x => x.IdProveedor,
                        principalTable: "Proveedor",
                        principalColumn: "IdProveedor");
                    table.ForeignKey(
                        name: "FK__COMPRA__IdTienda__6B24EA82",
                        column: x => x.IdTienda,
                        principalTable: "Tienda",
                        principalColumn: "IdTienda");
                    table.ForeignKey(
                        name: "FK__COMPRA__IdUsuari__76969D2E",
                        column: x => x.IdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario");
                });

            migrationBuilder.CreateTable(
                name: "Venta",
                columns: table => new
                {
                    IdVenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ValorCodigo = table.Column<int>(type: "int", nullable: true),
                    IdTienda = table.Column<int>(type: "int", nullable: true),
                    IdUsuario = table.Column<int>(type: "int", nullable: true),
                    IdCliente = table.Column<int>(type: "int", nullable: true),
                    TipoDocumento = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CantidadProducto = table.Column<int>(type: "int", nullable: true),
                    CantidadTotal = table.Column<int>(type: "int", nullable: true),
                    TotalCosto = table.Column<double>(type: "float", nullable: true),
                    ImporteRecibido = table.Column<double>(type: "float", nullable: true),
                    ImporteCambio = table.Column<double>(type: "float", nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    FechaRegistro = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__VENTA__BC1240BD0E9CC8BB", x => x.IdVenta);
                    table.ForeignKey(
                        name: "FK__VENTA__IdCliente__02FC7413",
                        column: x => x.IdCliente,
                        principalTable: "Cliente",
                        principalColumn: "IdCliente");
                    table.ForeignKey(
                        name: "FK__VENTA__IdTienda__7B5B524B",
                        column: x => x.IdTienda,
                        principalTable: "Tienda",
                        principalColumn: "IdTienda");
                    table.ForeignKey(
                        name: "FK__VENTA__IdUsuario__04E4BC85",
                        column: x => x.IdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario");
                });

            migrationBuilder.CreateTable(
                name: "DetalleCompra",
                columns: table => new
                {
                    IdDetalleCompra = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCompra = table.Column<int>(type: "int", nullable: true),
                    IdProducto = table.Column<int>(type: "int", nullable: true),
                    Cantidad = table.Column<double>(type: "float", nullable: true),
                    PrecioUnitarioCompra = table.Column<double>(type: "float", nullable: true),
                    PrecioUnitarioVenta = table.Column<double>(type: "float", nullable: true),
                    TotalCosto = table.Column<double>(type: "float", nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    FechaRegistro = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DETALLE___E046CCBBE3E95D08", x => x.IdDetalleCompra);
                    table.ForeignKey(
                        name: "FK__DETALLE_C__IdCom__778AC167",
                        column: x => x.IdCompra,
                        principalTable: "Compra",
                        principalColumn: "IdCompra");
                    table.ForeignKey(
                        name: "FK__DETALLE_C__IdPro__787EE5A0",
                        column: x => x.IdProducto,
                        principalTable: "Producto",
                        principalColumn: "IdProducto");
                });

            migrationBuilder.CreateTable(
                name: "DetalleVenta",
                columns: table => new
                {
                    IdDetalleVenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdVenta = table.Column<int>(type: "int", nullable: true),
                    IdProducto = table.Column<int>(type: "int", nullable: true),
                    Cantidad = table.Column<int>(type: "int", nullable: true),
                    PrecioUnidad = table.Column<double>(type: "float", nullable: true),
                    ImporteTotal = table.Column<double>(type: "float", nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    FechaRegistro = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DETALLE___AAA5CEC25C3F852A", x => x.IdDetalleVenta);
                    table.ForeignKey(
                        name: "FK__DETALLE_V__IdPro__797309D9",
                        column: x => x.IdProducto,
                        principalTable: "Producto",
                        principalColumn: "IdProducto");
                    table.ForeignKey(
                        name: "FK__DETALLE_V__IdVen__7A672E12",
                        column: x => x.IdVenta,
                        principalTable: "Venta",
                        principalColumn: "IdVenta");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Compra_IdProveedor",
                table: "Compra",
                column: "IdProveedor");

            migrationBuilder.CreateIndex(
                name: "IX_Compra_IdTienda",
                table: "Compra",
                column: "IdTienda");

            migrationBuilder.CreateIndex(
                name: "IX_Compra_IdUsuario",
                table: "Compra",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleCompra_IdCompra",
                table: "DetalleCompra",
                column: "IdCompra");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleCompra_IdProducto",
                table: "DetalleCompra",
                column: "IdProducto");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleVenta_IdProducto",
                table: "DetalleVenta",
                column: "IdProducto");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleVenta_IdVenta",
                table: "DetalleVenta",
                column: "IdVenta");

            migrationBuilder.CreateIndex(
                name: "IX_Permiso_IdRol",
                table: "Permiso",
                column: "IdRol");

            migrationBuilder.CreateIndex(
                name: "IX_Permiso_IdSubMenu",
                table: "Permiso",
                column: "IdSubMenu");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_IdCategoria",
                table: "Producto",
                column: "IdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_ProductoTienda_IdProducto",
                table: "ProductoTienda",
                column: "IdProducto");

            migrationBuilder.CreateIndex(
                name: "IX_ProductoTienda_IdTienda",
                table: "ProductoTienda",
                column: "IdTienda");

            migrationBuilder.CreateIndex(
                name: "IX_Submenu_IdMenu",
                table: "Submenu",
                column: "IdMenu");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_IdRol",
                table: "Usuario",
                column: "IdRol");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_IdTienda",
                table: "Usuario",
                column: "IdTienda");

            migrationBuilder.CreateIndex(
                name: "IX_Venta_IdCliente",
                table: "Venta",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Venta_IdTienda",
                table: "Venta",
                column: "IdTienda");

            migrationBuilder.CreateIndex(
                name: "IX_Venta_IdUsuario",
                table: "Venta",
                column: "IdUsuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetalleCompra");

            migrationBuilder.DropTable(
                name: "DetalleVenta");

            migrationBuilder.DropTable(
                name: "Permiso");

            migrationBuilder.DropTable(
                name: "ProductoTienda");

            migrationBuilder.DropTable(
                name: "Compra");

            migrationBuilder.DropTable(
                name: "Venta");

            migrationBuilder.DropTable(
                name: "Submenu");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Proveedor");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Rol");

            migrationBuilder.DropTable(
                name: "Tienda");
        }
    }
}
