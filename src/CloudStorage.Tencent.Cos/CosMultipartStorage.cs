using CloudStorage.Interfaces;
using CloudStorage.Model;
using System;

namespace CloudStorage.Tencent.Cos
{
    public partial class CosProxy : IMultipartStorage
    {

        public AbortMultipartUploadResponse AbortMultipartUpload(AbortMultipartUploadRequest request)
        {
            throw new NotImplementedException();
        }

        public CompleteMultipartUploadResponse CompleteMultipartUpload(CompleteMultipartUploadRequest request)
        {
            throw new NotImplementedException();
        }

        public InitiateMultipartUploadResponse InitiateMultipartUpload(InitiateMultipartUploadRequest request)
        {
            throw new NotImplementedException();
        }

        public UploadPartResponse UploadPart(UploadPartRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
