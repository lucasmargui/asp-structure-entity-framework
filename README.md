<H1 align="center">Estrutura Entity Framework</H1>
<p align="center">🚀 Projeto de criação de uma estrutura utilizando Entity Framework para referências futuras</p>

## Recursos Utilizados

* NET 4.7.0
* Entity Framework

## Alteração da String de conexão

Configurar a connectionStrings com banco de dados local onde 'name' será utilizado como referência para conexão com Entity Framework
```
Web.Config
```
```
<connectionStrings>
  <add name="Cadastro" connectionString="Data Source=(localdb)\Local;Initial Catalog=DbClientes;Integrated Security=True;" providerName="System.Data.SqlClient" />
</connectionStrings>
```
## Criação Models

### Criação do Cadastro Context

Essa classe será responsavel para criação do banco de dados com suas respectivas tabelas através do Entity Framework
```
Models/CadastroContext.cs
```
<br>
<br>

Método responsável por utilizar a connectionString de web.config para se conectar com banco e criar o banco de dados

```
  public CadastroContext():base("Cadastro")
        {

        }
```
<br>
<br>

DbSet utiliza o Model das classes para criação das tabelas 

```
public DbSet<Cliente> Clientes { get; set; }
```

### Criação do Cliente

Model que será utilizado como base para criação das tabelas através do EntityFramework e Data Annotations em CadastroContext.cs
```
Models/Cliente.cs
```


