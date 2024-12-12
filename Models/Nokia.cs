namespace DesafioPOO.Models
{
    // Herdando da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // Sobrescrevendo o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando o aplicativo {nome} na Nokia...");
            // Aqui você pode adicionar o código específico para a instalação de aplicativos no modelo Nokia
            // Exemplo de lógica fictícia para instalação:
            Console.WriteLine($"Aplicativo {nome} instalado com sucesso na Nokia.");
        }
    }
}