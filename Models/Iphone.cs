
namespace DesafioPOO.Models
{
    // Herda da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // Construtor para a classe Iphone
        public Iphone(string numero, string modelo, string mei, int memoria)
            : base(numero, modelo, mei, memoria)
        {
            // TODO: Adicionar inicializações específicas do iPhone, se necessário
              Ligar();
        }

        // Sobrescreve o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando o aplicativo {nome} na App Store do iPhone.");
        }
    }
}