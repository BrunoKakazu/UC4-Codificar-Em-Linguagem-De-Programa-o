using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Ex2
{
	public Ex2()
	{
		
	}

	public void VerificaIdade()
	{
        Console.Write("Digite sua idade: ");

        int idade;

        idade = int.Parse(Console.ReadLine());

        if (idade >= 18)
            Console.WriteLine("Maior de idade");
    }
}
