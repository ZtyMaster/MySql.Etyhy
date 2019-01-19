

using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Abp.Linq;
using Abp.Linq.Extensions;
using Abp.Extensions;
using Abp.UI;
using Abp.Domain.Repositories;
using Abp.Domain.Services;

using MySql.ETyhy;
using MySql.ETyhy.ComPay.Bumen.ZhiWu;


namespace MySql.ETyhy.ComPay.Bumen.ZhiWu.DomainService
{
    /// <summary>
    /// Zhiws领域层的业务管理
    ///</summary>
    public class ZhiwsManager :ETyhyDomainServiceBase, IZhiwsManager
    {
		
		private readonly IRepository<Zhiws,int> _repository;

		/// <summary>
		/// Zhiws的构造方法
		///</summary>
		public ZhiwsManager(
			IRepository<Zhiws, int> repository
		)
		{
			_repository =  repository;
		}


		/// <summary>
		/// 初始化
		///</summary>
		public void InitZhiws()
		{
			throw new NotImplementedException();
		}

		// TODO:编写领域业务代码



		 
		  
		 

	}
}
