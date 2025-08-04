using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace MyModel_CodeFirst_Homework.Models
{

    public partial class ReBook
    {
       
        public string ReBookID { get; set; } = null!; 

        public string Description { get; set; } = null!;

        public string Author { get; set; } = null!;

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        
        public string BookID { get; set; } = null!;

        public virtual Book? Book { get; set; } 
    }
}
