using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    [MetadataType(typeof(精选活动Metadata))]
    public partial class 精选活动
    {
        private class 精选活动Metadata
        {
            [JsonIgnore]
            public virtual 活动 活动 { get; set; }

        }
    }
}
