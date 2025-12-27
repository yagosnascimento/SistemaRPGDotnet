namespace SistemaRPG.Models;

public abstract class Personagem
{
    public string Nome { get; set; }
    public int Vida { get; set; }

    public Personagem(string nome, int vida)
    {
        Nome = nome;
        Vida = vida;
    }

    public void ReceberDano(int dano)
    {
        Vida -= dano;
        Console.WriteLine($"{Nome} recebeu {dano} de dano! Vida restante: {Vida}!");
    }

    public virtual void Atacar()
    {
        Console.WriteLine($"{Nome} realizou um ataque básico!");
    }
}