using SistemaRPG.Models;

class Program
{
    static void Main(string[] args)
    {
        List<Personagem> grupo = new List<Personagem>();

        grupo.Add(new Guerreiro("Aragorn"));
        grupo.Add(new Mago("Gandalf"));
        grupo.Add(new Guerreiro("Boromir"));

        Console.WriteLine("Começando: ");

        foreach (Personagem p in grupo)
        {
            p.Atacar(); 

            if (p is ICurador curador)
            {
                curador.Curar(grupo[0]);
            }
        }
    }
}