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
    
    public partial class WF_WORKFLOWSPECIFICUSERFILES
    {
        public string FILEID { get; set; }
        public string WFSUID { get; set; }
        public Nullable<decimal> FILESOURCE { get; set; }
        public string FILEPATH { get; set; }
        public string FILENAME { get; set; }
        public string FILEREMARK { get; set; }
        public string FILETYPE { get; set; }
    
        public virtual WF_WORKFLOWSPECIFICUSERS WF_WORKFLOWSPECIFICUSERS { get; set; }
    }
}