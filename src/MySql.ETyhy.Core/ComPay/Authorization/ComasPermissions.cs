

namespace MySql.ETyhy.ComPay.Authorization
{
	/// <summary>
    /// 定义系统的权限名称的字符串常量。
    /// <see cref="ComasAuthorizationProvider" />中对权限的定义.
    ///</summary>
	public static  class ComasPermissions
	{
		/// <summary>
		/// Comas权限节点
		///</summary>
		public const string Node = "Pages.Comas";

		/// <summary>
		/// Comas查询授权
		///</summary>
		public const string Query = "Pages.Comas.Query";

		/// <summary>
		/// Comas创建权限
		///</summary>
		public const string Create = "Pages.Comas.Create";

		/// <summary>
		/// Comas修改权限
		///</summary>
		public const string Edit = "Pages.Comas.Edit";

		/// <summary>
		/// Comas删除权限
		///</summary>
		public const string Delete = "Pages.Comas.Delete";

        /// <summary>
		/// Comas批量删除权限
		///</summary>
		public const string BatchDelete = "Pages.Comas.BatchDelete";

		/// <summary>
		/// Comas导出Excel
		///</summary>
		public const string ExportExcel="Pages.Comas.ExportExcel";

		 
		 
         
    }

}

