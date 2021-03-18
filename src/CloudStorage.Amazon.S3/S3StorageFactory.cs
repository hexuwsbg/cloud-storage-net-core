using CloudStorage.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudStorage.Amazon.S3
{
    public class S3StorageFactory : StorageFactory
    {
        private S3Proxy _s3Proxy;

        public void Dispose()
        {
            _s3Proxy.Dispose();
        }

        public IMultipartStorage GetMultipartStorage()
        {
            return _s3Proxy;
        }

        public IObjectStorage GetObjectStorage()
        {
            return _s3Proxy;
        }
    }
}
