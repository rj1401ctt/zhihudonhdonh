//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class 报名记录
    {
        public int Id { get; set; }
        public System.DateTime 报名时间 { get; set; }
        public bool 是否失效 { get; set; }
        public int 用户Id { get; set; }
        public int 活动Id { get; set; }
        public string 姓名 { get; set; }
        public string 联系方式 { get; set; }
    
        public virtual 用户 用户 { get; set; }
        public virtual 活动 活动 { get; set; }
    }
}
