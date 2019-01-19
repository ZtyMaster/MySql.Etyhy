

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
using MySql.ETyhy.Bumen;


namespace MySql.ETyhy.Bumen.DomainService
{
    /// <summary>
    /// BuMens领域层的业务管理
    ///</summary>
    public class BuMensManager :ETyhyDomainServiceBase, IBuMensManager
    {
		
		private readonly IRepository<BuMens,int> _repository;

		/// <summary>
		/// BuMens的构造方法
		///</summary>
		public BuMensManager(
			IRepository<BuMens, int> repository
		)
		{
			_repository =  repository;
		}


		/// <summary>
		/// 初始化
		///</summary>
		public void InitBuMens()
		{
			throw new NotImplementedException();
		}

		// TODO:编写领域业务代码



		 
		  
		 

	}
}
