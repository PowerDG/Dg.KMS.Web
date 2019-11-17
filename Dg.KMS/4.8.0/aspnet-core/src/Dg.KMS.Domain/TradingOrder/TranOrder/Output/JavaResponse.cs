using System;
using System.Collections.Generic;
using System.Text;

namespace Research.TradingOrder.TranOrder.Output
{
    //
    // 摘要:
    //     支持{ "code": int, "message": string, "data": T }类型
    public class JavaResponse<T>
    {
        public JavaResponse() { }

        public int Code { get; set; } 
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }
}

