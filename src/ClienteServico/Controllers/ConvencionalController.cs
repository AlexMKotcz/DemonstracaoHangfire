using Microsoft.AspNetCore.Mvc;
using Trabalhador;

namespace ClienteServico.Controllers;

[ApiController]
[Route("[controller]")]
public class ConvencionalController : ControllerBase
{
	[HttpPost("TrabalhoDemorado")]
	public void TrabalhoDemorado()
	{
		ClasseTrabalhadora.TrabalhoDemorado();
	}

	[HttpPost("TrabalhoComErro")]
	public void TrabalhoComErro()
	{
		ClasseTrabalhadora.TrabalhoComErro();
	}

	[HttpPost("TrabalhoComDificuldades")]
	public void TrabalhoComDificuldades()
	{
		ClasseTrabalhadora.TrabalhoComDificuldades();
	}
}
