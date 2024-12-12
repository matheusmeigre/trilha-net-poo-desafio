namespace DesafioPOO.Models
{
    // Herdando da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // Construtor que chama o construtor da classe base (Smartphone)
        public Iphone(string numero, string modelo, string imei, int memoria) 
            : base(numero, modelo, imei, memoria) // Chama o construtor da classe base
        {
        }

        // Sobrescrevendo o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando o aplicativo {nome} no iPhone...");
            // Lógica de instalação para o modelo iPhone
            Console.WriteLine($"Aplicativo {nome} instalado com sucesso no iPhone.");
        }
    }
}