

namespace MySql.ETyhy.Bumen.Authorization
{
	/// <summary>
    /// 定义系统的权限名称的字符串常量。
    /// <see cref="BuMensAuthorizationProvider" />中对权限的定义.
    ///</summary>
	public static  class BuMensPermissions
	{
		/// <summary>
		/// BuMens权限节点
		///</summary>
		public const string Node = "Pages.BuMens";

		/// <summary>
		/// BuMens查询授权
		///</summary>
		public const string Query = "Pages.BuMens.Query";

		/// <summary>
		/// BuMens创建权限
		///</summary>
		public const string Create = "Pages.BuMens.Create";

		/// <summary>
		/// BuMens修改权限
		///</summary>
		public const string Edit = "Pages.BuMens.Edit";

		/// <summary>
		/// BuMens删除权限
		///</summary>
		public const string Delete = "Pages.BuMens.Delete";

        /// <summary>
		/// BuMens批量删除权限
		///</summary>
		public const string BatchDelete = "Pages.BuMens.BatchDelete";

		/// <summary>
		/// BuMens导出Excel
		///</summary>
		public const string ExportExcel="Pages.BuMens.ExportExcel";

		 
		 
         
    }

}

