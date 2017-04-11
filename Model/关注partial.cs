using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    [MetadataType(typeof(关注Metadata))]
    public partial class 关注
    {
        private class 关注Metadata
        {

            [JsonIgnore]
            public virtual 用户 用户 { get; set; }
        }
    }
}
