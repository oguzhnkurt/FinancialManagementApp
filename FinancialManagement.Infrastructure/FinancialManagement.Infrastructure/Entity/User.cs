using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class User
{

    [Key] // Primary Key olarak belirleme
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Otomatik artan (Identity) özelliği
    public long Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime CreatedDate { get; set; }

}
