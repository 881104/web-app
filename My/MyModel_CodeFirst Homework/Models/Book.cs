using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace MyModel_CodeFirst_Homework.Models
{
    
    public partial class Book
    {
       

        public string BookID { get; set; } = null!; 

        public string Title { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string Author { get; set; } = null!;

        public string? Photo { get; set; } = null!;  

        public DateTime CreatedDate { get; set; } = DateTime.Now;

       
        public virtual List<ReBook>? ReBooks { get; set; }

    }
}
