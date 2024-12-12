namespace DesafioPOO.Models
{
    // Herdando da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // Construtor que chama o construtor da classe base (Smartphone)
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria) // Passa os parâmetros para o construtor da classe base
        {
        }

        // Sobrescrevendo o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando o aplicativo {nome} na Nokia...");
            // Lógica de instalação para o modelo Nokia
            Console.WriteLine($"Aplicativo {nome} instalado com sucesso na Nokia.");
        }
    }
}
