﻿using System.ComponentModel.DataAnnotations;

namespace Amazon.Ssm
{
    public class GetDocumentRequest : ISsmRequest
    {
        public string DocumentVersion { get; set; }

        [Required]
        public string Name { get; set; }
    }
}