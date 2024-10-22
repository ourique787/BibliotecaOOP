# BibliotecaOOP


Como utilizar o programa:

Abra a pasta BibliotecaOOP em um editor de código, preferencialmente VScode.

Abra a classe Program.cs, nela você vai encontrar alguns códigos escritos.

Em:
Usuario usuario = new Usuario("Lucas", "001", "Rua José Bonifacio", "123456789");
Você pode alterar o que está dentro dos parenteses, os parametros, respectivamente para: (Nome, NumeroIdentificacao, Endereco, Contato), mantendo as aspas duplas, para instanciar um Usuário;
Para instanciar outro usuário, repita o processo, alterando o nome usuario, que está depois de Usuario, já que não pode ser o mesmo nome, coloque usuario1, usuario2, de sua preferencia.

Para cadastrar os usuários na biblioteca, altere o que está abaixo:

biblioteca.CadastrarUsuario(usuario);
biblioteca.CadastrarUsuario(usuario1);

Coloque o nome do objeto que foi instanciado, usuario, usuario1, usuario2 (o que você decidiu), dentro do parenteses.

Para instanciar os livros, repita o processo:

Livro livro = new Livro("Harry Potter e a Pedra Filosofal", "001", "J.K Rowling", "123456789", "Fantasia", 5);

Altere para título, código, autor(a), IBSM, Gênero, Quantidade em Estoque.

Logo após, cadastre os livros na biblioteca.

biblioteca.CadastrarLivro(livro);

Colocando entre parenteses o nome da instância que você deu ao objeto.


Para emprestar um livro, utilize:

livro1.Emprestar(usuario)

Sendo livro1 o nome do objeto que você instanciou o livro, e entre parenteses o nome do usuário que você instanciou. (Não o nome literal da pessoa, o nome do objeto)

Em:
Biblioteca.PesquisarPorTitulo("Harry Potter");
Biblioteca.PesquisarPorAutor("J.K Rowling");
Biblioteca.PesquisarPorGenero("Fantasia");

Você apenas substitui o que está dentro das aspas, caso queira fazer uma pesquisa, por título, autor e genero, respectivamente.

Caso queira emprestar um livro e souber o número da pessoa e o código do livro, utilize:

biblioteca.EmprestarLivro("001", "002)
Substituindo o primeiro por código do livro, e o segundo pelo número da pessoa;

Bom uso!!!


O PDF com o texto está dentro da pasta BibliotecaOOP!

Abaixo segue o link do vídeo explicando melhor:
https://www.youtube.com/watch?v=_J3_CUmRCuM










