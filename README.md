# AspNetCore_API_AutoMapper
AspNetCore + API+ AutoMapper

#Porque utilizar?

	a)Resolver o conflito entre as responsabilidades das camadas de uma aplicação através
	do mapeamento entre os objetos.
	
	b)Segregar os modelos usados nas camadas de forma a resolver este conflito fazendo o 
	mapeamento objeto-objeto-o
	
	c) Isolar o modelo usado em uma camada de forma a expor somente algumas das suas 
	propriedades através do mapeamento entre os objetos


#Pacotes usados:

AutoMapper
AutoMapper.Extensions.Microsoft.DependencyInjection
AutoMapper.Extensions.DependencyInjection.Abstractions
Microsft.Extensions.Options


#Detalhes

Obs: AppDomain.CurrentDomain.GetAssemblies() => Carrega todos os assemblies desse dominio

Obs: Na classe MappingProfile você irá mapear da origem (MapFrom) para o destino (ForMember) 

Obs: ReverseMap() => Mapea "vice e versa", ou seja : Mapea de Funcionario para FuncionarioDTO e de FuncionarioDTO para Funcionario

Obs: Ponha um breakPoint no metodo MapperClassXToClassY para ver o mapeamento
	
#Execute o Projeto

1)Irá abrir o Swagger
2)Clique em /api/Funcionarios
3)Clique em Try it out
4)Preencha o Request Body

{
  "nome": "SeuPrimeiroNome",
  "sobrenome": "SeuSobreNome",
  "sexo": 1,
  "endereco": {
    "cidade": "SuaCidade"
  },
  "salario": 1000
}

5)Clique em execute

Obs: Cairá no seu breakPoint. Debug e veja como foi mapeado
