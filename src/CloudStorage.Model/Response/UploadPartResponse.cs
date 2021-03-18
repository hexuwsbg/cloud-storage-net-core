using System;
using System.Collections.Generic;
using System.Text;

namespace CloudStorage.Model
{
    public class UploadPartResponse
    {
        public PartETag PartETag;
    }

    public class PartETag
    {
        public string ETag { get; set; }

        public int PartNumber { get; set; }

        public long PartSize { get; set; }

        public PartETag(string eTag, int partNumber, long partSize)
        {
            ETag = eTag;
            PartNumber = partNumber;
            PartSize = partSize;
        }
    }
}
