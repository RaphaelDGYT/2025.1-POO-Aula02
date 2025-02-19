namespace Uni9.Aula03;
class Televisao
{
    //O método construtor possui o mesmo nome da classe. 
    // Ele não possui retorno (nem mesmo o void)
    //Este método é executado sempre que uma instancia da classe
    //é criada.
    //Por padrão, o C# cria um método construtor publico vazio,
    //mas podemos criar métodos construtores com outras
    //visibilidades e recebendo parametros, se necessário.
    public Televisao(float tamanho)
    {
        if(tamanho < TAMANHO_MINIMO || tamanho > TAMANHO_MAXIMO)
        {
            throw new ArgumentOutOfRangeException($"O tamanho({tamanho}) não é suportado!");
        }
        Tamanho = tamanho;
        Volume = VOLUME_PADRAO;
    }    
    
    private const float TAMANHO_MINIMO = 22;
    private const float TAMANHO_MAXIMO = 80;
    private int VOLUME_MAXIMO = 100;
    private int VOLUME_MINIMO = 0;
    private int VOLUME_PADRAO = 10;
    // Get: permite que seja executada a
    // leitura do valor atual da prop
    // Set: permite que seja atribuido um
    // valor para a prop

    // classes, prop e methods possuem modificadores de acesso
    // public: visiveis a todo o projeto
    // internal: visiveis somente no namespace
    // protected: visiveis somente na classe e nas classes que herdam
    // private: visiveis soemente na classe que foram criadas
    public float Tamanho {get; }
    public int Resolucao { get; set; }
    public int Volume { get; private set; }
    public int Canal { get; set; }

    public void AumentarVolume()
    {
        if(Volume < VOLUME_MAXIMO)
            Volume++;
        else
            Console.WriteLine("A tv já está no volume maximo permitido!");
    }

    public void DiminuirVolume()
    {
        if (Volume > VOLUME_MINIMO)
            Volume--;
        else
            Console.WriteLine("A tv já está no volume mínimo permitido!");
    }
    
} 
