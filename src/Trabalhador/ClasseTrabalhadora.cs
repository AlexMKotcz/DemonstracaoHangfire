namespace Trabalhador;

public static class ClasseTrabalhadora
{
	private static int TentativaAtual = 0;

	public static void TrabalhoDemorado()
	{
		Thread.Sleep(TimeSpan.FromMinutes(1));
		Console.WriteLine("Trabalho demorado finalmente executou.");
	}

	public static void TrabalhoComErro()
	{
		throw new Exception("Este é o método com erro!");
	}

	public static void TrabalhoComDificuldades()
	{
		TentativaAtual++;

		if (TentativaAtual < 5 || TentativaAtual % 2 == 0)
			throw new Exception($"Esta tentativa ocasionou um erro. Tentativa número {TentativaAtual}");

		Console.WriteLine("Método com sucesso.");
	}
}