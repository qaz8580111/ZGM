//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZGM.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class BD_JCJDXX
    {
        public BD_JCJDXX()
        {
            this.BD_JCBZXX = new HashSet<BD_JCBZXX>();
            this.BD_JCFHLDSSJDGX = new HashSet<BD_JCFHLDSSJDGX>();
            this.BD_JCGCXX = new HashSet<BD_JCGCXX>();
            this.BD_JCJGDSSJDGX = new HashSet<BD_JCJGDSSJDGX>();
            this.BD_JCLKLDCXDSSJDGX = new HashSet<BD_JCLKLDCXDSSJDGX>();
            this.BD_JCQLSSJDGX = new HashSet<BD_JCQLSSJDGX>();
            this.BP_GYLDSSJDGX = new HashSet<BP_GYLDSSJDGX>();
        }
    
        public decimal JCJD_ID { get; set; }
        public string JCJD_NAME { get; set; }
        public string DLTX { get; set; }
        public Nullable<decimal> ZXDXZB { get; set; }
        public Nullable<decimal> ZXDYZB { get; set; }
        public string SFYX { get; set; }
        public Nullable<System.DateTime> CJSJ { get; set; }
    
        public virtual ICollection<BD_JCBZXX> BD_JCBZXX { get; set; }
        public virtual ICollection<BD_JCFHLDSSJDGX> BD_JCFHLDSSJDGX { get; set; }
        public virtual ICollection<BD_JCGCXX> BD_JCGCXX { get; set; }
        public virtual ICollection<BD_JCJGDSSJDGX> BD_JCJGDSSJDGX { get; set; }
        public virtual ICollection<BD_JCLKLDCXDSSJDGX> BD_JCLKLDCXDSSJDGX { get; set; }
        public virtual ICollection<BD_JCQLSSJDGX> BD_JCQLSSJDGX { get; set; }
        public virtual ICollection<BP_GYLDSSJDGX> BP_GYLDSSJDGX { get; set; }
    }
}
