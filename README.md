# 🏨 Sistema de Reservas Resort Solari - Trilha .NET DIO

![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=dotnet)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![Console App](https://img.shields.io/badge/Console-Application-0078D4?style=for-the-badge&logo=windows-terminal&logoColor=white)
![OOP](https://img.shields.io/badge/OOP-Programming-FF6B6B?style=for-the-badge)

## 🎯 Visão Geral

Este projeto é um **Sistema Completo de Gerenciamento de Reservas Hoteleiras** desenvolvido como parte do **Bootcamp Avanade - Back-end com .NET e IA**. O Resort Solari segue o lema "Viva o agora, respire o sempre" e oferece uma solução robusta para gestão de hospedagem com diferentes tipos de suítes, validações de capacidade e cálculo inteligente de valores.

## ⚡ Funcionalidades Implementadas

### 🏨 Gestão de Reservas
- ✅ **Criar reserva** - Sistema interativo de cadastro de reservas
- ✅ **Cadastro de suítes** - Definição de tipos, capacidade e valores
- ✅ **Gestão de hóspedes** - Registro completo com nome e sobrenome
- ✅ **Validação de capacidade** - Impede reservas além da capacidade da suíte
- ✅ **Cálculo automático** - Valores com desconto para estadias longas

### 🧮 Sistema de Precificação
- ✅ **Valor por diária** - Cálculo baseado em dias × valor da suíte
- ✅ **Desconto automático** - 10% de desconto para 10+ dias de estadia
- ✅ **Validação de dados** - Verificação de entradas do usuário
- ✅ **Relatórios detalhados** - Resumos com informações completas

### 📊 Validações e Regras de Negócio
- ✅ **Capacidade obrigatória** - Não permite mais hóspedes que a capacidade
- ✅ **Dados obrigatórios** - Validação de nome, sobrenome e informações da suíte
- ✅ **Cálculos precisos** - Aplicação correta de descontos e valores
- ✅ **Interface intuitiva** - Mensagens claras e feedback ao usuário
  
## 🏗️ Estrutura do Projeto

```
DesafioProjetoHospedagem/
├── 📁 Models/
│   ├── Pessoa.cs                      # Modelo para hóspedes
│   ├── Suite.cs                       # Modelo de suítes do hotel
│   ├── Reserva.cs                     # Modelo principal de reservas
│   └── HistoricoReservas.cs           # Gestão do histórico
├── 📁 bin/
│   └── Debug/net8.0/                  # Arquivos compilados
├── 📁 obj/                            # Arquivos de compilação
├── Program.cs                         # Programa principal com interface
├── DesafioProjetoHospedagem.csproj    # Configuração do projeto
├── trilha-net-desafio-hospedagem.sln  # Solução do Visual Studio
├── diagrama_classe_hotel.png          # Diagrama de classes
└── README.md                          # Documentação do projeto
```

## 🎯 Regras de Negócio

### 🏨 Modelo de Reserva
- **Suite**: Tipo, capacidade e valor da diária
- **Hóspedes**: Lista com nome e sobrenome completos
- **Dias**: Quantidade de dias da reserva
- **Valor Total**: Cálculo automático com possível desconto

### ⚖️ Validações Implementadas
1. **Capacidade da suíte**: Não permite reservas com mais hóspedes que a capacidade
2. **Dados obrigatórios**: Nome, sobrenome e informações da suíte são requeridos
3. **Desconto automático**: 10% de desconto para estadias de 10 ou mais dias
4. **Cálculo de valores**: Dias × valor da diária com aplicação de descontos
5. **Interface validada**: Verificação de entradas numéricas e textos
## 🛠️ Boas Práticas Implementadas

### 🏛️ Arquitetura
- ✅ **Orientação a Objetos** - Classes bem definidas e coesas
- ✅ **Encapsulamento** - Propriedades protegidas apropriadamente
- ✅ **Validações robustas** - Tratamento de exceções personalizado
- ✅ **Separação de responsabilidades** - Cada classe com propósito específico

### 📝 Interface do Usuário
- ✅ **Menu interativo** - Navegação intuitiva via console
- ✅ **Feedback claro** - Mensagens informativas ao usuário
- ✅ **Formatação elegante** - Apresentação organizada das informações
- ✅ **Tratamento de erros** - Respostas consistentes para entradas inválidas

### 🔧 Manutenibilidade
- ✅ **Código limpo** - Nomenclatura clara e consistente
- ✅ **Métodos bem definidos** - Funções com responsabilidades específicas
- ✅ **Fácil extensibilidade** - Estrutura preparada para novos recursos
- ✅ **Documentação interna** - Comentários e estrutura autodocumentada

## 🚀 Tecnologias Utilizadas

### 🎨 Framework e Runtime
- **.NET 8.0** - Framework principal
- **C#** - Linguagem de programação
- **Console Application** - Interface via terminal

### 🗄️ Estrutura de Dados
- **List<T>** - Coleções genéricas para hóspedes
- **Decimal** - Precisão monetária para valores
- **DateTime** - Controle de datas (futuro)

### 🛠️ Ferramentas de Desenvolvimento
- **Visual Studio Code** - IDE principal
- **Git** - Controle de versão
- **PowerShell** - Terminal de execução

## 🖥️ Demonstração do Sistema

### 📸 Interface do Sistema

O sistema possui uma interface completa via console com menu interativo:

![Menu Principal](https://github.com/ItaloRochaj/trilha-net-desafio-hospedagem/blob/v1.1/Images/Assets/resorte1.png)
*Menu principal do Resort Solari com opções de reserva*

![Cadastro de Reserva](https://github.com/ItaloRochaj/trilha-net-desafio-hospedagem/blob/v1.1/Images/Assets/resorte2.png)
*Interface de cadastro com informações da suíte e hóspedes*

![Resumo da Reserva](https://github.com/ItaloRochaj/trilha-net-desafio-hospedagem/blob/v1.1/Images/Assets/resorte3.png)
*Detalhes da reserva com valores e informações dos hóspedes*

### 🎮 Funcionalidades do Menu

| Opção | Funcionalidade | Descrição |
|-------|----------------|-----------|
| `1` | **Fazer nova reserva** | Cadastro completo de suíte e hóspedes |
| `2` | **Ver resumo das reservas** | Listagem detalhada com valores |
| `3` | **Sair** | Encerramento do sistema |

### 📝 Exemplo de Fluxo de Reserva

```
1. Definir tipo da suíte (ex: "Luxo")
2. Informar capacidade (ex: 2 pessoas)
3. Definir valor da diária (ex: R$ 200,00)
4. Informar quantidade de dias (ex: 12 dias)
5. Cadastrar hóspedes (nome e sobrenome)
6. Sistema calcula automaticamente com desconto de 10%
```

## � Como Executar

### 📋 Pré-requisitos
- .NET 8.0 SDK instalado
- Visual Studio Code ou Visual Studio
- PowerShell ou terminal compatível
- Git (opcional)

### 🔧 Passos para Execução

1. **Clone o repositório**
```bash
git clone https://github.com/ItaloRochaj/trilha-net-desafio-hospedagem.git
cd trilha-net-desafio-hospedagem
```

2. **Restaure as dependências**
```bash
dotnet restore
```

3. **Compile o projeto**
```bash
dotnet build
```

4. **Execute a aplicação**
```bash
dotnet run --project DesafioProjetoHospedagem.csproj
```

### ⚡ Execução Rápida
```bash
# Para execução direta
dotnet run --project DesafioProjetoHospedagem.csproj

# Para desenvolvimento com rebuild automático
dotnet watch run --project DesafioProjetoHospedagem.csproj
```

## 🎯 Principais Características

### 🔥 Performance
- ✅ **Execução rápida** - Aplicação console otimizada
- ✅ **Baixo consumo** - Operações em memória eficientes
- ✅ **Inicialização instantânea** - Sem dependências externas

### 🛡️ Robustez
- ✅ **Tratamento de erros** - Exceções personalizadas e informativas
- ✅ **Validações completas** - Verificação de todos os dados de entrada
- ✅ **Cálculos precisos** - Uso de decimal para valores monetários

### 🎨 Usabilidade
- ✅ **Interface intuitiva** - Menu claro e navegação simples
- ✅ **Feedback imediato** - Confirmações e alertas em tempo real
- ✅ **Formatação elegante** - Apresentação organizada dos dados

### 🔧 Manutenibilidade
- ✅ **Código limpo** - Padrões consistentes de nomenclatura
- ✅ **Estrutura modular** - Classes com responsabilidades bem definidas
- ✅ **Fácil extensão** - Arquitetura preparada para novos recursos

## 📈 Melhorias Futuras

- 🗄️ Persistência em banco de dados
- 🌐 Interface web ou API
- 📊 Relatórios avançados e estatísticas
- 🔐 Sistema de autenticação
- 📧 Notificações por email
- 💳 Integração com sistemas de pagamento
- 🌍 Suporte a múltiplos idiomas
- 📱 Aplicação mobile

## 👨🏻‍💻 Autor

**Ítalo Rocha**
- 🌐 GitHub: [@ItaloRochaj](https://github.com/ItaloRochaj)
- 💼 LinkedIn: [https://www.linkedin.com/in/italorochaj/]

---

## 📄 Licença

Este projeto foi desenvolvido como parte do **Bootcamp Avanade - Back-end com .NET e IA** e é distribuído sob a licença MIT.

---

*Desenvolvido com � e ☕ por [Ítalo Rocha](https://github.com/ItaloRochaj)*
