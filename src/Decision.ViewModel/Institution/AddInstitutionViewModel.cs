﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Decision.ViewModel.Institution
{
    /// <summary>
    /// ویومدل درج موسسه آموزشی
    /// </summary>
    public class AddInstitutionViewModel
    {
        #region Properties
        /// <summary>
        /// نام موسسه
        /// </summary>
        [Required(ErrorMessage = "لطفا نام موسسه را وارد کنید")]
        [StringLength(256, MinimumLength = 2, ErrorMessage = "نام موسسه باید بین دو تا ۲۵۶ کاراکتر باشد")]
        [DisplayName("نام")]
        
        public  string Name { get; set; }
        /// <summary>
        /// توضیحاتی در مورد موسسه
        /// </summary>
        [Required(ErrorMessage = "لطفا توضیحات موسسه را وارد کنید")]
        [StringLength(1024, MinimumLength = 2, ErrorMessage = "نام موسسه باید بین دو تا ۱۰۲۴ کاراکتر باشد")]
        [DisplayName("توضیحات")]
        public  string Description { get; set; }
        #endregion
    }
}