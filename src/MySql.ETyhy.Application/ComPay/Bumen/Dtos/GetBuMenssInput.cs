
using Abp.Runtime.Validation;
using MySql.ETyhy.Dtos;
using MySql.ETyhy.Bumen;

namespace MySql.ETyhy.Bumen.Dtos
{
    public class GetBuMenssInput : PagedSortedAndFilteredInputDto, IShouldNormalize
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
