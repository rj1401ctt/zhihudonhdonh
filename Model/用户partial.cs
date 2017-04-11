using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    [MetadataType(typeof(用户Metadata))]
    public partial class 用户
    {
        private class 用户Metadata
        {
            [JsonIgnore]
            public virtual 用户 好友 { get; set; }
            [JsonIgnore]
            public virtual ICollection<活动> 活动 { get; set; }
            [JsonIgnore]
            public virtual ICollection<活动评论> 活动评论 { get; set; }
            [JsonIgnore]
            public virtual ICollection<报名记录> 报名记录 { get; set; }
            [JsonIgnore]
            public virtual ICollection<喜欢记录> 喜欢记录 { get; set; }
            [JsonIgnore]
            public virtual ICollection<相册> 相册 { get; set; }
            [JsonIgnore]
            public virtual ICollection<动态> 动态 { get; set; }
            [JsonIgnore]
            public virtual ICollection<动态点赞记录> 动态点赞记录 { get; set; }
            [JsonIgnore]
            public virtual ICollection<意见反馈> 意见反馈 { get; set; }
            [JsonIgnore]
            public virtual ICollection<动态评论> 动态评论 { get; set; }
        }
    }
}
