using Amazon.S3;
using CloudStorage.Interfaces;
using CloudStorage.Model;
using System;

namespace CloudStorage.Amazon.S3
{
    public partial class S3Proxy : IMultipartStorage
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
