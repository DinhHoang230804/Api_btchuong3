﻿using System.ComponentModel.DataAnnotations;

namespace Btchuong3.Model.DTO
{
    public class ImageUploadRequestDTO
    {
        [Required]

        public IFormFile File { get; set; }
        [Required]

        public string FileName { get; set; }

        public string? FileDescription { get; set; }
    }
}
