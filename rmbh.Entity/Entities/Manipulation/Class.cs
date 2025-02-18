﻿using rmbh.Entity.Enums;
using rmbh.Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rmbh.Entity.Entities.Manipulation
{
    public class Class : BaseEntity<int>, IHasDateTracking, IHasPersonTracking
    {
        // Basic infomation
        public byte[]? Logo { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        // About
        public string? HeadlineAbout { get; set; }
        public string? DescriptionAbout { get; set; }
        public ClassVisibility Visibility { get; set; }
        public DefaultStudyMixType DefaultStudyMixType { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid CreatedUserId { get; set; }
        public Guid ModifiedUserId { get; set; }

        public ICollection<Deck>? Decks { get; set; }
        public ICollection<UserClass>? UserClasses { get; set; }
        public ICollection<TeamClass>? TeamClasses { get; set; }
    }
}
