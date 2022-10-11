namespace TesteVagaJr.Domain.Entities;

public class Telefone
{
    public string DDD { get; private set; }
    public string Numero { get; private set; }


    public override string ToString() => $"({DDD}) {Numero}";

    public Telefone(string DDD, string numero)
    {
        this.DDD = DDD;
        this.Numero = numero;
    }
}