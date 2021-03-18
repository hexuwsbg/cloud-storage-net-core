using CloudStorage.Interfaces;
using CloudStorage.Model;
using System;
using Amazon.S3;

namespace CloudStorage.Amazon.S3
{
    public partial class S3Proxy : IDisposable, IObjectStorage
    {
        private AmazonS3Client _amazonS3Client;

        public CopyObjectResponse CopyObject(CopyObjectRequest request)
        {
            _amazonS3Client.getbucket
            throw new NotImplementedException();
        }

        public DeleteObjectResponse DeleteObject(DeleteObjectRequest request)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool DoesBucketExist(string bucket)
        {
            throw new NotImplementedException();
        }

        public bool DoesObjectExist(ObjectExistRequest request)
        {
            throw new NotImplementedException();
        }

        public GeneratePresignedGetUrlResponse GeneratePresignedGetUrl(GeneratePresignedGetUrlRequest request)
        {
            throw new NotImplementedException();
        }

        public GetObjectResponse GetObject(GetObjectRequest request)
        {
            throw new NotImplementedException();
        }

        public PutObjectResponse PutObject(PutObjectRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
