using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloudStorage.Model
{
    public class CopyObjectRequest : BaseRequest
    {
        public string SourceBucket { get; set; }

        public string SourceKey { get; set; }
    }
}
