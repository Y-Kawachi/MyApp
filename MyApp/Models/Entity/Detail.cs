using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyApp.Models.Entity
{
    [Table("detail", Schema = "public")]
    public class Detail
    {
        [Key, ForeignKey("Header")]
        [DisplayName("ヘッダーID")]
        [Column("headerid", Order=1)]
        [Required]
        public int HeaderId { get; set; }

        [Key]
        [DisplayName("明細ID")]
        [Column("id", Order = 2)]
        [Required]
        public int Id { get; set; }

        [DisplayName("詳細")]
        [Column("description")]
        [MaxLength(50)]
        public string Description { get; set; }

        [DisplayName("備考")]
        [Column("caution")]
        [MaxLength(50)]
        public string Caution { get; set; }

        [DisplayName("作成日時")]
        [Column("createdat")]
        public DateTime? Createdat { get; set; }

        [DisplayName("更新日時")]
        [Column("updatedat")]
        public DateTime? Updatedat { get; set; }

        public virtual Header Header { get; set; }
    }
}
