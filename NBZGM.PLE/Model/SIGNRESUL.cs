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
    
    public partial class SIGNRESUL
    {
        public string SIGNRESULTID { get; set; }
        public Nullable<System.DateTime> SIGNINSDATA { get; set; }
        public string AMTOPUNCH { get; set; }
        public string AMCLOCKOUT { get; set; }
        public string PMTOPUNCH { get; set; }
        public string PMCLOCKOUT { get; set; }
        public Nullable<decimal> RESTTIMES { get; set; }
        public Nullable<decimal> DRIVINGDISTANC { get; set; }
        public string REMARK { get; set; }
        public Nullable<decimal> USERID { get; set; }
    }
}