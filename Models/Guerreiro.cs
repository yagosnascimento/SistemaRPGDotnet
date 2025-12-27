using SistemaRPG.Models;
namespace SistemaRPG.Models;

public class Guerreiro : Personagem
{
    public Guerreiro(string nome) : base(nome, 100) { }

    public override void Atacar()
    {
        Console.WriteLine($"{Nome} golpeou com sua espada gigante!");
    }
}