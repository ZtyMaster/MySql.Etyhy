

using System;
using System.Threading.Tasks;
using Abp;
using Abp.Domain.Services;
using MySql.ETyhy.ComPay;


namespace MySql.ETyhy.ComPay.DomainService
{
    public interface IComasManager : IDomainService
    {

        /// <summary>
        /// 初始化方法
        ///</summary>
        void InitComas();



		 
      
         

    }
}
