using CloudStorage.Interfaces;
using System;

namespace CloudStorage.Ali.Oss
{
    public class OssProxy : IObjectStorage, IMultipartStorage, IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
