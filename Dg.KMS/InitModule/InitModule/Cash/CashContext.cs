using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InitModule.Cash
{

	/// <summary>
	/// 设计模式之策略模式与工厂模式的结合
	/// https://blog.csdn.net/zxz19941122/article/details/82885589
	/// </summary>
	public class CashContext
	{
		BaseCash cs;
		public CashContext(String type)
		{
			switch (type)
			{
				case "normal":
					cs = new CashNormal();
					break;
				case "rebate":
					cs = new CashRebate(Convert.ToDecimal(0.8));
					break;
			}
		}
		//getResult(money)
		//{
		//	return cs.calculate();
		//}



		//————————————————
		//版权声明：本文为CSDN博主「zxz19941122」的原创文章，遵循 CC 4.0 BY-SA 版权协议，转载请附上原文出处链接及本声明。
		//原文链接：https://blog.csdn.net/zxz19941122/article/details/82885589
	}

}
