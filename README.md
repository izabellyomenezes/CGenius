# CGenius

CGenius é um sistema avançado para gerenciar transações, autenticação e modelos preditivos, utilizando princípios modernos de desenvolvimento de software e Inteligência Artificial Generativa. O projeto integra IA para análise de texto, autenticação JWT e processamento de pagamentos com Stripe.

## Funcionalidades Principais

1. **Inteligência Artificial Generativa**
   - O sistema utiliza o ML.NET para criar um modelo de aprendizado de máquina que analisa texto e fornece previsões.
   - **Exemplo de Uso**: O serviço `MLModelService` recebe entradas de texto e retorna uma pontuação preditiva.

2. **Autenticação JWT**
   - Autenticação segura usando tokens JWT.
   - **Endpoint**: `api/Auth/login` para gerar tokens JWT válidos por 30 minutos.

3. **Processamento de Pagamentos**
   - Integração com a API Stripe para criar pagamentos seguros e gerenciar transações.
   - **Exemplo de Uso**: O serviço `PaymentService` gera um `ClientSecret` para realizar pagamentos.

## Tecnologias Utilizadas

- **.NET 6**
- **ML.NET** para modelos de aprendizado de máquina.
- **Entity Framework Core** com banco de dados Oracle.
- **JWT** para autenticação segura.
- **Stripe API** para processamento de pagamentos.
- **xUnit** para testes.

## Pagamento com Stripe

Para pagamentos, o PaymentService utiliza a API do Stripe, configurado no arquivo appsettings.json.

## Testes
O projeto CGenius possui testes automatizados que garantem a qualidade do código e a confiabilidade das funcionalidades:

**Tipos de Testes**

- Testes Unitários (UnitTests.cs)
Verificam a lógica de negócio em isolamento.
Framework: xUnit

- Testes de Integração (IntegrationTests.cs)
Garantem que os diferentes componentes do sistema funcionam corretamente juntos.
Testes incluem interações com o banco de dados e autenticação.

- Testes de Sistema (SystemTests.cs)
Validam o sistema como um todo, simulando cenários de uso real.

## Integrantes

RM99814- Anna Soares
RM98214- Gabriel Cirilo
RM551423-Izabelly Oliveira
RM99578-Marcos Garrido
