//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SA2QBookSvc.DataAccessBDSPub
{
    using System;
    using System.Collections.Generic;
    
    public partial class SalesOrderHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SalesOrderHeader()
        {
            this.SalesOrderDetails = new HashSet<SalesOrderDetail>();
        }
    
        public int Id { get; set; }
        public int SalesOrderNumber { get; set; }
        public Nullable<int> SalesRepNumber { get; set; }
        public Nullable<int> CustomerNumber { get; set; }
        public string ShipToCompanyName { get; set; }
        public string ShipToAddressLine1 { get; set; }
        public string ShipToAddressLine2 { get; set; }
        public string ShipToCity { get; set; }
        public string ShipToState { get; set; }
        public string ShipToPostalCode { get; set; }
        public string CreditTerms { get; set; }
        public Nullable<System.DateTime> DateSalesOrderEntered { get; set; }
        public Nullable<System.DateTime> DateDeliveryRequired { get; set; }
        public string DeliveryReqComments { get; set; }
        public Nullable<System.DateTime> DeliveryScheduledDate { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public string SalesOrderReceivedBy { get; set; }
        public string SalesOrderEnteredBy { get; set; }
        public string SalesOrderComments { get; set; }
        public string HowShipped { get; set; }
        public string ShipVia { get; set; }
        public Nullable<int> DeliveryRoute { get; set; }
        public Nullable<int> DeliveryRouteStop { get; set; }
        public Nullable<int> NumberOfPieces { get; set; }
        public Nullable<double> ShipmentWeight { get; set; }
        public string FreightFobDescrip { get; set; }
        public string FreightPrepaid { get; set; }
        public string OrderHasBeenVoided { get; set; }
        public Nullable<System.DateTime> OrderVoidedDateTime { get; set; }
        public string OrderVoidedBy { get; set; }
        public string OrderVoidApprovedBy { get; set; }
        public string OrderVoidedReason { get; set; }
        public string PostedToInventory { get; set; }
        public string InvoicingStatus { get; set; }
        public Nullable<System.DateTime> InvoicedAtDateTime { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public Nullable<int> InvoiceNumber { get; set; }
        public string HasBeenBackordered { get; set; }
        public Nullable<int> BackOrderedToOrderNum { get; set; }
        public Nullable<int> BackOrderedFromOrderNum { get; set; }
        public string BackOrderedFromPONumber { get; set; }
        public string SaleIsTaxable { get; set; }
        public Nullable<double> SalesTaxRate { get; set; }
        public string SalesTaxingAuthority { get; set; }
        public Nullable<decimal> TotFreightAmt { get; set; }
        public Nullable<double> DiscountPercent { get; set; }
        public Nullable<decimal> TotDiscountAmt { get; set; }
        public Nullable<decimal> TotExtraChargeAmt { get; set; }
        public Nullable<decimal> TotCodFee { get; set; }
        public Nullable<decimal> TotDutyFee { get; set; }
        public Nullable<decimal> TotTaxAmt { get; set; }
        public Nullable<decimal> TotProductPriceAmt { get; set; }
        public Nullable<decimal> TotInvoiceAmt { get; set; }
        public Nullable<decimal> TotInvoiceProductCost { get; set; }
        public Nullable<decimal> TotBaseCommissionAmt { get; set; }
        public Nullable<decimal> TotSplitCommissionAmt { get; set; }
        public Nullable<decimal> TotCommissionAmt { get; set; }
        public Nullable<int> SalesRepNumber2 { get; set; }
        public Nullable<System.DateTime> DateTimeOrderPrinted { get; set; }
        public Nullable<System.DateTime> DateTimeInvoicePrinted { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public string PresentInSourceDBF { get; set; }
    
        public virtual Customer Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }
    }
}
