using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class EmailController : ControllerBase
{
    private readonly EmailService _emailService;

    public EmailController(EmailService emailService)
    {
        _emailService = emailService;
    }

    [HttpPost("enviar")]
    public async Task<IActionResult> EnviarEmail([FromBody] EmailRequest request)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        try
        {
            await _emailService.EnviarEmailAsync(request);
            return Ok(new { message = "E-mail enviado com sucesso!" });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new
            {
                message = "Erro ao enviar e-mail.",
                error = ex.Message
            });
        }
    }
}
