# Projeto de Integração RabbitMQ com .NET 8

Este repositório demonstra o uso do pacote **Thiagosza.RabbitMq.Worker** para implementar consumidores (consumers) e produtores (producers) de mensagens utilizando o RabbitMQ em dois tipos de projetos:
- **WebApi**: responsável por produzir e consumir mensagens.
- **Worker Service**: responsável por consumir mensagens em background.

## Tecnologias Utilizadas

- .NET 8
- RabbitMQ
- Docker Compose
- Thiagosza.RabbitMq.Worker (pacote para facilitar integração com RabbitMQ)

## Estrutura do Projeto

- **WebApi**: expõe endpoints que publicam mensagens no RabbitMQ.
- **Worker**: implementa consumers usando o `BackgroundService` para processar mensagens recebidas do RabbitMQ.

## Como executar o projeto

### 1. Clonar o repositório
```bash
git clone <url-do-repositorio> 
cd <nome-do-repositorio>
```

### 2. Subir o RabbitMQ com Docker Compose

Certifique-se de ter o Docker instalado. Execute o comando abaixo na raiz do projeto:

```bash
docker-compose up -d
```


O RabbitMQ estará disponível em:
- Porta 5672 (conexão de aplicações)
- Porta 15672 (painel de administração: http://localhost:15672, usuário/senha: admin/passw123)

### 3. Configurar e rodar os projetos

- Atualize as configurações de conexão do RabbitMQ em `appsettings.json` se necessário.
- Execute o projeto **WebApi** para enviar mensagens.
- Execute o projeto **Worker** para consumir/processar as mensagens.


## Observações

- O pacote **Thiagosza.RabbitMq.Worker** simplifica a configuração de producers e consumers, integrando facilmente com o pipeline do .NET.
- Consulte os arquivos de código para exemplos de implementação de consumers e producers.

---
