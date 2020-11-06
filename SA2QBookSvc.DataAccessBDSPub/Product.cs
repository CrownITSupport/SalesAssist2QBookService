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
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.SalesOrderDetails = new HashSet<SalesOrderDetail>();
        }
    
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public int ProductGroupCode { get; set; }
        public string Description { get; set; }
        public string AlphaSortDescrip { get; set; }
        public string EachUnitOfMeas { get; set; }
        public string EachExtensionCode { get; set; }
        public Nullable<decimal> UnitCost { get; set; }
        public Nullable<double> OnHandQuantity { get; set; }
        public Nullable<double> OnHandWeight { get; set; }
        public Nullable<double> ReserveQuantity { get; set; }
        public Nullable<double> ReserveWeight { get; set; }
        public Nullable<double> ReserveOrdered { get; set; }
        public Nullable<System.DateTime> ReserveDateOrdered { get; set; }
        public Nullable<int> LastSaleInvoiceNumber { get; set; }
        public Nullable<System.DateTime> LastSaleDate { get; set; }
        public Nullable<int> LastSaleCustomer { get; set; }
        public Nullable<double> LastSaleQuantity { get; set; }
        public Nullable<decimal> LastSaleUnitPrice { get; set; }
        public Nullable<decimal> LastSaleDollarAmount { get; set; }
        public Nullable<int> ProductGroupId { get; set; }
        public string NewProductStatus { get; set; }
        public Nullable<System.DateTime> NewProductStopListingDate { get; set; }
        public string NewProductComments { get; set; }
        public string ProductSpecialStatus { get; set; }
        public Nullable<System.DateTime> ProductSpecialStartDate { get; set; }
        public Nullable<System.DateTime> ProductSpecialStopDate { get; set; }
        public string ProductSpecialComments { get; set; }
        public Nullable<System.DateTime> NewProductAvailableDate { get; set; }
        public string PresentInSourceDBF { get; set; }
    
        public virtual ProductGroup ProductGroup { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }
    }
}
