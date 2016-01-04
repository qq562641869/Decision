﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Decision.ViewModel.TrainingCourse
{
    public class AddTrainingCourseViewModel
    {
        #region Ctor

        public AddTrainingCourseViewModel()
        {
            TheoryTotalHoures = 200;
            PracticalTotalHoures = 200;
            BeginDate = DateTime.Now;
            EndDate = DateTime.Now.AddMonths(1);
        }
        #endregion

        #region Properties
        /// <summary>
        /// کدی برای شناسایی دوره
        /// </summary>
        [Required(ErrorMessage = "لطفا کد دوره را وارد کنید")]
        [DisplayName("کد دوره")]
        [StringLength(256, ErrorMessage = "کد دوره باید حداکثر ۲۵۶ کاراکتر باشد")]
        public string CourseCode { get; set; }

        /// <summary>
        /// تاریخ آغاز دوره
        /// </summary>
        [DisplayName("تاریخ شروع")]
        public DateTime BeginDate { get; set; }

        /// <summary>
        /// تاریخ پایان دوره
        /// </summary>
        [DisplayName("تاریخ پایان")]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// مجموع ساعت آموزشی نظری
        /// </summary>
        [DisplayName("مدت آموزش نظری")]
        [Required(ErrorMessage = "لطفا مدت آموزش نظری را  مشخص کنید")]
        public int TheoryTotalHoures { get; set; }

        /// <summary>
        /// مجموع ساعت آموزشی عملی
        /// </summary>
        [DisplayName("مدت آموزش عملی")]
        [Required(ErrorMessage = "لطفا مدت آموزش عملی را  مشخص کنید")]
        public int PracticalTotalHoures { get; set; }

        /// <summary>
        /// آی دی مرکز کار آموزی
        /// </summary>
        [DisplayName("مرکز کارآموزی")]
        [Required(ErrorMessage = "لطفا مرکز کارآموزی مربوطه را انتخاب کنید")]
        public Guid TrainingCenterId { get; set; }
        #endregion
    }
}