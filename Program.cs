// * Screen Sound Alura

string welcomeMsg = "\nBoas Vindas Ao Screen Sound!"; // ! Toda Variavel deve ser finalizada com ;
// * Console.WriteLine é um método que exibe uma mensagem no console
// * Console.WriteLine(welcomeMsg);


List<string> listBands = new List<string>{"Black Sabbath", "AC/DC", "Iron Maiden"}; // * Criando uma Lista de Bandas

// * Criando uma Função
void logo(){
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░"); 
// ! @ Chamado de Verbatim Literal que basicamente mostra o texto como ele realmente é 
}

void ShowMsg(){
    Console.Clear(); // * Limpa a Tela
    logo();
    Console.WriteLine(welcomeMsg);
}

int notaMedia = 6;

if (notaMedia >= 5){
    Console.WriteLine("Nota suficiente para aprovação");
}

void MenuOptions(){
    ShowMsg();
    Console.WriteLine("\n1 - Cadastrar Banda");
    Console.WriteLine("2 - Mostrar todas as Bandas");
    Console.WriteLine("3 - Avaliar Banda");
    Console.WriteLine("4 - Mostrar Média da Banda");
    Console.WriteLine("5 ou Outra Tecla - Sair");

    Console.Write("\nEscolha uma opção: ");
    string option = Console.ReadLine()!; // ! Ler a opção do Usuário, e o ! mostra que não pode ser nulo
    int optionInt = int.Parse(option); // * Parse Converte uma string em um inteiro

    
    switch(optionInt){
        
        case 1:
            RegisterBand();
            break;
        case 2:
            AllBands();
            break;
        case 3:
            Console.WriteLine("Avaliar Banda");
            break;
        case 4:
            Console.WriteLine("Mostrar Média da Banda");
            break;
        case 5:
            exit();
            break;
        default:
            exit();
            break;
    }
}

void RegisterBand(){
    Console.Clear();
    logo();
    Console.WriteLine("Cadastro de Banda");
    Console.Write("\nDigite o nome da Banda: ");
    string bandName = Console.ReadLine()!;
    listBands.Add(bandName); // * Adiciona o nome da Banda na Lista
    Console.WriteLine($"\nA Banda {bandName} foi cadastrada com sucesso!");
    Thread.Sleep(1000);
    Console.Clear();
    back();
    MenuOptions();
}

void AllBands(){
    Console.Clear();
    logo();
    Console.WriteLine("Todas as Bandas Cadastradas");
    // for (int i = 0; i < listBands.Count; i++){ Console.WriteLine(listBands[i]); }
    foreach(string band in listBands){
        Console.WriteLine("");
        Console.WriteLine(band);
    }
    Console.WriteLine("\nPressione qualquer tecla para voltar ao Menu");
    Console.ReadKey(); // * Aguarda o Usuário pressionar uma tecla
    Console.Clear();
    back();
    MenuOptions();
}
void exit(){
    Console.Write("Saindo");

    for (int i = 0; i < 3; i++)
    {
        Thread.Sleep(800);
        Console.Write("."); // Adiciona um ponto à mesma linha
    }

    Console.Clear();
    Environment.Exit(0); // Encerra o programa
}
void back(){
    Console.Write("Voltando");

    for (int i = 0; i < 3; i++)
    {
        Thread.Sleep(800);
        Console.Write(".");
    }
    Console.Clear();
}

MenuOptions();
