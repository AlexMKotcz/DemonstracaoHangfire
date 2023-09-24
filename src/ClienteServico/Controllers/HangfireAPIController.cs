using Hangfire;
using Microsoft.AspNetCore.Mvc;
using Trabalhador;

namespace ClienteServico.Controllers;

[ApiController]
[Route("[controller]")]
public class HangfireAPIController : ControllerBase
{
	[HttpPost("TrabalhoDemorado")]
	public string TrabalhoDemorado()
	{
		return BackgroundJob.Enqueue("filademorada", () => ClasseTrabalhadora.TrabalhoDemorado());
	}

	[HttpPost("TrabalhoComErro")]
	public string TrabalhoComErro()
	{
		return BackgroundJob.Enqueue("filadeerros", () => ClasseTrabalhadora.TrabalhoComErro());		
	}

	[HttpPost("TrabalhoComDificuldades")]
	public string TrabalhoComDificuldades()
	{
		return BackgroundJob.Enqueue("filacomdificuldades", () => ClasseTrabalhadora.TrabalhoComDificuldades());
	}
}
