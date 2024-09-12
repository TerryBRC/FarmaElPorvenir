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

    [Persistent(@"cliente")]
    public partial class Cliente : XPLiteObject
    {
        int fId;
        [Key(true)]
        public int Id
        {
            get { return fId; }
            set { SetPropertyValue<int>(nameof(Id), ref fId, value); }
        }
        string fNombre_Completo;
        [Size(50)]
        public string Nombre_Completo
        {
            get { return fNombre_Completo; }
            set { SetPropertyValue<string>(nameof(Nombre_Completo), ref fNombre_Completo, value); }
        }
        string fDireccion;
        [Size(SizeAttribute.Unlimited)]
        public string Direccion
        {
            get { return fDireccion; }
            set { SetPropertyValue<string>(nameof(Direccion), ref fDireccion, value); }
        }
        int fTelefono;
        public int Telefono
        {
            get { return fTelefono; }
            set { SetPropertyValue<int>(nameof(Telefono), ref fTelefono, value); }
        }
        [Association(@"Factura_ventaReferencesCliente")]
        public XPCollection<Factura_venta> Factura_ventas { get { return GetCollection<Factura_venta>(nameof(Factura_ventas)); } }
    }

}