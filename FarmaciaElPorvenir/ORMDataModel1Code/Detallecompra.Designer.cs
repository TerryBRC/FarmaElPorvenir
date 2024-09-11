﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace FarmaciaElPorvenir.Database
{

    [Persistent(@"detallecompra")]
    public partial class Detallecompra : XPLiteObject
    {
        int fId;
        [Key(true)]
        public int Id
        {
            get { return fId; }
            set { SetPropertyValue<int>(nameof(Id), ref fId, value); }
        }
        Factura_compra fId_FacturaCompra;
        [Association(@"DetallecompraReferencesFactura_compra")]
        public Factura_compra Id_FacturaCompra
        {
            get { return fId_FacturaCompra; }
            set { SetPropertyValue<Factura_compra>(nameof(Id_FacturaCompra), ref fId_FacturaCompra, value); }
        }
        Producto fId_Producto;
        [Association(@"DetallecompraReferencesProducto")]
        public Producto Id_Producto
        {
            get { return fId_Producto; }
            set { SetPropertyValue<Producto>(nameof(Id_Producto), ref fId_Producto, value); }
        }
        int fCantidad;
        public int Cantidad
        {
            get { return fCantidad; }
            set { SetPropertyValue<int>(nameof(Cantidad), ref fCantidad, value); }
        }
        float fPrecio;
        public float Precio
        {
            get { return fPrecio; }
            set { SetPropertyValue<float>(nameof(Precio), ref fPrecio, value); }
        }
        float fTotal;
        public float Total
        {
            get { return fTotal; }
            set { SetPropertyValue<float>(nameof(Total), ref fTotal, value); }
        }
    }

}
