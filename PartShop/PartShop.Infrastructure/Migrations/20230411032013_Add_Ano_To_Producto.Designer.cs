﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PartShop.Infrastructure;

#nullable disable

namespace PartShop.Infrastructure.Migrations
{
    [DbContext(typeof(PartShopDbContext))]
    [Migration("20230411032013_Add_Ano_To_Producto")]
    partial class Add_Ano_To_Producto
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PartShop.Domain.Entities.Categoria", b =>
                {
                    b.Property<int>("IdCategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCategoria"), 1L, 1);

                    b.Property<bool>("Activo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("FechaRegistro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.HasKey("IdCategoria")
                        .HasName("PK__CATEGORI__A3C02A10A6E6D2F3");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("PartShop.Domain.Entities.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCliente"), 1L, 1);

                    b.Property<bool>("Activo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<string>("Direccion")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("FechaRegistro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("NumeroDocumento")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Telefono")
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)");

                    b.Property<string>("TipoDocumento")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdCliente")
                        .HasName("PK__CLIENTE__D59466424840A808");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("PartShop.Domain.Entities.Compra", b =>
                {
                    b.Property<int>("IdCompra")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCompra"), 1L, 1);

                    b.Property<bool>("Activo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<DateTime>("FechaRegistro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int?>("IdProveedor")
                        .HasColumnType("int");

                    b.Property<int?>("IdTienda")
                        .HasColumnType("int");

                    b.Property<int?>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("TipoComprobante")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasDefaultValueSql("('Boleta')");

                    b.Property<double?>("TotalCosto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("float")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("IdCompra")
                        .HasName("PK__COMPRA__0A5CDB5C65B0F13C");

                    b.HasIndex("IdProveedor");

                    b.HasIndex("IdTienda");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Compra");
                });

            modelBuilder.Entity("PartShop.Domain.Entities.DetalleCompra", b =>
                {
                    b.Property<int>("IdDetalleCompra")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDetalleCompra"), 1L, 1);

                    b.Property<bool>("Activo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<double?>("Cantidad")
                        .HasColumnType("float");

                    b.Property<DateTime>("FechaRegistro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int?>("IdCompra")
                        .HasColumnType("int");

                    b.Property<int?>("IdProducto")
                        .HasColumnType("int");

                    b.Property<double?>("PrecioUnitarioCompra")
                        .HasColumnType("float");

                    b.Property<double?>("PrecioUnitarioVenta")
                        .HasColumnType("float");

                    b.Property<double?>("TotalCosto")
                        .HasColumnType("float");

                    b.HasKey("IdDetalleCompra")
                        .HasName("PK__DETALLE___E046CCBBE3E95D08");

                    b.HasIndex("IdCompra");

                    b.HasIndex("IdProducto");

                    b.ToTable("DetalleCompra");
                });

            modelBuilder.Entity("PartShop.Domain.Entities.DetalleVenta", b =>
                {
                    b.Property<int>("IdDetalleVenta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDetalleVenta"), 1L, 1);

                    b.Property<bool>("Activo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<int?>("Cantidad")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaRegistro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int?>("IdProducto")
                        .HasColumnType("int");

                    b.Property<int?>("IdVenta")
                        .HasColumnType("int");

                    b.Property<double?>("ImporteTotal")
                        .HasColumnType("float");

                    b.Property<double?>("PrecioUnidad")
                        .HasColumnType("float");

                    b.HasKey("IdDetalleVenta")
                        .HasName("PK__DETALLE___AAA5CEC25C3F852A");

                    b.HasIndex("IdProducto");

                    b.HasIndex("IdVenta");

                    b.ToTable("DetalleVenta");
                });

            modelBuilder.Entity("PartShop.Domain.Entities.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Activo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("FechaRegistro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.HasKey("Id");

                    b.ToTable("Marca");
                });

            modelBuilder.Entity("PartShop.Domain.Entities.Menu", b =>
                {
                    b.Property<int>("IdMenu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMenu"), 1L, 1);

                    b.Property<bool>("Activo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<DateTime>("FechaRegistro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Icono")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)");

                    b.Property<string>("Nombre")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)");

                    b.HasKey("IdMenu")
                        .HasName("PK__MENU__4D7EA8E1DDB412F0");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("PartShop.Domain.Entities.Modelo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Activo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("FechaRegistro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int>("IdMarca")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdMarca");

                    b.ToTable("Modelo");
                });

            modelBuilder.Entity("PartShop.Domain.Entities.Permiso", b =>
                {
                    b.Property<int>("IdPermisos")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPermisos"), 1L, 1);

                    b.Property<bool>("Activo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<DateTime>("FechaRegistro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int?>("IdRol")
                        .HasColumnType("int");

                    b.Property<int?>("IdSubMenu")
                        .HasColumnType("int");

                    b.HasKey("IdPermisos")
                        .HasName("PK__PERMISOS__CE7ED38D68B1795B");

                    b.HasIndex("IdRol");

                    b.HasIndex("IdSubMenu");

                    b.ToTable("Permiso");
                });

            modelBuilder.Entity("PartShop.Domain.Entities.Producto", b =>
                {
                    b.Property<int>("IdProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProducto"), 1L, 1);

                    b.Property<bool>("Activo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<string>("Codigo")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("FechaRegistro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int?>("IdCategoria")
                        .HasColumnType("int");

                    b.Property<int?>("IdMarca")
                        .HasColumnType("int");

                    b.Property<int?>("IdModelo")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<int?>("ValorCodigo")
                        .HasColumnType("int");

                    b.HasKey("IdProducto")
                        .HasName("PK__PRODUCTO__0988921092E65D85");

                    b.HasIndex("IdCategoria");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("PartShop.Domain.Entities.ProductoTienda", b =>
                {
                    b.Property<int>("IdProductoTienda")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProductoTienda"), 1L, 1);

                    b.Property<bool>("Activo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<DateTime>("FechaRegistro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int?>("IdProducto")
                        .HasColumnType("int");

                    b.Property<int?>("IdTienda")
                        .HasColumnType("int");

                    b.Property<bool?>("Iniciado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<double?>("PrecioUnidadCompra")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("float")
                        .HasDefaultValueSql("((0))");

                    b.Property<double?>("PrecioUnidadVenta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("float")
                        .HasDefaultValueSql("((0))");

                    b.Property<long?>("Stock")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("IdProductoTienda")
                        .HasName("PK__PRODUCTO__CE9B4C832D28B20F");

                    b.HasIndex("IdProducto");

                    b.HasIndex("IdTienda");

                    b.ToTable("ProductoTienda");
                });

            modelBuilder.Entity("PartShop.Domain.Entities.Proveedor", b =>
                {
                    b.Property<int>("IdProveedor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProveedor"), 1L, 1);

                    b.Property<bool>("Activo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<string>("Correo")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Direccion")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("FechaRegistro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("RazonSocial")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Rnc")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("RNC");

                    b.Property<string>("Telefono")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdProveedor")
                        .HasName("PK__PROVEEDO__E8B631AF5AC20624");

                    b.ToTable("Proveedor");
                });

            modelBuilder.Entity("PartShop.Domain.Entities.Rol", b =>
                {
                    b.Property<int>("IdRol")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRol"), 1L, 1);

                    b.Property<bool>("Activo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)");

                    b.Property<DateTime>("FechaRegistro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.HasKey("IdRol")
                        .HasName("PK__ROL__2A49584CCF834DF6");

                    b.ToTable("Rol");
                });

            modelBuilder.Entity("PartShop.Domain.Entities.Submenu", b =>
                {
                    b.Property<int>("IdSubMenu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdSubMenu"), 1L, 1);

                    b.Property<bool>("Activo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<DateTime>("FechaRegistro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int?>("IdMenu")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)");

                    b.Property<string>("NombreFormulario")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)");

                    b.HasKey("IdSubMenu")
                        .HasName("PK__SUBMENU__CFDCE01ADBEDBD61");

                    b.HasIndex("IdMenu");

                    b.ToTable("Submenu");
                });

            modelBuilder.Entity("PartShop.Domain.Entities.Tienda", b =>
                {
                    b.Property<int>("IdTienda")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTienda"), 1L, 1);

                    b.Property<bool>("Activo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<string>("Direccion")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("FechaRegistro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Nombre")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)");

                    b.Property<string>("Rnc")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("RNC");

                    b.Property<string>("Telefono")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdTienda")
                        .HasName("PK__TIENDA__5A1EB96B8757EB7F");

                    b.ToTable("Tienda");
                });

            modelBuilder.Entity("PartShop.Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUsuario"), 1L, 1);

                    b.Property<bool>("Activo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<string>("Apellidos")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)");

                    b.Property<string>("Clave")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)");

                    b.Property<string>("Correo")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)");

                    b.Property<DateTime>("FechaRegistro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int?>("IdRol")
                        .HasColumnType("int");

                    b.Property<int?>("IdTienda")
                        .HasColumnType("int");

                    b.Property<string>("Nombres")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)");

                    b.Property<string>("Usuario1")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("Usuario");

                    b.HasKey("IdUsuario")
                        .HasName("PK__USUARIO__5B65BF97C1E56415");

                    b.HasIndex("IdRol");

                    b.HasIndex("IdTienda");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("PartShop.Domain.Entities.Venta", b =>
                {
                    b.Property<int>("IdVenta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdVenta"), 1L, 1);

                    b.Property<bool>("Activo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<int?>("CantidadProducto")
                        .HasColumnType("int");

                    b.Property<int?>("CantidadTotal")
                        .HasColumnType("int");

                    b.Property<string>("Codigo")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("FechaRegistro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int?>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int?>("IdTienda")
                        .HasColumnType("int");

                    b.Property<int?>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<double?>("ImporteCambio")
                        .HasColumnType("float");

                    b.Property<double?>("ImporteRecibido")
                        .HasColumnType("float");

                    b.Property<string>("TipoDocumento")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<double?>("TotalCosto")
                        .HasColumnType("float");

                    b.Property<int?>("ValorCodigo")
                        .HasColumnType("int");

                    b.HasKey("IdVenta")
                        .HasName("PK__VENTA__BC1240BD0E9CC8BB");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdTienda");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Venta");
                });

            modelBuilder.Entity("PartShop.Domain.Entities.Compra", b =>
                {
                    b.HasOne("PartShop.Domain.Entities.Proveedor", "IdProveedorNavigation")
                        .WithMany("Compras")
                        .HasForeignKey("IdProveedor")
                        .HasConstraintName("FK__COMPRA__IdProvee__74AE54BC");

                    b.HasOne("PartShop.Domain.Entities.Tienda", "IdTiendaNavigation")
                        .WithMany("Compras")
                        .HasForeignKey("IdTienda")
                        .HasConstraintName("FK__COMPRA__IdTienda__6B24EA82");

                    b.HasOne("PartShop.Domain.Entities.Usuario", "IdUsuarioNavigation")
                        .WithMany("Compras")
                        .HasForeignKey("IdUsuario")
                        .HasConstraintName("FK__COMPRA__IdUsuari__76969D2E");

                    b.Navigation("IdProveedorNavigation");

                    b.Navigation("IdTiendaNavigation");

                    b.Navigation("IdUsuarioNavigation");
                });

            modelBuilder.Entity("PartShop.Domain.Entities.DetalleCompra", b =>
                {
                    b.HasOne("PartShop.Domain.Entities.Compra", "IdCompraNavigation")
                        .WithMany("DetalleCompras")
                        .HasForeignKey("IdCompra")
                        .HasConstraintName("FK__DETALLE_C__IdCom__778AC167");

                    b.HasOne("PartShop.Domain.Entities.Producto", "IdProductoNavigation")
                        .WithMany("DetalleCompras")
                        .HasForeignKey("IdProducto")
                        .HasConstraintName("FK__DETALLE_C__IdPro__787EE5A0");

                    b.Navigation("IdCompraNavigation");

                    b.Navigation("IdProductoNavigation");
                });

            modelBuilder.Entity("PartShop.Domain.Entities.DetalleVenta", b =>
                {
                    b.HasOne("PartShop.Domain.Entities.Producto", "IdProductoNavigation")
                        .WithMany("DetalleVenta")
                        .HasForeignKey("IdProducto")
                        .HasConstraintName("FK__DETALLE_V__IdPro__797309D9");

                    b.HasOne("PartShop.Domain.Entities.Venta", "IdVentaNavigation")
                        .WithMany("DetalleVenta")
                        .HasForeignKey("IdVenta")
                        .HasConstraintName("FK__DETALLE_V__IdVen__7A672E12");

                    b.Navigation("IdProductoNavigation");

                    b.Navigation("IdVentaNavigation");
                });

            modelBuilder.Entity("PartShop.Domain.Entities.Modelo", b =>
                {
                    b.HasOne("PartShop.Domain.Entities.Marca", "Marca")
                        .WithMany("Modelos")
                        .HasForeignKey("IdMarca")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Marca");
                });

            modelBuilder.Entity("PartShop.Domain.Entities.Permiso", b =>
                {
                    b.HasOne("PartShop.Domain.Entities.Rol", "IdRolNavigation")
                        .WithMany("Permisos")
                        .HasForeignKey("IdRol")
                        .HasConstraintName("FK__PERMISOS__IdRol__7B5B524B");

                    b.HasOne("PartShop.Domain.Entities.Submenu", "IdSubMenuNavigation")
                        .WithMany("Permisos")
                        .HasForeignKey("IdSubMenu")
                        .HasConstraintName("FK__PERMISOS__IdSubM__7C4F7684");

                    b.Navigation("IdRolNavigation");

                    b.Navigation("IdSubMenuNavigation");
                });

            modelBuilder.Entity("PartShop.Domain.Entities.Producto", b =>
                {
                    b.HasOne("PartShop.Domain.Entities.Categoria", "IdCategoriaNavigation")
                        .WithMany("Productos")
                        .HasForeignKey("IdCategoria")
                        .HasConstraintName("FK__PRODUCTO__IdCate__7D439ABD");

                    b.Navigation("IdCategoriaNavigation");
                });

            modelBuilder.Entity("PartShop.Domain.Entities.ProductoTienda", b =>
                {
                    b.HasOne("PartShop.Domain.Entities.Producto", "IdProductoNavigation")
                        .WithMany("ProductoTienda")
                        .HasForeignKey("IdProducto")
                        .HasConstraintName("FK__PRODUCTO___IdPro__7E37BEF6");

                    b.HasOne("PartShop.Domain.Entities.Tienda", "IdTiendaNavigation")
                        .WithMany("ProductoTienda")
                        .HasForeignKey("IdTienda")
                        .HasConstraintName("FK__PRODUCTO___IdTie__60A75C0F");

                    b.Navigation("IdProductoNavigation");

                    b.Navigation("IdTiendaNavigation");
                });

            modelBuilder.Entity("PartShop.Domain.Entities.Submenu", b =>
                {
                    b.HasOne("PartShop.Domain.Entities.Menu", "IdMenuNavigation")
                        .WithMany("Submenus")
                        .HasForeignKey("IdMenu")
                        .HasConstraintName("FK__SUBMENU__IdMenu__00200768");

                    b.Navigation("IdMenuNavigation");
                });

            modelBuilder.Entity("PartShop.Domain.Entities.Usuario", b =>
                {
                    b.HasOne("PartShop.Domain.Entities.Rol", "IdRolNavigation")
                        .WithMany("Usuarios")
                        .HasForeignKey("IdRol")
                        .HasConstraintName("FK__USUARIO__IdRol__01142BA1");

                    b.HasOne("PartShop.Domain.Entities.Tienda", "IdTiendaNavigation")
                        .WithMany("Usuarios")
                        .HasForeignKey("IdTienda")
                        .HasConstraintName("FK__USUARIO__IdTiend__47DBAE45");

                    b.Navigation("IdRolNavigation");

                    b.Navigation("IdTiendaNavigation");
                });

            modelBuilder.Entity("PartShop.Domain.Entities.Venta", b =>
                {
                    b.HasOne("PartShop.Domain.Entities.Cliente", "IdClienteNavigation")
                        .WithMany("Venta")
                        .HasForeignKey("IdCliente")
                        .HasConstraintName("FK__VENTA__IdCliente__02FC7413");

                    b.HasOne("PartShop.Domain.Entities.Tienda", "IdTiendaNavigation")
                        .WithMany("Venta")
                        .HasForeignKey("IdTienda")
                        .HasConstraintName("FK__VENTA__IdTienda__7B5B524B");

                    b.HasOne("PartShop.Domain.Entities.Usuario", "IdUsuarioNavigation")
                        .WithMany("Venta")
                        .HasForeignKey("IdUsuario")
                        .HasConstraintName("FK__VENTA__IdUsuario__04E4BC85");

                    b.Navigation("IdClienteNavigation");

                    b.Navigation("IdTiendaNavigation");

                    b.Navigation("IdUsuarioNavigation");
                });

            modelBuilder.Entity("PartShop.Domain.Entities.Categoria", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("PartShop.Domain.Entities.Cliente", b =>
                {
                    b.Navigation("Venta");
                });

            modelBuilder.Entity("PartShop.Domain.Entities.Compra", b =>
                {
                    b.Navigation("DetalleCompras");
                });

            modelBuilder.Entity("PartShop.Domain.Entities.Marca", b =>
                {
                    b.Navigation("Modelos");
                });

            modelBuilder.Entity("PartShop.Domain.Entities.Menu", b =>
                {
                    b.Navigation("Submenus");
                });

            modelBuilder.Entity("PartShop.Domain.Entities.Producto", b =>
                {
                    b.Navigation("DetalleCompras");

                    b.Navigation("DetalleVenta");

                    b.Navigation("ProductoTienda");
                });

            modelBuilder.Entity("PartShop.Domain.Entities.Proveedor", b =>
                {
                    b.Navigation("Compras");
                });

            modelBuilder.Entity("PartShop.Domain.Entities.Rol", b =>
                {
                    b.Navigation("Permisos");

                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("PartShop.Domain.Entities.Submenu", b =>
                {
                    b.Navigation("Permisos");
                });

            modelBuilder.Entity("PartShop.Domain.Entities.Tienda", b =>
                {
                    b.Navigation("Compras");

                    b.Navigation("ProductoTienda");

                    b.Navigation("Usuarios");

                    b.Navigation("Venta");
                });

            modelBuilder.Entity("PartShop.Domain.Entities.Usuario", b =>
                {
                    b.Navigation("Compras");

                    b.Navigation("Venta");
                });

            modelBuilder.Entity("PartShop.Domain.Entities.Venta", b =>
                {
                    b.Navigation("DetalleVenta");
                });
#pragma warning restore 612, 618
        }
    }
}
