using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloudStorage.Model
{
    public class BaseRequest
    {
        /// <summary>
        /// 桶
        /// 腾讯云的同名 后缀必须包含AppID 比如：taxware-all-prod-1300113315 最后面的一串数字其实是对应的AppID
        /// </summary>
        public string Bucket { get; set; }

        public string Key { get; set; }
    }
}
