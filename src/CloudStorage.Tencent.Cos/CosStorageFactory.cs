using CloudStorage.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudStorage.Tencent.Cos
{
    public class CosStorageFactory : StorageFactory
    {
        private CosObjectStorage _cosProxy;

        public void Dispose()
        {
            _cosProxy.Dispose();
        }

        public IMultipartStorage GetMultipartStorage()
        {
            return _cosProxy;
        }

        public IObjectStorage GetObjectStorage()
        {
            return _cosProxy;
        }
    }
}
