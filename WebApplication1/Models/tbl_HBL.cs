//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_HBL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_HBL()
        {
            this.tbl_CONTH = new HashSet<tbl_CONTH>();
            this.tbl_INVOICE = new HashSet<tbl_INVOICE>();
            this.tbl_TUTT_JOB = new HashSet<tbl_TUTT_JOB>();
        }
    
        public string HBL { get; set; }
        public string Request_ID { get; set; }
        public string Staff_ID { get; set; }
        public string Issue_placeH { get; set; }
        public Nullable<System.DateTime> Issue_dateH { get; set; }
        public Nullable<System.DateTime> OnBoard_dateH { get; set; }
        public byte[] HBL_file { get; set; }
        public string Customer_ID { get; set; }
        public string Shipper { get; set; }
        public string CNEE { get; set; }
        public string Notify_party { get; set; }
        public string BL_type { get; set; }
        public string Nom_Free { get; set; }
        public string Cont_Seal_No { get; set; }
        public string Volume { get; set; }
        public string Quantity { get; set; }
        public string Goods_desciption { get; set; }
        public Nullable<double> Gross_weight { get; set; }
        public Nullable<double> Tonnage { get; set; }
        public string Customs_declaration_No { get; set; }
        public string Invoice_No { get; set; }
        public string NumberofOrigins { get; set; }
        public string Freight_Payable { get; set; }
        public string Mark_Nos { get; set; }
        public Nullable<bool> Freight_charge { get; set; }
        public Nullable<bool> Prepaid { get; set; }
        public Nullable<bool> Collect { get; set; }
        public string SI_No { get; set; }
        public string PIC { get; set; }
        public Nullable<System.DateTime> DO_date { get; set; }
        public string PIC_phone { get; set; }
        public byte[] DO_file { get; set; }
        public byte[] GGT_file { get; set; }
    
        public virtual tbl_CNEE tbl_CNEE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CONTH> tbl_CONTH { get; set; }
        public virtual tbl_CUSTOMER tbl_CUSTOMER { get; set; }
        public virtual tbl_JOB tbl_JOB { get; set; }
        public virtual tbl_SHIPPER tbl_SHIPPER { get; set; }
        public virtual tbl_STAFF tbl_STAFF { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_INVOICE> tbl_INVOICE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_TUTT_JOB> tbl_TUTT_JOB { get; set; }
    }
}
