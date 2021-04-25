﻿using Sbran.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sbran.Domain.Models
{
    public sealed class VoteDto
    {
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public List<VoteListDto>? voteLists { get; set; }
    }
}
