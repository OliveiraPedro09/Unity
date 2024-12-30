// * Screen Sound Alura

string welcomeMsg = "Boas Vindas Ao Screen Sound!"; // ! Toda Variavel deve ser finalizada com ;

// * Console.WriteLine é um método que exibe uma mensagem no console
// * Console.WriteLine(welcomeMsg);

// * Criando uma Função
void ShowMsg(){
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░"); 
// ! @ Chamado de Verbatim Literal que basicamente mostra o texto como ele realmente é 
    Console.WriteLine(welcomeMsg);
}

int notaMedia = 6;

if (notaMedia >= 5){
    Console.WriteLine("Nota suficiente para aprovação");
}

void MenuOptions(){
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
            Console.WriteLine("Cadastrar Banda");
            break;
        case 2:
            Console.WriteLine("Mostrar todas as Bandas");
            break;
        case 3:
            Console.WriteLine("Avaliar Banda");
            break;
        case 4:
            Console.WriteLine("Mostrar Média da Banda");
            break;
        case 5:
            Console.WriteLine("Tchau Tchau :) ");
            break;
        default:
            Console.WriteLine("Tchau Tchau :) ");
            break;
    }
}

ShowMsg(); // * Chamar a função
MenuOptions();