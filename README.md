Para correr este projeto localmente:

Base de Dados:

Cria uma base de dados chamada Vet.

Executa os scripts de criação das tabelas (Cliente, Animal, Consulta).

String de Conexão:

<add key="ConnectionString" value="Server=localhost;Database=Vet;Integrated Security=True;TrustServerCertificate=True"/>

No ficheiro App.config, ajusta o Data Source para o nome do teu servidor SQL (ex: localhost ou .\SQLEXPRESS).


Utilizadores:

Recepcionista - Login: 100     Password: 123
Veterinário - Login: 200      Password: 456


Este programa serve para gerir uma clinica veterinária, ele permite adicionar Clientes e Animais assim como marcar Consultas e ver o Histórico das consultas passadas.
(Adicionar Animais funciona se for depois de criar o cliente se for tentar associar a um cliente já existente dá conflitp, a parte de Editar e Eliminar tanto animais como clientes não existe e a parte de pesquisar os clientes através do NIF não funciona) -> Alterações para updates futuros
