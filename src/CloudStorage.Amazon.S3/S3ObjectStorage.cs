using CloudStorage.Interfaces;
using CloudStorage.Model;
using System;
using Amazon.S3;
using System.Threading.Tasks;
using System.Threading;

namespace CloudStorage.AmazonS3
{
    public partial class S3Proxy : IDisposable, IObjectStorage
    {
        private AmazonS3Client _amazonS3Client;

        public CopyObjectResponse CopyObject(CopyObjectRequest request)
        {
            var s3CopyObjectRequest = new Amazon.S3.Model.CopyObjectRequest()
            {
                SourceBucket = request.SourceBucket,
                SourceKey = request.SourceKey,
                DestinationBucket = request.Bucket,
                DestinationKey = request.Key,
            };


            var result = _amazonS3Client.CopyObjectAsync(s3CopyObjectRequest).Result;

            return null;
        }

        public DeleteObjectResponse DeleteObject(DeleteObjectRequest request)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
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
