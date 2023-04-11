﻿namespace PartShop.Domain.Models
{
    public class ProductoModel
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public int Ano { get; set; }
    }
}