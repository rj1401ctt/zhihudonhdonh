using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    [MetadataType(typeof(相册Metadata))]
    public partial class 相册
    {
        private class 相册Metadata
        {

            [JsonIgnore]
            public virtual 用户 用户 { get; set; }
        }
    }
}
