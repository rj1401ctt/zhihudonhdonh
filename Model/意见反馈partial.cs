
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    [MetadataType(typeof(意见反馈Metadata))]
    public partial class 意见反馈
    {
        private class 意见反馈Metadata
        {

            [JsonIgnore]
            public virtual 用户 用户 { get; set; }
        }
    }
}
