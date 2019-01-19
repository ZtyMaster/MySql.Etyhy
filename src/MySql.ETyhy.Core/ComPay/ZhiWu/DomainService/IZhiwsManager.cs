

using System;
using System.Threading.Tasks;
using Abp;
using Abp.Domain.Services;
using MySql.ETyhy.ComPay.Bumen.ZhiWu;


namespace MySql.ETyhy.ComPay.Bumen.ZhiWu.DomainService
{
    public interface IZhiwsManager : IDomainService
    {

        /// <summary>
        /// 初始化方法
        ///</summary>
        void InitZhiws();



		 
      
         

    }
}
