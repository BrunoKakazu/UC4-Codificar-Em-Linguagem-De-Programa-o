using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Ex3
{
	public Ex3()
	{
		
	}

	public void VerificaPar()
	{
		Console.Write("Digite um número: ");

		int numero;
		numero = int.Parse(Console.ReadLine());

		if (numero % 2 == 0)
			Console.WriteLine("É par");
	}
}
