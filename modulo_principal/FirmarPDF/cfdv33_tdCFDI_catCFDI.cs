﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Schema;
using System.Xml.Serialization;

// 
// Este código fuente fue generado automáticamente por xsd, Versión=4.6.1055.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.sat.gob.mx/cfd/3", IsNullable = false)]
public partial class Comprobante
{

    private ComprobanteEmisor emisorField;

    private ComprobanteReceptor receptorField;

    private ComprobanteConcepto[] conceptosField;

    private ComprobanteImpuestos impuestosField;

    private ComprobanteComplemento[] complementoField;

    private ComprobanteMayor200 mayor200;

    //version de la factura
    private string versionField;
    //fecha en la que se entregan los bienes cuando sea posterior a la factura
    private string fecha_operacion;
    //activar la fecha de operacion
    private bool fechaOperacionSpecified;
    //indica el numero asignado de la factura
    private string num_factura;
    //inicio del correlativo con su serie autorizada
    private string correlativo_inicio;
    //final del correlativo con su serie autorizada
    private string correlativo_final;
    //fecha de la emision de la factura
    private string fecha_expedicicion;
    //sello de la factura
    private string selloField;
    //la forma en la que se realiza el pago
    private string formaPagoField;
    //se activa la forma de pago de la factura
    private bool formaPagoFieldSpecified;
    //numero del certifica que lo firma
    private string noCertificadoField;
    //certificado encriptado
    private string certificadoField;
    //si son al contado o al credito
    private string condicionesDePagoField;
    //subtotal de toda la factura
    private decimal subTotalField;
    //total de descuento de la factura
    private decimal descuentoField;
    //activando el campo del descuento general de la factura
    private bool descuentoFieldSpecified;
    //Moneda de con la se realiza el intercambio
    private string monedaField;
    //
    private decimal tipoCambioField;

    private bool tipoCambioFieldSpecified;

    private decimal totalField;

    private string tipoDeComprobanteField;

    private string metodoPagoField;

    private bool metodoPagoFieldSpecified;

    private string lugarExpedicionField;

    private string confirmacionField;

    private string num_resolucion;

    private string fecha_res;

    private string cantidad_letras;



    [XmlAttribute("SchemaLocation", Namespace = XmlSchema.InstanceNamespace)]
    public string xsiSchemaLocation = "http://www.sat.gob.mx/sitio_internet/cfd/3/cfdv33.xsd";

    public Comprobante()
    {
        this.versionField = "3.3";
    }

    /// <remarks/>
    public ComprobanteEmisor Emisor
    {
        get
        {
            return this.emisorField;
        }
        set
        {
            this.emisorField = value;
        }
    }

