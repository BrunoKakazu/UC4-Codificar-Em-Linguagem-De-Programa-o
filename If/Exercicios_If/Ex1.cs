using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Ex1
{
	public Ex1()
	{
		
	}

	public void LerNumeroInteiro()
	{
		Console.Write("Digite um valor : ");

		int numero;

		numero = int.Parse(Console.ReadLine());

		if (numero >= 0)
			Console.WriteLine("Número positivo");

	}
}
