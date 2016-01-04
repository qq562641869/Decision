﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Decision.DomainClasses.Entities.Common;
using Decision.DomainClasses.Entities.TeacherInfo;
using Decision.ViewModel.Common;

namespace Decision.ViewModel.Appraiser
{
    /// <summary>
    /// ویومدل ویرایش ارزیاب - ارزیاب، مصاحبه کننده و غیره
    /// </summary>
    public class EditAppraiserViewModel : BaseRowVersion
    {
        #region Properties
        /// <summary>
        /// آی دی ارزیاب
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// نام ارزیاب
        /// </summary>
        [Required(ErrorMessage = "لطفا نام  را وارد کنید")]
        [StringLength(256, MinimumLength = 3, ErrorMessage = "نام باید بین سه تا ۲۵۶ کاراکتر باشد")]
        [DisplayName("نام")]
        [RegularExpression(@"^[\u0600-\u06FF,\u0590-\u05FF,۰-۹\s]*$", ErrorMessage = "لطفا فقط ازاعداد و حروف  فارسی برای نام استاد استفاده کنید")]
        public string FirstName { get; set; }
        /// <summary>
        /// نام خانوادگی ارزیاب
        /// </summary>
        [Required(ErrorMessage = "لطفا نام خانوادگی را وارد کنید")]
        [StringLength(256, MinimumLength = 3, ErrorMessage = "نام خانوادگی باید بین سه تا ۲۵۶ کاراکتر باشد")]
        [DisplayName("نام خانوادگی")]
        [RegularExpression(@"^[\u0600-\u06FF,\u0590-\u05FF,۰-۹\s]*$", ErrorMessage = "لطفا فقط ازاعداد و حروف  فارسی برای نام استاد استفاده کنید")]
        public string LastName { get; set; }
        /// <summary>
        /// شماره همراه ارزیاب
        /// </summary>
        [Required(ErrorMessage = "لطفا شماره همراه را وارد کنید")]
       
        [DisplayName("شماره همراه")]
        public string CellPhone { get; set; }

        /// <summary>
        /// جنسیت ارزیاب
        /// </summary>
        [DisplayName("جنسیت")]
        public GenderType Gender { get; set; }

        /// <summary>
        /// آی دی عنوان  ارزیاب  
        /// مهندس/دکتر/...
        /// </summary>
        [Required(ErrorMessage = "لطفا عنوان را انتخاب کنید")]
        [DisplayName("عنوان")]
        public Guid AppraiserTitleId { get; set; }
        #endregion

        #region SelectListItems
        /// <summary>
        /// لیست عنوان های ارزیاب برای لیست آبشاری در ویو
        /// </summary>
        public IEnumerable<SelectListItem> AppraiserTitles { get; set; }
        #endregion
    }
}