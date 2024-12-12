using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

        var meuNokia = new Nokia("12345", "Nokia 6", "123456789012345", 64);

        // Testando os métodos da classe Nokia
        Console.WriteLine("Testando Nokia:");
        meuNokia.Ligar();
        meuNokia.ReceberLigacao();
        meuNokia.InstalarAplicativo("WhatsApp");
        
        Console.WriteLine(); // Linha em branco para separar os testes

          var meuIphone = new Iphone("98765", "iPhone 12", "987654321098765", 128);

        // Testando os métodos da classe Iphone
        Console.WriteLine("Testando iPhone:");
        meuIphone.Ligar();
        meuIphone.ReceberLigacao();
        meuIphone.InstalarAplicativo("Instagram");

        // Fim do programa
        Console.WriteLine();
        Console.WriteLine("Testes concluídos.");