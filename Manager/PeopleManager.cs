class PeopleManager
{
    static List<Pessoa> pessoas = new List<Pessoa>();


    public static void CadastrarPessoa()
    {
        Console.WriteLine("\nCadastro de pessoa:");

        Pessoa pessoa = new Pessoa();

        string nome;
        string telefone;

        do
        {
            Console.Write("Nome: ");
            nome = Console.ReadLine();

            Console.Write("Telefone: ");
            telefone = Console.ReadLine();

            if (string.IsNullOrEmpty(nome) || (string.IsNullOrEmpty(telefone)))
            {
                Console.WriteLine("Todos os campos devem estar completos. Escreva novamente.");
            }
        } while (string.IsNullOrEmpty(nome) || (string.IsNullOrEmpty(telefone)));


        pessoa.Id = pessoas.Count + 1;

        pessoa.Nome = nome;
        pessoa.Telefone = telefone;

        pessoas.Add(pessoa);

        Console.Clear();
        Console.WriteLine("\nPessoa cadastrada com sucesso!\n");
    }


    public static void ListarPessoas()
    {
        if (pessoas.Count == 0)
        {
            Console.WriteLine("Não há pessoas cadastradas.");
            return;
        }

        Console.WriteLine("\nLista de pessoas cadastradas:");
        var listar = pessoas.FindAll(p => true);
        listar.ForEach(p => Console.WriteLine($"\n\nID: {p.Id}\nNome: {p.Nome} \nTelefone: {p.Telefone}"));
    }


    public static void AtualizarPessoa()
    {
        Console.WriteLine("Digite o ID da pessoa que deseja atualizar:");
        int id = int.Parse(Console.ReadLine());

        Pessoa pessoa = BuscarPessoaId(id);

        if (pessoa == null)
        {
            Console.WriteLine("Pessoa não encontrada.");
        }
        else
        {
            Console.WriteLine("Digite o novo nome da pessoa:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o novo número de telefone da pessoa:");
            string telefone = Console.ReadLine();

            pessoa.Nome = nome;
            pessoa.Telefone = telefone;

            Console.Clear();
            Console.WriteLine("Dados atualizados com sucesso!");
        }
    }

    public static void ExcluirPessoa()
    {
        Console.WriteLine("Digite o ID da pessoa que deseja excluir:");
        int id = int.Parse(Console.ReadLine());

        Pessoa pessoa = BuscarPessoaId(id);

        if (pessoa == null)
        {
            Console.WriteLine("Pessoa não encontrada.");
        }
        else
        {
            pessoas.Remove(pessoa);
            Console.Clear();
            Console.WriteLine("Pessoa excluída com sucesso!");
        }
    }

    static Pessoa BuscarPessoaId(int id)
    {
        var pe = pessoas.Find(p => p.Id == id);

        return pe;
    }
}