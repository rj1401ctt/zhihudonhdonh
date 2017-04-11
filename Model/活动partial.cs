using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    [MetadataType(typeof(活动Metadata))]
    public partial class 活动
    {
        private class 活动Metadata
        {
            [JsonIgnore]
            public virtual 用户 用户 { get; set; }
            [JsonIgnore]
            public virtual ICollection<主题> 主题 { get; set; }
            [JsonIgnore]
            public virtual ICollection<精选活动> 精选活动 { get; set; }
         
            [JsonIgnore]
            public virtual ICollection<活动评论> 活动评论 { get; set; }
            [JsonIgnore]
            public virtual ICollection<报名记录> 报名记录 { get; set; }
            [JsonIgnore]
            public virtual ICollection<喜欢记录> 喜欢记录 { get; set; }
        }
    }
}
