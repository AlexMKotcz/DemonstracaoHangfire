namespace Trabalhador;

public static class ClasseTrabalhadora
{
	private static int TentativaAtual = 0;

	public static string TrabalhoDemorado()
	{
		Thread.Sleep(TimeSpan.FromMinutes(1));

		const string mensagem = "Trabalho demorado finalmente executou.";
		Console.WriteLine(mensagem);
		return mensagem;
	}

	public static string TrabalhoComErro()
	{
		throw new Exception("Este é o método com erro!");
	}

	public static string TrabalhoComDificuldades()
	{
		TentativaAtual++;

		if (TentativaAtual < 5 || TentativaAtual % 2 == 0)
			throw new Exception($"Esta tentativa ocasionou um erro. Tentativa número {TentativaAtual}");

		string mensagem = $"Método deu certo. Tentativa número {TentativaAtual}";
		Console.WriteLine(mensagem);
		return mensagem;
	}
}