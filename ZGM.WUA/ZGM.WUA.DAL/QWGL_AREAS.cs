//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZGM.WUA.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class QWGL_AREAS
    {
        public QWGL_AREAS()
        {
            this.QWGL_CARTASKRAREARS = new HashSet<QWGL_CARTASKRAREARS>();
            this.QWGL_RESTAREARS = new HashSet<QWGL_RESTAREARS>();
            this.QWGL_USERTASKAREARS = new HashSet<QWGL_USERTASKAREARS>();
        }
    
        public decimal AREAID { get; set; }
        public string AREANAME { get; set; }
        public string AREADESCRIPTION { get; set; }
        public string GEOMETRY { get; set; }
        public Nullable<decimal> AREAOWNERTYPE { get; set; }
        public Nullable<decimal> CREATEUSERID { get; set; }
        public Nullable<System.DateTime> CREATETIME { get; set; }
        public Nullable<decimal> STATE { get; set; }
        public Nullable<decimal> SQENUM { get; set; }
        public string COLOR { get; set; }
    
        public virtual ICollection<QWGL_CARTASKRAREARS> QWGL_CARTASKRAREARS { get; set; }
        public virtual ICollection<QWGL_RESTAREARS> QWGL_RESTAREARS { get; set; }
        public virtual ICollection<QWGL_USERTASKAREARS> QWGL_USERTASKAREARS { get; set; }
    }
}