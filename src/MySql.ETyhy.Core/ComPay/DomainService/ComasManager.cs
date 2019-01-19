

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
using MySql.ETyhy.ComPay;


namespace MySql.ETyhy.ComPay.DomainService
{
    /// <summary>
    /// Comas领域层的业务管理
    ///</summary>
    public class ComasManager :ETyhyDomainServiceBase, IComasManager
    {
		
		private readonly IRepository<Comas,int> _repository;

		/// <summary>
		/// Comas的构造方法
		///</summary>
		public ComasManager(
			IRepository<Comas, int> repository
		)
		{
			_repository =  repository;
		}


		/// <summary>
		/// 初始化
		///</summary>
		public void InitComas()
		{
			throw new NotImplementedException();
		}

		// TODO:编写领域业务代码



		 
		  
		 

	}
}
