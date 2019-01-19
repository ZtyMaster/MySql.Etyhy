
using Abp.Runtime.Validation;
using MySql.ETyhy.Dtos;
using MySql.ETyhy.ComPay.Bumen.ZhiWu;

namespace MySql.ETyhy.ComPay.Bumen.ZhiWu.Dtos
{
    public class GetZhiwssInput : PagedSortedAndFilteredInputDto, IShouldNormalize
    {

        /// <summary>
        /// 正常化排序使用
        /// </summary>
        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Id";
            }
        }

    }
}
