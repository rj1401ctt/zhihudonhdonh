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
    
    public partial class 意见反馈
    {
        public int Id { get; set; }
        public string 内容 { get; set; }
        public string 联系方式 { get; set; }
        public int 用户Id { get; set; }
    
        public virtual 用户 用户 { get; set; }
    }
}
