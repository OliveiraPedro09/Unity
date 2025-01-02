// * Screen Sound Alura

string welcomeMsg = "\nBoas Vindas Ao Screen Sound!"; // ! Toda Variavel deve ser finalizada com ;

// List<string> listBands = new List<string>{"Black Sabbath", "AC/DC", "Iron Maiden"}; // * Criando uma Lista de Bandas

Dictionary<string, List<int>> bands = new Dictionary<string, List<int>>();
bands.Add("Black Sabbath", new List<int>{10,9,8});
bands.Add("AC/DC", new List<int>{10,8,4,4});
bands.Add("Iron Maiden", new List<int>{10,10,10,10,10});
bands.Add("Led Zeppelin", new List<int>{10,9,9,9,8});

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
    Console.Clear();
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
    int optionInt = int.Parse(option);

    
    switch(optionInt){
        
        case 1:
            RegisterBand();
            break;
        case 2:
            AllBands();
            break;
        case 3:
            BandRate();
            break;
        case 4:
            BandAvgRate();
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
    optionTitle("Cadastro de Banda");
    Console.Write("\nDigite o nome da Banda: ");
    string bandName = Console.ReadLine()!;
    //listBands.Add(bandName); // * Adiciona o nome da Banda na Lista
    bands.Add(bandName,new List<int>());
    Console.WriteLine($"\nA Banda {bandName} foi cadastrada com sucesso!");
    Thread.Sleep(1000);
    Console.Clear();
    back();
    MenuOptions();
}

void AllBands(){
    Console.Clear();
    logo();
    optionTitle("Listar todas as Bandas");
    foreach(string band in bands.Keys){
        Console.WriteLine("");
        Console.WriteLine(band);
    }
    Console.WriteLine("\nPressione qualquer tecla para voltar ao Menu");
    Console.ReadKey(); // * Aguarda o Usuário pressionar uma tecla
    Console.Clear();
    back();
    MenuOptions();
}

void BandRate(){
    Console.Clear();
    logo();
    optionTitle("Avaliar Banda");
    foreach(string band in bands.Keys){
        Console.WriteLine(band + "\n");
    }
    Console.Write("\nDigite o nome da Banda que deseja avaliar: ");
    string bandName = Console.ReadLine()!;
    if (bands.ContainsKey(bandName)){
        Console.Write($"Digite a nota da Banda {bandName}: ");
        int rate = int.Parse(Console.ReadLine()!);
        bands[bandName].Add(rate);
        Console.WriteLine($"\nA Banda {bandName} foi avaliada com sucesso! Com a nota {rate}");
        Thread.Sleep(1000);
        Console.Clear();
        back();
        MenuOptions();
    } else {
        Console.WriteLine($"\nA Banda {bandName} não foi encontrada");
        back();
        MenuOptions();
    }
}

void BandAvgRate(){
    Console.Clear();
    logo();
    optionTitle("Média da Banda");
    foreach(string band in bands.Keys){
        Console.WriteLine(band + "\n");
    }
    Console.Write("\nDigite o nome da Banda que deseja ver a média: ");
    string bandName = Console.ReadLine()!;
    if (bands.ContainsKey(bandName)){
        double avg = bands[bandName].Average();
        Console.WriteLine($"\nA média da Banda {bandName} é {avg}");
        Thread.Sleep(1000);
        Console.Clear();
        back();
        MenuOptions();
    } else {
        Console.WriteLine($"\nA Banda {bandName} não foi encontrada");
        back();
        MenuOptions();
    }
}

void optionTitle( string title ){

    int titleLength = title.Length;
    string underline = string.Empty.PadLeft(titleLength, '_'); // ! Um caractere você usa aspas simples
    Console.WriteLine(underline + "\n");
    Console.WriteLine(title);
    Console.WriteLine(underline + "\n");
}

void exit(){
    Console.Write("Saindo");

    for (int i = 0; i < 3; i++)
    {
        Thread.Sleep(800);
        Console.Write(".");
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
