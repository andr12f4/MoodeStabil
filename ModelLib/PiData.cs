﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace ModelLib
{
    public partial class PiData
    {
        public int Id { get; set; }
        public DateTime? DateFromSubject { get; set; }
        public DateTime? Date { get; set; }
        public int? SubjectId { get; set; }

        public virtual Subjects Subject { get; set; }
    }
}