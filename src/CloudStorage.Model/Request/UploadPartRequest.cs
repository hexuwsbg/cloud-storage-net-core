using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CloudStorage.Model
{
    public class UploadPartRequest : BaseRequest
    {
        public string UploadId { get; set; }

        public Stream InputStream { get; set; }

        public long PartSize { get; set; }

        public int PartNumber { get; set; }

        public bool IsLastPart { get; set; }
    }
}
