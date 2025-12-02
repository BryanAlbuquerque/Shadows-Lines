using System.ComponentModel.DataAnnotations;

public class EmailRequest
{
    [Required]
    public string Para { get; set; }

    [Required]
    public string Assunto { get; set; }

    [Required]
    public string Mensagem { get; set; }
}
