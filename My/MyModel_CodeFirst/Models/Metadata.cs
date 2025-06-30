using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyModel_CodeFirst.Models;

public class BookData
{
    //屬性封裝
    [Display(Name = "編號")]
    [StringLength(36, MinimumLength = 36)]
    [Key]
    public string BookID { get; set; } = null!; //留言編號, 採用GUID


    [Display(Name = "主題")]
    [StringLength(30, MinimumLength = 2, ErrorMessage = "主題2~30個字")]
    [Required(ErrorMessage = "必填")]
    public string Title { get; set; } = null!;


    [Display(Name = "內容")]
    [Required(ErrorMessage = "必填")]
    [DataType(DataType.MultilineText)]
    public string Description { get; set; } = null!;


    [Display(Name = "發表人")]
    [StringLength(20, ErrorMessage = "最多20字")]
    [Required(ErrorMessage = "必填")]
    public string Author { get; set; } = null!;

    [Display(Name = "照片")]
    [StringLength(40)]
    public string? Photo { get; set; } = null!;  //照片的檔名規則:GUID+.jpg


    [Display(Name = "發布時間")]
    [DataType(DataType.DateTime)]
    [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm:ss}")]
    [HiddenInput]
    public DateTime CreatedDate { get; set; } = DateTime.Now;

}



public class ReBookData
{
    //屬性封裝
    [Display(Name = "編號")]
    [StringLength(36, MinimumLength = 36)]
    [Key]
    public string ReBookID { get; set; } = null!; //留言編號, 採用GUID

    [Display(Name = "回覆內容")]
    [Required(ErrorMessage = "必填")]
    [DataType(DataType.MultilineText)]
    public string Description { get; set; } = null!;

    [Display(Name = "回覆人")]
    [StringLength(10, ErrorMessage = "最多10字")]
    [Required(ErrorMessage = "必填")]
    public string Author { get; set; } = null!;

    [Display(Name = "回覆時間")]
    [DataType(DataType.DateTime)]
    [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd  hh:mm:ss}")]
    [HiddenInput]
    public DateTime CreatedDate { get; set; } = DateTime.Now;


    //1.1.5 撰寫兩個類別間的關聯屬性做為未來資料表之間的關聯

    //外來鍵屬性
    [ForeignKey("Book")]
    public string BookID { get; set; } = null!;

}


[ModelMetadataType(typeof(BookData))]
public partial class Book
{
}

[ModelMetadataType(typeof(ReBookData))]
public partial class ReBook
{
}