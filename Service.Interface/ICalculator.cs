using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Service.Interface
{
    /// <summary>
    /// 计算器
    /// </summary>
    [ServiceContract(Name = "CalculatorService",Namespace="http://www.artech.com/")]
    public interface ICalculator
    {
        /// <summary>
        /// 加
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        [OperationContract]
        double Add(double x,double y);

        /// <summary>
        /// 减
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        [OperationContract]
        double Subtract(double x,double y);

        /// <summary>
        /// 乘
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        [OperationContract]
        double Multiply(double x,double y);

        /// <summary>
        /// 除
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        [OperationContract]
        double Divide(double x,double y);
    }
}
