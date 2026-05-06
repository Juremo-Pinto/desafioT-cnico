using System;
using System.ComponentModel;
using static System.Console;

class DesafioTecnico
{
    static void Main()
    {
        string nome1, nome2;
        int atbFor1, atbFor2, atbAgi1, atbAgi2, atbInt1, atbInt2, atbVida1, atbVida2 = 0;

        // Primeiro personagem!
        nome1 = "Gojo";
        atbFor1 = 18;
        atbAgi1 = 20;
        atbInt1 = 20;
        atbVida1 = 30;
        
        // Segundo personagem!
        nome2 = "Sukuna";
        atbFor2 = 20;
        atbAgi2 = 16;
        atbInt2 = 21;
        atbVida2 = 40;

        WriteLine("Iniciando batalha!");
        for (int bananas = 3; bananas > 0; bananas--)
        {
            WriteLine($"{bananas}!");
        }
        int vencedor = provaResistencia(atbVida1, atbVida2, atbAgi1, atbAgi2);
        WriteLine($"Personagem 1: {nome1}, Força: {atbFor1}, Agilidade: {atbAgi1}, Inteligência: {atbInt1}, Vida: {atbVida1}");
        WriteLine($"Personagem 2: {nome2}, Força: {atbFor2}, Agilidade: {atbAgi2}, Inteligência: {atbInt2}, Vida: {atbVida2}");
        Write("Em uma batalha estratégica, o vencedor foi: ");
        switch (vencedor)
        {
            case 1:
            Write($"{nome1}!");
            break;
            case 2:
            Write($"{nome2}!");
            break;
            default:
            Write("Isso não deveria ter acontecido!");
            break;
        }

    }

    static int provaResistencia(int atbVida1, int atbVida2, int atbAgi1, int atbAgi2)
    {
        int totalRES1 = atbVida1 + atbAgi1;
        int totalRES2 = atbVida2 + atbAgi2;

        if (totalRES1 > totalRES2)
        {
            return 1;
        }
        else
        {
            return 2;
        }
    }
}