Utilizando o Banco de Dados MS SQL Express;

Criei um banco chamado: cadastros

Criei uma tabela chamada: pessoas

	create table pessoas(
		id int identity(1,1),
		nome nvarchar(max),
		codigo int,
		foto nvarchar(max),
		email nvarchar(max) 
	)
	
Criei um novo projeto do tipo: "ASP.NET Core Web API" com as opções:	
	Framework: .NET 7.0 (LTS)
	Sem autenticação;
	Desmarcar HTTPS;
	OpenAPI support;
	Use controllers;	
	
No 'Gerenciador de Soluções' do VS, clique com o botão direito sobre a aplicação e abra o 'Gerenciar Pacotes do NuGet'
Instale o pacote: 'Microsoft.EntityFrameworkCore' (Versão 7.0.16)
Instale o pacote: 'Microsoft.EntityFrameworkCore.SqlServer'  (Versão 7.0.16)

Crie uma pasta no projeto chamada 'Model' e dentro dela, crie uma classe chamada 'Pessoa.cs' e uma interface chamada 'IPessoaRepository.cs'

Crie uma pasta no projeto chamada 'Infraestrutura' e dentro dela, crie uma classe chamada 'ConnectionContext.cs' e uma classe chamada 'PessoaRepository.cs'

Crie uma pasta no projeto chamada 'ViewModel' e dentro dela, crie uma classe chamada 'PessoaViewModel.cs'

Para utilização da Injeção de Dependência, 
(capacidade de poder usar a interface ao invés de instanciar as classes dentro do projeto)
adicione a seguinte linha ao 'Program.cs':
builder.Services.AddTransient<IPessoaRepository, PessoaRepository>();

Crie na pasta no projeto chamada 'Controllers' um controlador chamado 'PessoaController.cs'

Crie uma pasta no projeto chamada 'Storage'

No 'Gerenciador de Soluções' do VS, clique com o botão direito sobre a aplicação e abra o 'Gerenciar Pacotes do NuGet'
Instale o pacote: 'Microsoft.IdentityModel.Tokens' (Versão 7.3.1)
Instale o pacote: 'System.IdentityModel.Tokens.Jwt'  (Versão 7.3.1)
Instale o pacote: 'Microsoft.AspNetCore.Authentication.JwtBearer' (Versão 7.0.16)

Crie na pasta raiz do projeto uma classe chamada 'Key.cs'

Crie uma pasta no projeto chamada 'Services' e dentro dela uma classe chamada 'TokenService.cs'

Crie na pasta no projeto chamada 'Controllers' um controlador chamado 'AuthController.cs'

