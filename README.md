# Ocelot API Gateway com Blazor

Este é um projeto simples criado para estudo demonstrando o uso de API Gateway com Ocelot no .NET, integrado a microsserviços e um front-end em Blazor WebAssembly


## **Tecnologias Utilizadas**

- **Blazor WebAssembly**: Para o front-end, utilizando componentes e integração com a API Gateway.
- **API Gateway (Ocelot)**: Para gerenciar as requisições HTTP e fazer o roteamento entre as APIs.
- **ASP.NET Core**: Para as APIs (Customers, Orders, Products).


## **Estrutura do Projeto**

- **BlazorApp**: O projeto Blazor WebAssembly que consome os serviços da API através do API Gateway.
  - **Pages**: Contém as páginas `Customers`, `Orders` e `Products`, que fazem chamadas para a API.
  - **Services**: Serviço responsável por fazer as requisições HTTP para o API Gateway.
  
- **ApiGateway**: O projeto do API Gateway usando Ocelot para roteamento das requisições para as APIs.
  - **ocelot.json**: Arquivo de configuração do Ocelot.
  
- **APIs (Customers, Orders, Products)**: APIs simples que retornam dados simulados de clientes, pedidos e produtos.


## **Como Funciona**

- O **Blazor WebAssembly** faz uma requisição para o **API Gateway** (Ocelot).
- O **API Gateway** roteia a requisição para a API correspondente (Customers, Orders ou Products).
- A **API** processa a requisição e retorna os dados, que são exibidos na interface do Blazor.


## **Como Executar**

1. **Executar as APIs**:
   - Navegue até os diretórios das APIs (`Customers.API`, `Orders.API`, `Products.API`) e execute:

   ```bash
   dotnet run
   ```

2. **Executar o API Gateway**:
   - Navegue até o diretório do **ApiGateway** e execute:

   ```bash
   dotnet run
   ```

3. **Executar o Blazor WebAssembly**:
   - Navegue até o diretório do **BlazorApp** e execute:

   ```bash
   dotnet run
   ```

Após isso, o Blazor WebAssembly estará acessível consumindo as APIs através do **API Gateway**.
