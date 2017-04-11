using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    [MetadataType(typeof(动态附件Metadata))]
    public partial class 动态附件
    {
        private class 动态附件Metadata
        {

            [JsonIgnore]
            public virtual 动态 动态 { get; set; }
        }
    }
}
