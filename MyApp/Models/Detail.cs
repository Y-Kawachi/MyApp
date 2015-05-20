using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyApp.Models
{
    [Table("detail", Schema = "public")]
    public class Details
    {
        [Key]
        [DisplayName("ヘッダーID")]
        [Column("id", Order=1)]
        [Required]
        public int Id { get; set; }

        [Key]
        [DisplayName("ID")]
        [Column("id", Order = 1)]
        [Required]
        [MaxLength(256)]
        public string Title { get; set; }

        [DisplayName("詳細")]
        [Column("description")]
        [MaxLength(2)]
        public string Description { get; set; }

        [DisplayName("備考")]
        [Column("caution")]
        public DateTime Caution { get; set; }

        [DisplayName("作成日時")]
        [Column("createdat")]
        public DateTime Createdat { get; set; }

        [DisplayName("更新日時")]
        [Column("updatedat")]
        public DateTime Updatedat { get; set; }

    }
}
