using System;
using System.Collections.Generic;
using System.Text;

namespace CloudStorage.Model
{
    public class CompleteMultipartUploadRequest : BaseRequest
    {
        public string UploadId { get; set; }

        public List<PartETag> PartETags { get; set; }
    }
}
