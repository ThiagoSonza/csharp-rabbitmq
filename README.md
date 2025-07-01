# Projeto de Integra��o RabbitMQ com .NET 8

Este reposit�rio demonstra o uso do pacote **Thiagosza.RabbitMq.Worker** para implementar consumidores (consumers) e produtores (producers) de mensagens utilizando o RabbitMQ em dois tipos de projetos:
- **WebApi**: respons�vel por produzir e consumir mensagens.
- **Worker Service**: respons�vel por consumir mensagens em background.

## Tecnologias Utilizadas

- .NET 8
- RabbitMQ
- Docker Compose
- Thiagosza.RabbitMq.Worker (pacote para facilitar integra��o com RabbitMQ)

## Estrutura do Projeto

- **WebApi**: exp�e endpoints que publicam mensagens no RabbitMQ.
- **Worker**: implementa consumers usando o `BackgroundService` para processar mensagens recebidas do RabbitMQ.

## Como executar o projeto

### 1. Clonar o reposit�rio
```bash
git clone <url-do-repositorio> 
cd <nome-do-repositorio>
```

### 2. Subir o RabbitMQ com Docker Compose

Certifique-se de ter o Docker instalado. Execute o comando abaixo na raiz do projeto:

```bash
docker-compose up -d
```


O RabbitMQ estar� dispon�vel em:
- Porta 5672 (conex�o de aplica��es)
- Porta 15672 (painel de administra��o: http://localhost:15672, usu�rio/senha: admin/passw123)

### 3. Configurar e rodar os projetos

- Atualize as configura��es de conex�o do RabbitMQ em `appsettings.json` se necess�rio.
- Execute o projeto **WebApi** para enviar mensagens.
- Execute o projeto **Worker** para consumir/processar as mensagens.


## Observa��es

- O pacote **Thiagosza.RabbitMq.Worker** simplifica a configura��o de producers e consumers, integrando facilmente com o pipeline do .NET.
- Consulte os arquivos de c�digo para exemplos de implementa��o de consumers e producers.

---
