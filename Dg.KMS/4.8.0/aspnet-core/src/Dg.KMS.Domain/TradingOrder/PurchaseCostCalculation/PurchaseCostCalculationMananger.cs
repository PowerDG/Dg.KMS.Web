using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Research.TradingOrder.PurchaseCostCalculation
{

    public class PurchaseCostCalculationMananger
    {
    
        public OrderInfoCostOutput CalculatingPurchaseCost(OrderBasePriceWithProductsRequest input)
        {

            var CurrentTime = DateTime.Now;
            Dictionary<int, decimal> CostPriceDict = new Dictionary<int, decimal>();
            //获取原单信息

            //核算Products数量


            var purchaseInput = ProductsMapper(input);
            try
            {
                var result = GetBasePrice(purchaseInput);

                foreach (var item in result.Products)
                {
                    CostPriceDict.Add(item.POId, item.BaseCostPrice);
                }

                #region 计算总和
                //遍历OrderList   计总成本底价

                //更新BaseCost到

                #endregion

                return result;
            }
            catch (Exception ex)
            {
                var exception = new Exception("获取采购接口获取底价失败", ex);
                //logger.Log(Level.Error, exception, "Error in UpdateDelivaryRecord");
                throw exception;
            }
           
        }

        /// <summary>
        /// 实际调用采购  提供的接口
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public OrderInfoCostOutput GetBasePrice(OrderBriefInfoWithProductsInput input)
        {
             //new OrderBriefInfoWithProductsOutput();
            return new OrderInfoCostOutput();
        }

        /// <summary>
        /// 仓库的Input到采购获取底价接口Input映射Map
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public OrderBriefInfoWithProductsInput ProductsMapper(OrderBasePriceWithProductsRequest input)
        {
            var products = input.Products;
            var briefProducts=products.Select(x=>x.POId).ToList();
            //var briefProducts = AutoMapper.Mapper.Map<List<PurchaseBriefProductItem>>(products);

            return new OrderBriefInfoWithProductsInput()
            { 
                Products = briefProducts
            };
        }


    }



    public  interface PurchaseCostCalculation
    {
        OrderInfoCostOutput CalculatingPurchaseCost(OrderBriefInfoWithProductsInput input);


    }
}
