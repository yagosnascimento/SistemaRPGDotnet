using SistemaRPG.Models;
namespace SistemaRPG.Models;
public class Mago : Personagem, ICurador
{
    public int Mana { get; set; }

    public Mago(string nome) : base(nome, 60)
    {
        Mana = 50;
    }

    public override void Atacar()
    {
        Console.WriteLine($"{Nome} lançou uma bola de fogo!");
    }

    public void Curar(Personagem alvo)
    {
        alvo.Vida += 15;
        Console.WriteLine($"{Nome} curou {alvo.Nome}.");
    }
}