﻿using System;

namespace DotNetRu.MeetupManagement.Application.Contract.Models
{
    public class VenueDraft
    {
        public VenueDraft(string id)
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));
        }

        public string Id { get; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string MapUrl { get; set; }
    }
}
