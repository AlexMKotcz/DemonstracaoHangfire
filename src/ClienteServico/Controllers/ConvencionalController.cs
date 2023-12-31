using Microsoft.AspNetCore.Mvc;
using Trabalhador;

namespace ClienteServico.Controllers;

[ApiController]
[Route("[controller]")]
public class ConvencionalController : ControllerBase
{
	[HttpPost("TrabalhoDemorado")]
	public string TrabalhoDemorado()
	{
		return ClasseTrabalhadora.TrabalhoDemorado();
	}

	[HttpPost("TrabalhoComErro")]
	public string TrabalhoComErro()
	{
		return ClasseTrabalhadora.TrabalhoComErro();
	}

	[HttpPost("TrabalhoComDificuldades")]
	public string TrabalhoComDificuldades()
	{
		return ClasseTrabalhadora.TrabalhoComDificuldades();
	}
}
