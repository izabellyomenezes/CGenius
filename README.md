# CGenius

## Definindo a Arquitetura da API

Optamos por desenvolver a aplicação em uma arquitetura monolítica em vez de microsserviços, devido à ausência de uma perspectiva clara de crescimento futuro. A aplicação já está praticamente completa em termos de funcionalidades, e as futuras modificações serão apenas ajustes ou melhorias nas funcionalidades já implementadas. A arquitetura monolítica oferece maior simplicidade no desenvolvimento e nos testes, facilitando a integração entre os componentes, reduzindo a complexidade e tornando o desenvolvimento mais ágil e eficiente.

## CRUD da API

Para garantir o correto funcionamento do CRUD e dos relacionamentos entre as entidades, siga a ordem de criação dos registros (POST) de acordo com as dependências:

### Ordem de Postagem
1. **Atendente** (necessário para criar Venda)
2. **Plano** (necessário para criar Script)
3. **Script** (necessário para criar Cliente e Venda)
4. **Cliente** (necessário para criar Especificacao e Venda)
5. **Especificacao** (necessário para criar Venda)
6. **Venda** (última entidade, pois depende de todas as anteriores)

---

## Exemplos de JSONs para POST

### 1. Atendente
```json
{
  "cpfAtendente": "98765432100",
  "nomeAtendente": "Maria Souza",
  "setor": "Vendas",
  "senha": "senha123",
  "perfilAtendente": "Atendente Senior",
  "vendas": []
}
```

### 2. Plano
```json
{
    "NomePlano": "Plano Premium Plus",
    "DescricaoPlano": "Acesso ilimitado a todos os serviços.",
    "ValorPlano": 199.99,
    "scripts": [],
    "vendas": []
}
```

### 3. Script
```json
{
    "DescricaoScript": "Script de venda para clientes premium.",
    "IdPlano": 1
}
```

### 4. Cliente
```json
{
    "CpfCliente": "12345678900",
    "NomeCliente": "João da Silva",
    "DtNascimento": "1990-05-21",
    "Genero": "Masculino",
    "Cep": "12345678",
    "Telefone": "11987654321",
    "Email": "joao.silva@gmail.com",
    "PerfilCliente": "Cliente Premium",
    "IdScript": 1
}
```

### 5. Especificacao
```json
{
    "TipoCartaoCredito": "Black",
    "GastoMensal": 5000.00,
    "ViajaFrequentemente": true,
    "Interesses": "Tecnologia",
    "Profissao": "Engenheiro",
    "RendaMensal": 10000.00,
    "Dependentes": 2,
    "CpfCliente": "12345678900"
}
```



### 6. Venda
```json
{
    "CpfAtendente": "98765432100",
    "CpfCliente": "12345678900",
    "IdScript": 1,
    "IdPlano": 1,
    "IdEspecificacao": 1
}
```


## Integrantes

RM99814- Anna Soares
RM98214- Gabriel Cirilo
RM551423-Izabelly Oliveira
RM99578-Marcos Garrido
