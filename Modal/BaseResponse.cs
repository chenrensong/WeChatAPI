using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SS.WeChat.WebApi.Modal
{
    public class BaseResponse
    {
        /// <summary>
        /// 0成功
        /// </summary>
        public int Ret { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ErrMsg { get; set; }
    }
}
