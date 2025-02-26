using Uni9.Aula03;

namespace Uni9.Aula03.test;

[TestClass]
public class TelevisaoTest
{
    [TestMethod]
    public void Dado_Tamanho_21_Deve_Retornar_Excecao()
    {
        Assert.ThrowsExcepetion<ArgumentOutOfRangeException>(() => new Televisao(21f), $"O tamanho(21) não é suportado!");
    }

    [TestMethod]
    public void Dado_Tamanho_81_Deve_Retornar_Excecao()
    {
        Assert.ThrowsExcepetion<ArgumentOutOfRangeExcepetion(() => new Televisao(81f), $"O tamanho(81) não é suportado!");
    }
}