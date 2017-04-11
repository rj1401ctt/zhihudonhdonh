using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    [MetadataType(typeof(动态点赞记录Metadata))]
    public partial class 动态点赞记录
    {
        private class 动态点赞记录Metadata
        {

            [JsonIgnore]
            public virtual 动态 动态 { get; set; }

            [JsonIgnore]
            public virtual 用户 用户 { get; set; }
        }
    }
}
