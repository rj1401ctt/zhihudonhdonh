using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    [MetadataType(typeof(活动评论Metadata))]
    public partial class 活动评论
    {
        private class 活动评论Metadata
        {
            [JsonIgnore]
            public virtual 活动 活动 { get; set; }
            [JsonIgnore]
            public virtual 用户 用户 { get; set; }


        }
    }
}
