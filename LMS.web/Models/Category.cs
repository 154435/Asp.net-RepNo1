using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.web.Models
{
    [Table(name: "Categories")]
    public class Category
    {
       
        [Key]                                                       // Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]       // Identity Column
        [Display(Name = "Category ID")]                             // Label on the UI
        public int CategoryId { get; set; }

     
        [Required(ErrorMessage = "{0} cannot be empty!")]
        [Column(TypeName ="varchar(50)")]
        [StringLength(50)]
        [Display(Name = "Name of the Category")]
        public string CategoryName { get; set; }

        #region Navigation Properties to the Book Model

        public ICollection<Book> Books { get; set; }


        #endregion
    }
    /**************
    *      CREATE TABLE [Categories]
    *      (
    *          [CategoryId] int NOT NULL IDENTITY (1,1)
    *          , [CategoryName] varchar(50) NOT NULL
    *          
    *          , CONSTRAINT [PK_Categories] PRIMARY KEY ( [CategoryId] ASC )
    *      )
    *****/
}


/****************
 * CREATE TABLE [Categories]
 * (
 *      []
 */
