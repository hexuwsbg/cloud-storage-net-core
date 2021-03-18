using CloudStorage.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudStorage.Ali.Oss
{
    public class OssStorageFactory : StorageFactory
    {
        private OssProxy _ossProxy;
        public OssStorageFactory()
        {
        }

        public void Dispose()
        {
            _ossProxy.Dispose();
        }

        public IMultipartStorage GetMultipartStorage()
        {
            return _ossProxy;
        }

        public IObjectStorage GetObjectStorage()
        {
            return _ossProxy;
        }
    }
}
