class Menu{

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("*------------MENU-----------*");
            Console.WriteLine("[1] Cadastrar pessoa");
            Console.WriteLine("[2] Listar pessoas");
            Console.WriteLine("[3] Atualizar pessoa");
            Console.WriteLine("[4] Excluir pessoa");
            Console.WriteLine("[99] Sair");
            Console.WriteLine("*------------MENU-----------*");

            Console.Write("\nDigite a opção desejada: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    PeopleManager.CadastrarPessoa();
                    break;
                case "2":
                    PeopleManager.ListarPessoas();
                    break;
                case "3":
                    PeopleManager.AtualizarPessoa();
                    break;
                case "4":
                    PeopleManager.ExcluirPessoa();
                    break;
                case "99":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\nOpção inválida\n");
                    break;
            }
        }
    }
}