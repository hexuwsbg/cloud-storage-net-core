using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CloudStorage.Model
{
    public class PutObjectRequest : BaseRequest
    {
        /// <summary>
        /// 上传文件全路径
        /// </summary>
        public string FilePath { get; set; }
    }
}
