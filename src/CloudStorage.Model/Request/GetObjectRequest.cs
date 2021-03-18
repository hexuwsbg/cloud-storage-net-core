using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloudStorage.Model
{
    public class GetObjectRequest : BaseRequest
    {
        /// <summary>
        /// 本地文件夹名
        /// </summary>
        public string DirectoryName { get; set; }

        /// <summary>
        /// 存储文件名
        /// </summary>
        public string FileName { get; set; }
    }
}
