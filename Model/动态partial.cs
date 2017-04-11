using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    [MetadataType(typeof(动态Metadata))]
    public partial class 动态
    {
        private class 动态Metadata
        {

            [JsonIgnore]
            public virtual 用户 用户 { get; set; }
            [JsonIgnore]
            public virtual ICollection<动态点赞记录> 动态点赞记录 { get; set; }
            [JsonIgnore]
            public virtual ICollection<动态附件> 动态附件 { get; set; }
        }
    }
}
