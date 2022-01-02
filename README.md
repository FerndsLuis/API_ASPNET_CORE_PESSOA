# API com ASP.NET Core

Nesse projeto iremos consumir uma API com as requisições: Get, Post, Put e Delete.
O banco de dados será o MySQL. Todas as requições terão efeito direto no banco de dados.

## Documentação da API

#### Retorna todos as pessoas

```http
  GET /pessoa/api
```

#### Retorna uma pessoa

```http
  GET /pessoa/api/${codigo}
```

| Parâmetro | Tipo  | Descrição                                     |
| :-------- | :---- | :-------------------------------------------- |
| `codigo`  | `int` | **Obrigatório**. O ID do pessoa que você quer |

#### Cadastra uma pessoa

```http
  POST /pessoa/api/
```

| Parâmetro | Tipo     | Descrição        |
| :-------- | :------- | :--------------- |
| `nome`    | `string` | O nome da pessoa |
| `cidade`  | `string` | cidade da pessoa |
| `idade`   | `int`    | idade da pessoa  |

#### Atualiza uma pessoa

```http
  PUT /pessoa/api/${codigo}
```

| Parâmetro | Tipo     | Descrição                         |
| :-------- | :------- | :-------------------------------- |
| `codigo`  | `int`    | **Obrigatório**. Código da pessoa |
| `nome`    | `string` | O nome da pessoa                  |
| `cidade`  | `string` | cidade da pessoa                  |
| `idade`   | `int`    | idade da pessoa                   |

#### Deleta uma pessoa

```http
  DELETE /pessoa/api/${codigo}
```

| Parâmetro | Tipo  | Descrição                                     |
| :-------- | :---- | :-------------------------------------------- |
| `codigo`  | `int` | **Obrigatório**. O ID do pessoa que você quer |

## Instalação

1 - Clone esse repositório.

2 - Abra no VS

```bash
dotnet run
```

**_Banco de dados: MySQL_**

**Pacotes utilizados**

```bash
dotnet add package Microsoft.EntityFrameworkCore --version 5.0.9
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.9
dotnet add package Pomelo.EntityFrameworkCore.MySql --version 5.0.1
```

Fonte: https://github.com/ralflima/api_aspnet_mysql#t%C3%B3picos-abordados
