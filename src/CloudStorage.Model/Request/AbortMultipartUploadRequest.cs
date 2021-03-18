using System;
using System.Collections.Generic;
using System.Text;

namespace CloudStorage.Model
{
    public class AbortMultipartUploadRequest : BaseRequest
    {
        public string UploadId { get; set; }
    }
}
