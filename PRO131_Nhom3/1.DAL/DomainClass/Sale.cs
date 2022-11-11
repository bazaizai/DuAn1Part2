﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1.DAL.DomainClass
{
    [Table("Sale")]
    [Index(nameof(Ma), Name = "UQ__Sale__3214CC9E66B80470", IsUnique = true)]
    public partial class Sale
    {
        public Sale()
        {
            ChiTietSales = new HashSet<ChiTietSale>();
        }

        [Key]
        public Guid Id { get; set; }
        [StringLength(20)]
        public string Ma { get; set; }
        [StringLength(30)]
        public string Ten { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgayBatDau { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgayKetThuc { get; set; }
        [Column("LoaiHinhKM")]
        [StringLength(30)]
        public string LoaiHinhKm { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? MucGiam { get; set; }
        [StringLength(50)]
        public string MoTa { get; set; }
        public int? TrangThai { get; set; }

        [InverseProperty(nameof(ChiTietSale.IdSaleNavigation))]
        public virtual ICollection<ChiTietSale> ChiTietSales { get; set; }
    }
}
