using Hangfire;
using Microsoft.AspNetCore.Mvc;
using Trabalhador;

namespace ClienteServico.Controllers;

[ApiController]
[Route("[controller]")]
public class HangfireController : ControllerBase
{
	[HttpPost("TrabalhoDemorado")]
	public void TrabalhoDemorado()
	{
		BackgroundJob.Enqueue("filademorada", () => ClasseTrabalhadora.TrabalhoDemorado());
	}

	[HttpPost("TrabalhoComErro")]
	public void TrabalhoComErro()
	{
		BackgroundJob.Enqueue("filadeerros", () => ClasseTrabalhadora.TrabalhoComErro());		
	}

	[HttpPost("TrabalhoComDificuldades")]
	public void TrabalhoComDificuldades()
	{
		BackgroundJob.Enqueue("filacomdificuldades", () => ClasseTrabalhadora.TrabalhoComDificuldades());
	}
}
