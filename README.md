Para correr este projeto localmente:

Base de Dados:

Cria uma base de dados chamada Vet.

Executa os scripts de criação das tabelas (Cliente, Animal, Consulta).

String de Conexão:

<add key="ConnectionString" value="Server=localhost;Database=Vet;Integrated Security=True;TrustServerCertificate=True"/>

No ficheiro App.config, ajusta o Data Source para o nome do teu servidor SQL (ex: localhost ou .\SQLEXPRESS).

Utilizadores:

Recepcionista - 100     Password: 123
Veterinário - 200      Password: 456


Este programa serve para gerir uma clinica veterinária, ele permite adicionar Clientes e Animais assim como marcar Consultas e ver o Histórico das consultas passadas.
(Adicionar Animais e a parte de Editar e Eliminar tanto animais como clientes não funciona, assim como a parte de pesquisar os clientes através do NIF)
