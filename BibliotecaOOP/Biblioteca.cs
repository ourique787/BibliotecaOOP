public class Biblioteca{
    public static List<Livro> Livros { get; set; } = new List<Livro>();

    public List<Usuario> Usuarios { get; set; } = new List<Usuario>();


    public void CadastrarLivro(Livro livro){
        Livros.Add(livro);
        Console.WriteLine("Livro cadastrado com sucesso!");
    }

    public void CadastrarUsuario(Usuario usuario){
        Usuarios.Add(usuario);
        Console.WriteLine("Usuário cadastrado com sucesso!");
    }

    public void EmprestarLivro(string codigoLivro, string numeroUsuario){
        Livro livro = Livros.Find(l => l.Codigo == codigoLivro);
        Usuario usuario = Usuarios.Find(u => u.NumeroIdentificacao == numeroUsuario);

        if (livro != null && usuario != null)
        {
            livro.Emprestar(usuario);
        }
        else
        {
            Console.WriteLine("O Livro ou o Usuário não foram encontrados.");
        }
    }

    public void DevolverLivro(string codigoLivro){
        Livro livro = Livros.Find(l => l.Codigo == codigoLivro);

        if (livro != null)
        {
            livro.Devolver();
        }
        else
        {
            Console.WriteLine("O Livro não foi encontrado.");
        }

    }

    public void ListarLivros(){
        foreach(var livro in Livros){
            Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.Autor}, Genero: {livro.Genero}, Codigo: {livro.Codigo}, ISBN: {livro.ISBN}");
        }

    }

    public void ListarUsuarios(){
        foreach(var usuario in Usuarios)
        {
            Console.WriteLine($"Nome: {usuario.Nome}, Número de Identificação: {usuario.NumeroIdentificacao}, Endereço: {usuario.Endereco} Contato: {usuario.Contato}");
        }
    }

    public static void PesquisarPorTitulo(string titulo)
    {
        Console.WriteLine($"Resultados da pesquisa por título '{titulo}':");
        foreach (var livro in Livros)
        {
            if (livro.Titulo.IndexOf(titulo, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.Autor}, Código: {livro.Codigo}, ISBN: {livro.ISBN}, Gênero: {livro.Genero}");
            }
        }
    }

    public static void PesquisarPorAutor(string autor)
    {
        Console.WriteLine($"Resultados da pesquisa por autor '{autor}':");
        foreach (var livro in Livros)
        {
            if (livro.Autor.IndexOf(autor, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.Autor}, Código: {livro.Codigo}, ISBN: {livro.ISBN}, Gênero: {livro.Genero}");
            }
        }
    }

    public static void PesquisarPorGenero(string genero)
    {
        Console.WriteLine($"Resultados da pesquisa por gênero '{genero}':");
        foreach (var livro in Livros)
        {
            if (livro.Genero.IndexOf(genero, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.Autor}, Código: {livro.Codigo}, ISBN: {livro.ISBN}, Gênero: {livro.Genero}");
            }
        }
    }




}
