## 🧠 O que aprendemos aqui?

Neste projeto, usamos 4 conceitos principais para resolver problemas lógicos:

### 1. Herança (A "Genética" do Código)

**O Problema:** No começo, teríamos que escrever `Nome` e `Vida` dentro da classe Guerreiro, depois de novo no Mago, depois no Arqueiro... Muita repetição.

**A Solução:** Criamos uma classe pai chamada `Personagem`.

* Ela guarda tudo o que é comum a todos (Nome, Vida).
* Guerreiro e Mago **herdam** (`: Personagem`) tudo dela.
* **Por que é bom?** Se quisermos adicionar um atributo "Nível", adicionamos só no pai e todo mundo ganha automaticamente.

### 2. Classes Abstratas (O "Molde Proibido")

**O Problema:** Faz sentido criar um "Personagem" genérico no jogo? Tipo, um boneco cinza sem arma e sem classe? Não.

**A Solução:** Usamos a palavra `abstract` na classe `Personagem`.

* Isso proíbe o programa de fazer `new Personagem()`.
* O código obriga a criar algo específico: ou é `new Guerreiro()` ou `new Mago()`.
* **Por que é bom?** Segurança. Evita que a gente crie objetos "fantasmas" que não deveriam existir no jogo.

### 3. Polimorfismo (O mesmo comando, ações diferentes)

**O Problema:** Queremos fazer um loop onde todo mundo ataca. Mas o Guerreiro usa espada e o Mago usa fogo. Teríamos que fazer vários `if`? (*Se for guerreiro, bata. Se for mago, solte magia...*)

**A Solução:** Usamos `virtual` no pai e `override` nos filhos.

* O programa principal apenas manda a ordem: `personagem.Atacar()`.
* Cada classe sabe como realizar esse ataque do seu jeito.
* **Por que é bom?** Deixa o código limpo. O `Program.cs` não precisa saber *como* o ataque funciona, ele só manda atacar.

### 4. Interfaces (O "Contrato de Habilidades")

**O Problema:** O Mago pode curar, mas o Guerreiro não. Se colocássemos o método `Curar` na classe `Personagem`, o Guerreiro herdaria e poderia curar (o que seria estranho).

**A Solução:** Criamos uma Interface `ICurador`.

* É como um "crachá" ou certificado. Quem usa esse crachá (`: ICurador`) é obrigado a saber curar.
* O Mago assina esse contrato. O Guerreiro não.
* **Por que é bom?** Permite dar poderes específicos para apenas alguns grupos, sem bagunçar a herança principal.

---

*Desenvolvido para fins de estudo em C# .NET.*