    /// <remarks/>
    public ComprobanteReceptor Receptor
    {
        get
        {
            return this.receptorField;
        }
        set
        {
            this.receptorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Concepto", IsNullable = false)]
    public ComprobanteConcepto[] Conceptos
    {
        get
        {
            return this.conceptosField;
        }
        set
        {
            this.conceptosField = value;
        }
    }
    
    /// <remarks/>
    public ComprobanteImpuestos Impuestos
    {
        get
        {
            return this.impuestosField;
        }
        set
        {
            this.impuestosField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Complemento")]
    public ComprobanteComplemento[] Complemento
    {
        get
        {
            return this.complementoField;
        }
        set
        {
            this.complementoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Version
    {
        get
        {
            return this.versionField;
        }
        set
        {
            this.versionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NumFactura
    {
        get
        {
            return this.num_factura;
        }
        set
        {
            this.num_factura = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CorrInicio
    {
        get
        {
            return this.correlativo_inicio;
        }
        set
        {
            this.correlativo_inicio = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CorrFinal
    {
        get
        {
            return this.correlativo_final;
        }
        set
        {
            this.correlativo_final = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string FechaExpedicion
    {
        get
        {
            return this.fecha_expedicicion;
        }
        set
        {
            this.fecha_expedicicion = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string FechaOperacion
    {
        get
        {
            return this.fecha_operacion;
        }
        set
        {
            this.fecha_operacion = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool FechaOperacionSpecified
    {
        get
        {
            return this.fechaOperacionSpecified;
        }
        set
        {
            this.fechaOperacionSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Sello
    {
        get
        {
            return this.selloField;
        }
        set
        {
            this.selloField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string FormaPago
    {
        get
        {
            return this.formaPagoField;
        }
        set
        {
            this.formaPagoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool FormaPagoSpecified
    {
        get
        {
            return this.formaPagoFieldSpecified;
        }
        set
        {
            this.formaPagoFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NoCertificado
    {
        get
        {
            return this.noCertificadoField;
        }
        set
        {
            this.noCertificadoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Certificado
    {
        get
        {
            return this.certificadoField;
        }
        set
        {
            this.certificadoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CondicionesDePago
    {
        get
        {
            return this.condicionesDePagoField;
        }
        set
        {
            this.condicionesDePagoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal SubTotal
    {
        get
        {
            return this.subTotalField;
        }
        set
        {
            this.subTotalField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Descuento
    {
        get
        {
            return this.descuentoField;
        }
        set
        {
            this.descuentoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DescuentoSpecified
    {
        get
        {
            return this.descuentoFieldSpecified;
        }
        set
        {
            this.descuentoFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Moneda
    {
        get
        {
            return this.monedaField;
        }
        set
        {
            this.monedaField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal TipoCambio
    {
        get
        {
            return this.tipoCambioField;
        }
        set
        {
            this.tipoCambioField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TipoCambioSpecified
    {
        get
        {
            return this.tipoCambioFieldSpecified;
        }
        set
        {
            this.tipoCambioFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Total
    {
        get
        {
            return this.totalField;
        }
        set
        {
            this.totalField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TipoDeComprobante
    {
        get
        {
            return this.tipoDeComprobanteField;
        }
        set
        {
            this.tipoDeComprobanteField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string MetodoPago
    {
        get
        {
            return this.metodoPagoField;
        }
        set
        {
            this.metodoPagoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool MetodoPagoSpecified
    {
        get
        {
            return this.metodoPagoFieldSpecified;
        }
        set
        {
            this.metodoPagoFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string LugarExpedicion
    {
        get
        {
            return this.lugarExpedicionField;
        }
        set
        {
            this.lugarExpedicionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Confirmacion
    {
        get
        {
            return this.confirmacionField;
        }
        set
        {
            this.confirmacionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NumResolucion
    {
        get
        {
            return this.num_resolucion;
        }
        set
        {
            this.num_resolucion = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string FechaResolucion
    {
        get
        {
            return this.fecha_res;
        }
        set
        {
            this.fecha_res = value;
        }
    }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Cantidad_letras
    {
        get
        {
            return cantidad_letras;
        }

        set
        {
            cantidad_letras = value;
        }
    }

    public ComprobanteMayor200 Mayor200
    {
        get
        {
            return mayor200;
        }

        set
        {
            mayor200 = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
public partial class ComprobanteMayor200
{
    private string nombre_persona_recibe;
    private string nombre_persona_entrega;
    private string dui_persona_recibe;
    private string nit_persona_recibe;
    private string dui_persona_entrega;
    private string nit_persona_entrega;

    [System.Xml.Serialization.XmlAttributeAttribute]
    public string Nombre_persona_recibe
    {
        get
        {
            return nombre_persona_recibe;
        }

        set
        {
            nombre_persona_recibe = value;
        }
    }

    [System.Xml.Serialization.XmlAttributeAttribute]
    public string Nombre_persona_entrega
    {
        get
        {
            return nombre_persona_entrega;
        }

        set
        {
            nombre_persona_entrega = value;
        }
    }

    [System.Xml.Serialization.XmlAttributeAttribute]
    public string Dui_persona_recibe
    {
        get
        {
            return dui_persona_recibe;
        }

        set
        {
            dui_persona_recibe = value;
        }
    }

    [System.Xml.Serialization.XmlAttributeAttribute]
    public string Nit_persona_recibe
    {
        get
        {
            return nit_persona_recibe;
        }

        set
        {
            nit_persona_recibe = value;
        }
    }

    [System.Xml.Serialization.XmlAttributeAttribute]
    public string Dui_persona_entrega
    {
        get
        {
            return dui_persona_entrega;
        }

        set
        {
            dui_persona_entrega = value;
        }
    }

    [System.Xml.Serialization.XmlAttributeAttribute]
    public string Nit_persona_entrega
    {
        get
        {
            return nit_persona_entrega;
        }

        set
        {
            nit_persona_entrega = value;
        }
    }
}
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
public partial class ComprobanteEmisor
{

    private string nrc;

    private string nombre_empresa;

    private string razon_social;

    private string denominacion;

    private string giro;

    private string direccion_local;

    private string nit;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NRC
    {
        get
        {
            return this.nrc;
        }
        set
        {
            this.nrc = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NombreEmpresa
    {
        get
        {
            return this.nombre_empresa;
        }
        set
        {
            this.nombre_empresa = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string RazonSocial
    {
        get
        {
            return this.razon_social;
        }
        set
        {
            this.razon_social = value;
        }
    }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Denominacion
    {
        get
        {
            return denominacion;
        }

        set
        {
            denominacion = value;
        }
    }

    [System.Xml.Serialization.XmlAttributeAttribute]
    public string Giro
    {
        get
        {
            return giro;
        }

        set
        {
            giro = value;
        }
    }

    [System.Xml.Serialization.XmlAttributeAttribute]
    public string Direccion_Local
    {
        get
        {
            return direccion_local;
        }

        set
        {
            direccion_local = value;
        }
    }

    [System.Xml.Serialization.XmlAttributeAttribute]
    public string Nit
    {
        get
        {
            return nit;
        }

        set
        {
            nit = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
public partial class ComprobanteReceptor
{

    private string nrc;

    private string nombre_cliente;

    private string denominacion;

    private string razon_social;

    private string giro;

    private string direccion;

    private string nit;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NRC
    {
        get
        {
            return this.nrc;
        }
        set
        {
            this.nrc = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Nombre_Cliente
    {
        get
        {
            return this.nombre_cliente;
        }
        set
        {
            this.nombre_cliente = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Denominacion
    {
        get
        {
            return this.denominacion;
        }
        set
        {
            this.denominacion = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public string Razon_Social
    {
        get
        {
            return this.razon_social;
        }
        set
        {
            this.razon_social = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Giro
    {
        get
        {
            return this.giro;
        }
        set
        {
            this.giro = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Direccion
    {
        get
        {
            return this.direccion;
        }
        set
        {
            this.direccion = value;
        }
    }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Nit
    {
        get
        {
            return nit;
        }

        set
        {
            nit = value;
        }
    }
}


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
public partial class ComprobanteConcepto
{

    private ComprobanteConceptoComplementoConcepto complementoConceptoField;

    private ComprobanteConceptoParte[] parteField;

    private decimal cantidad;

    private string descripcion;

    private decimal precio_unitario;

    private decimal monto_total;

    private decimal operaciones_gravadas;

    private decimal ventas_exentas;

    private decimal ventas_no_sujetas;

    private string condiciones_de_operaciones;

    private decimal descuentoField;

    private bool descuentoFieldSpecified;

    /// <remarks/>
    public ComprobanteConceptoComplementoConcepto ComplementoConcepto
    {
        get
        {
            return this.complementoConceptoField;
        }
        set
        {
            this.complementoConceptoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Parte")]
    public ComprobanteConceptoParte[] Parte
    {
        get
        {
            return this.parteField;
        }
        set
        {
            this.parteField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Cantidad
    {
        get
        {
            return this.cantidad;
        }
        set
        {
            this.cantidad = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Descripcion
    {
        get
        {
            return this.descripcion;
        }
        set
        {
            this.descripcion = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Precio_Unitario
    {
        get
        {
            return this.precio_unitario;
        }
        set
        {
            this.precio_unitario = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Monto_Total
    {
        get
        {
            return this.monto_total;
        }
        set
        {
            this.monto_total = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Operaciones_Gravadas
    {
        get
        {
            return this.operaciones_gravadas;
        }
        set
        {
            this.operaciones_gravadas = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Ventas_Exentas
    {
        get
        {
            return this.ventas_exentas;
        }
        set
        {
            this.ventas_exentas = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Ventas_No_Sujetas
    {
        get
        {
            return this.ventas_no_sujetas;
        }
        set
        {
            this.ventas_no_sujetas = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Condiciones
    {
        get
        {
            return this.condiciones_de_operaciones;
        }
        set
        {
            this.condiciones_de_operaciones = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Descuento
    {
        get
        {
            return this.descuentoField;
        }
        set
        {
            this.descuentoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DescuentoSpecified
    {
        get
        {
            return this.descuentoFieldSpecified;
        }
        set
        {
            this.descuentoFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
public partial class ComprobanteConceptoComplementoConcepto
{

    private System.Xml.XmlElement[] anyField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public System.Xml.XmlElement[] Any
    {
        get
        {
            return this.anyField;
        }
        set
        {
            this.anyField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
public partial class ComprobanteConceptoParte
{

    private string claveProdServField;

    private string noIdentificacionField;

    private decimal cantidadField;

    private string unidadField;

    private string descripcionField;

    private decimal valorUnitarioField;

    private bool valorUnitarioFieldSpecified;

    private decimal importeField;

    private bool importeFieldSpecified;


    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ClaveProdServ
    {
        get
        {
            return this.claveProdServField;
        }
        set
        {
            this.claveProdServField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NoIdentificacion
    {
        get
        {
            return this.noIdentificacionField;
        }
        set
        {
            this.noIdentificacionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Cantidad
    {
        get
        {
            return this.cantidadField;
        }
        set
        {
            this.cantidadField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Unidad
    {
        get
        {
            return this.unidadField;
        }
        set
        {
            this.unidadField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Descripcion
    {
        get
        {
            return this.descripcionField;
        }
        set
        {
            this.descripcionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal ValorUnitario
    {
        get
        {
            return this.valorUnitarioField;
        }
        set
        {
            this.valorUnitarioField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ValorUnitarioSpecified
    {
        get
        {
            return this.valorUnitarioFieldSpecified;
        }
        set
        {
            this.valorUnitarioFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Importe
    {
        get
        {
            return this.importeField;
        }
        set
        {
            this.importeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ImporteSpecified
    {
        get
        {
            return this.importeFieldSpecified;
        }
        set
        {
            this.importeFieldSpecified = value;
        }
    }
}


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
public partial class ComprobanteImpuestos
{

    private ComprobanteImpuestosRetencion[] retencionesField;

    private decimal total_iva;

    private bool total_iva_Specified;

    private decimal total_renta;

    private bool total_renta_Specified;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Retencion", IsNullable = false)]
    public ComprobanteImpuestosRetencion[] Retenciones
    {
        get
        {
            return this.retencionesField;
        }
        set
        {
            this.retencionesField = value;
        }
    }


    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Total_Iva
    {
        get
        {
            return this.total_iva;
        }
        set
        {
            this.total_iva = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool Total_Iva_Specified
    {
        get
        {
            return this.total_iva_Specified;
        }
        set
        {
            this.total_iva_Specified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Total_Renta
    {
        get
        {
            return this.total_renta;
        }
        set
        {
            this.total_renta = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool Total_Renta_Specified
    {
        get
        {
            return this.total_renta_Specified;
        }
        set
        {
            this.total_renta_Specified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
public partial class ComprobanteImpuestosRetencion
{

    private string impuestoField;

    private decimal importeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Impuesto
    {
        get
        {
            return this.impuestoField;
        }
        set
        {
            this.impuestoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Importe
    {
        get
        {
            return this.importeField;
        }
        set
        {
            this.importeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
public partial class ComprobanteComplemento
{

    private System.Xml.XmlElement[] anyField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public System.Xml.XmlElement[] Any
    {
        get
        {
            return this.anyField;
        }
        set
        {
            this.anyField = value;
        }
    }
}


