
using Abp.Runtime.Validation;
using MySql.ETyhy.Dtos;
using MySql.ETyhy.ComPay;

namespace MySql.ETyhy.ComPay.Dtos
{
    public class GetComassInput : PagedSortedAndFilteredInputDto, IShouldNormalize
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
