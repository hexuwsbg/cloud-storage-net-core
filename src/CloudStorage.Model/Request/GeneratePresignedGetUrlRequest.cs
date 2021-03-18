using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloudStorage.Model
{
    public class GeneratePresignedGetUrlRequest : BaseRequest
    {
        public int ExpireHours { get; set; }

        public DateTime GetExpiredAt()
        {
            return DateTime.Now.AddHours(ExpireHours);
        }
    }
}
