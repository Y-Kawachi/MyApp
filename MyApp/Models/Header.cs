using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyApp.Models
{
    [Table("main", Schema = "public")]
    public class Header
    {
        [Key]
        [DisplayName("ID")]
        [Column("id")]
        [Required]
        public int Id { get; set; }

        [DisplayName("タイトル")]
        [Column("title")]
        [MaxLength(256)]
        public string Title { get; set; }

        [DisplayName("何らかの区分")]
        [Column("appdiv")]
        [MaxLength(2)]
        public string Appdiv { get; set; }

        [DisplayName("作成日時")]
        [Column("createdat")]
        public DateTime Createdat { get; set; }

        [DisplayName("更新日時")]
        [Column("updatedat")]
        public DateTime Updatedat { get; set; }

    }
}
