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
    
    public partial class BP_JGDGCJCXX
    {
        public BP_JGDGCJCXX()
        {
            this.BP_JGDTJJCXX = new HashSet<BP_JGDTJJCXX>();
        }
    
        public decimal JGDGC_ID { get; set; }
        public string JGDGC_NAME { get; set; }
        public string KZXSL { get; set; }
        public string KZXZLDD { get; set; }
        public Nullable<decimal> ZGL { get; set; }
        public string CKJG { get; set; }
        public string BZ { get; set; }
        public Nullable<System.DateTime> JGRQ { get; set; }
        public Nullable<System.DateTime> YJRQ { get; set; }
        public string DLTX { get; set; }
        public Nullable<decimal> YHDW_ID { get; set; }
    
        public virtual BD_JCJGDXX BD_JCJGDXX { get; set; }
        public virtual ICollection<BP_JGDTJJCXX> BP_JGDTJJCXX { get; set; }
    }
}