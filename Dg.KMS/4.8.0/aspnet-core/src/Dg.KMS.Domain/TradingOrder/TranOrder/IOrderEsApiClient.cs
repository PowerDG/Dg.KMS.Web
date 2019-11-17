using Research.TradingOrder.TranOrder.Input;
using Research.TradingOrder.TranOrder.Output;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Research.TradingOrder.TranOrder
{
    //
    // 摘要:
    //     订单ES查询
    public interface IOrderEsApiClient :IDisposable//, ITuhuServiceClient, IHttpApi
    {
        //
        // 摘要:
        //     订单列表
        //
        // 参数:
        //   request:
        //
        //   cancellationToken:
        //[HttpPost("/v1/order/query/template")]

        Task<JavaResponse<OrderListByEsResponse>> QueryOrderListByEsAsync(OrderListByEsRequest request);
        //Task<JavaResponse<OrderListByEsResponse>> QueryOrderListByEsAsync([JsonContent] OrderListByEsRequest request, CancellationToken cancellationToken = default);

    } 
}
