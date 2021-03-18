using System;
using System.Collections.Generic;
using System.Text;

namespace CloudStorage.Interfaces
{
    public interface StorageFactory : IDisposable
    {
        IObjectStorage GetObjectStorage();

        IMultipartStorage GetMultipartStorage();
    }
}
