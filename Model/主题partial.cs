using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    [MetadataType(typeof(主题Metadata))]
    public partial class 主题
    {
        private class 主题Metadata
        {

            [JsonIgnore]
            public virtual 主题 主题 { get; set; }
        }
    }
}
