

using System;
using System.Threading.Tasks;
using Abp;
using Abp.Domain.Services;
using MySql.ETyhy.Bumen;


namespace MySql.ETyhy.Bumen.DomainService
{
    public interface IBuMensManager : IDomainService
    {

        /// <summary>
        /// 初始化方法
        ///</summary>
        void InitBuMens();



		 
      
         

    }
}
