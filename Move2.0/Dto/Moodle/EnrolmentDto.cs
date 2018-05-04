using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Move2._0.Dto.Moodle
{
    public class EnrolmentDto
    {
        public int RoleId { get; set; }
        public int UserId { get; set; }
        public int CourseId { get; set; }
        public int StartingDate { get; set; }
        public int EndDate { get; set; }
    }
}