﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebBanHang.Repository.Validation;

namespace WebBanHang.Models
{
    public class ProductModel
    {
        [Key]
        public int Id { get; set; }
        [Required,MinLength (4,ErrorMessage ="Yêu cầu nhập Tên Sản Phẩm")]
        public string Name { get; set; }

        public string Slug { get; set; }
        [Required,MinLength(4,ErrorMessage ="Yêu cầu nhập Mô tả Sản Phẩm")]
        public string Description { get; set; }
        [Required(ErrorMessage ="Yêu cầu nhập Giá Sản Phẩm")]
        [Range(0.01,double.MaxValue)]
        [Column(TypeName = "decimal(8,2)")]
        public decimal Price { get; set; }
        [Required,Range(1,int.MaxValue,ErrorMessage ="Chọn một thương hiệu")]
        public int BrandId { get; set; }
        [Required,Range(1,int.MaxValue,ErrorMessage ="Chọn một danh mục")]
        public int CategoryId { get; set; }
        public CategoryModel Category { get; set; }
        public BrandModel Brand { get; set; }
        public string Image { get; set; } = "noimage.jpg";

        [NotMapped]
        [FileExtension]
        public IFormFile ImageUpload { get; set; }
    }
}
