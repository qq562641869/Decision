﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decision.DomainClasses.Entities.TeacherInfo;

namespace Decision.DomainClasses.Configurations.TeacherInfo
{
    /// <summary>
    /// نشان دهنده مپینگ مربوط به کلاس سوابق تحصیلی استاد
    /// </summary>
    public class EducationalBackgroundConfig : EntityTypeConfiguration<EducationalBackground>
   {
        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public EducationalBackgroundConfig()
        {

            Property(e => e.Description).IsMaxLength().IsOptional();
            Property(e => e.Supervisor).HasMaxLength(50).IsOptional();
            Property(e => e.Advisor).HasMaxLength(50).IsOptional();
            Property(e => e.ThesisTopic).IsMaxLength().IsRequired();
            Property(e => e.RowVersion).IsRowVersion();
            Property(e => e.GPA).IsRequired().HasPrecision(7, 2);
            Property(e => e.ThesisScore).IsRequired().HasPrecision(7, 2);

            HasRequired(e => e.Institution)
                .WithMany(i => i.EducationalBackgrounds)
                .HasForeignKey(e => e.InstitutionId)
                .WillCascadeOnDelete(false);

            HasRequired(e => e.StudyField)
              .WithMany(i => i.EducationalBackgrounds)
              .HasForeignKey(e => e.StudyFieldId)
              .WillCascadeOnDelete(false);
            
            HasRequired(e => e.Creator).WithMany(u => u.CreatedEducationalBackgrounds).HasForeignKey(e => e.CreatorId).WillCascadeOnDelete(false);
            HasOptional(e => e.LasModifier).WithMany(u => u.ModifiedEducationalBackgrounds).HasForeignKey(e => e.LasModifierId).WillCascadeOnDelete(false);
        }
    }
}
