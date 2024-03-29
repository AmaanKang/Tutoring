﻿using System;
using System.Collections.Generic;

namespace Tutoring_Platform.Models
{
    /// <summary>
    /// TutorInfo holds the data of the tutors
    /// </summary>
    public partial class TutorInfo
    {
        public TutorInfo()
        {
            AppointRequests = new HashSet<AppointRequest>();
            DaysAvailables = new HashSet<DaysAvailable>();
            TutorCourses = new HashSet<TutorCourse>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public string? Status { get; set; }
        public float? Wage { get; set; }

        public virtual StudTutorInfo User { get; set; } = null!;
        public virtual ICollection<AppointRequest> AppointRequests { get; set; }
        public virtual ICollection<DaysAvailable> DaysAvailables { get; set; }
        public virtual ICollection<TutorCourse> TutorCourses { get; set; }
    }
}
