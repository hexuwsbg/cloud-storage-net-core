using CloudStorage.Interfaces;
using CloudStorage.Model;
using System;

namespace CloudStorage.Tencent.Cos
{
    public partial class CosProxy : IObjectStorage, IDisposable
    {
        public CopyObjectResponse CopyObject(CopyObjectRequest request)
        {
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
