//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project.DAL.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class tm_pm_itemreport
    {
        public string TASKID { get; set; }
        public string PRETASK { get; set; }
        public Nullable<System.DateTime> SUBMITDATE { get; set; }
        public string SUBMITPROGRESS { get; set; }
        public string SUBMITREMARK { get; set; }
        public string PMANAGER { get; set; }
        public string ISCOMFIRM { get; set; }
        public string STARTDATE { get; set; }
        public Nullable<System.DateTime> COMFIRMDATE { get; set; }
        public string OWENRID { get; set; }
        public string OWNERDEPARTMENTID { get; set; }
        public string OWNERCOMPANYID { get; set; }
        public Nullable<System.DateTime> CREATETIME { get; set; }
        public string CREATEUSER { get; set; }
        public Nullable<System.DateTime> EDITTIME { get; set; }
        public string EDITUSER { get; set; }
    }
}
