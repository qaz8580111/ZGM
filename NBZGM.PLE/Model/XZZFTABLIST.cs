//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Taizhou.PLE.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class XZZFTABLIST
    {
        public decimal ID { get; set; }
        public Nullable<decimal> AYXCFX { get; set; }
        public Nullable<decimal> ANYOTHER { get; set; }
        public Nullable<decimal> SIMPLEFKJ { get; set; }
        public Nullable<decimal> SIMPLEFKY { get; set; }
        public Nullable<decimal> CASELA { get; set; }
        public Nullable<decimal> CASEBJ { get; set; }
        public Nullable<decimal> CASEFAKY { get; set; }
        public Nullable<decimal> CASEMSWFSDY { get; set; }
        public Nullable<decimal> CASEMSWFCWY { get; set; }
        public Nullable<decimal> CASEQZCSJ { get; set; }
        public Nullable<decimal> CASEZLTYJ { get; set; }
        public Nullable<decimal> CASEOTHER { get; set; }
        public Nullable<decimal> CASEZZTZ { get; set; }
        public Nullable<decimal> CASESQFYZX { get; set; }
        public Nullable<System.DateTime> DTTIME { get; set; }
        public string TBUSER { get; set; }
        public string SHUSER { get; set; }
        public Nullable<decimal> CLASSID { get; set; }
        public Nullable<decimal> UNITNAMEID { get; set; }
    
        public virtual XZZFQUESTIONCLASS XZZFQUESTIONCLASS { get; set; }
    }
}