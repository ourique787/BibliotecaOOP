Biblioteca biblioteca = new Biblioteca();

Usuario usuario = new Usuario("Lucas", "001", "Rua José Bonifacio", "123456789");
Usuario usuario1 = new Usuario("Fogaça", "002", "Rua Barão do Rio Branco", "987654321");

biblioteca.CadastrarUsuario(usuario);
biblioteca.CadastrarUsuario(usuario1);

Livro livro = new Livro("Harry Potter e a Pedra Filosofal", "001", "J.K Rowling", "123456789", "Fantasia", 5);
Livro livro1 = new Livro("Harry Potter e o Enigma do Principe", "002", "J.K Rowling", "987654321", "Fantasia", 3);


biblioteca.CadastrarLivro(livro);
biblioteca.CadastrarLivro(livro1);


livro1.Emprestar(usuario);
livro1.Emprestar(usuario1);
livro1.Devolver();


Biblioteca.PesquisarPorTitulo("Harry Potter");
Biblioteca.PesquisarPorAutor("J.K Rowling");
Biblioteca.PesquisarPorGenero("Fantasia");



biblioteca.EmprestarLivro("001", "002");














