# Sistema de Reservas Resort Solari - DIO .NET

Projeto desenvolvido como parte do Bootcamp Avanade - Back-end com .NET e IA.

---
Desenvolvido para um Resorte de reservas de hotel com diferentes tipos de suítes e cálculo de valores.

## 💡 Visão Geral

O Resort Solari é um estabelecimento que preza pela excelência em hospitalidade, seguindo o lema "Viva o agora, respire o sempre". O sistema foi desenvolvido para gerenciar reservas, hóspedes e suítes, oferecendo uma experiência completa de gestão hoteleira.

## 📋 Funcionalidades Implementadas

- **Gestão de Suítes**
  - Cadastro de diferentes tipos de suítes
  - Definição de capacidade máxima
  - Precificação por diária

- **Sistema de Reservas**
  - Validação de capacidade da suíte
  - Cálculo automático do valor total
  - Desconto de 10% para estadias de 10 ou mais dias
  - Registro completo dos hóspedes

- **Gestão de Hóspedes**
  - Cadastro com nome e sobrenome
  - Validação da quantidade de hóspedes por suíte
  - Listagem de hóspedes por reserva

- **Histórico e Relatórios**
  - Resumo detalhado das reservas
  - Informações dos hóspedes
  - Valores e períodos de estadia
  
## ⚙️ Estrutura do Projeto
Este é um projeto de um sistema de gerenciamento hoteleiro desenvolvido em C# (.NET 8.0), que simula o funcionamento de um resort com diferentes tipos de suítes e cálculo de valores.

### Principais Classes:

**1. Pessoa**
- Propriedades para Nome e Sobrenome
- Representa os hóspedes do hotel

**2. Suite**
- Tipo da Suíte
- Capacidade máxima de hóspedes
- Valor da diária

**3. Reserva**
- Lista de hóspedes
- Suíte reservada
- Quantidade de dias
- Métodos para:
  - Cadastrar hóspedes
  - Calcular valor da diária
  - Obter quantidade de hóspedes
  - Validar capacidade da suíte

**4. HistoricoReservas**
- Gerenciamento de todas as reservas
- Cálculo de faturamento
- Exibição de resumos

### Regras de Negócio:

1. **Validação de Capacidade**
   - Não permite reservas com mais hóspedes que a capacidade da suíte

2. **Política de Descontos**
   - 10% de desconto para estadias de 10 ou mais dias

3. **Cálculo de Valores**
   - Valor base: Diária × Quantidade de dias
   - Aplicação automática de descontos quando aplicável
### Boas Práticas Implementadas

- **Orientação a Objetos**
  - Classes bem definidas e coesas
  - Encapsulamento apropriado
  - Validações robustas

- **Interface do Usuário**
  - Menu interativo e intuitivo
  - Feedback claro ao usuário
  - Formatação elegante das informações

- **Manutenibilidade**
  - Código organizado e limpo
  - Métodos bem definidos
  - Fácil extensibilidade

## 🖥️ Demonstração do Sistema

### 1. Menu Principal
![Menu Principal](https://github.com/ItaloRochaj/trilha-net-desafio-hospedagem/blob/v1.1/Images/Assets/resorte1.png)
<<<<<<< HEAD
*Tela inicial do sistema com as opções de reserva*

### 2. Cadastro de Reserva
![Cadastro de Reserva](https://github.com/ItaloRochaj/trilha-net-desafio-hospedagem/blob/v1.1/Images/Assets/resorte2.png)
*Interface de cadastro com informações da suíte e hóspedes*

### 3. Resumo da Reserva
![Resumo da Reserva](https://github.com/ItaloRochaj/trilha-net-desafio-hospedagem/blob/v1.1/Images/Assets/resorte3.png)
*Detalhes da reserva com valores e informações dos hóspedes*
=======
*Tela inicial do sistema com as opções disponíveis*

### 2. Cadastro de Veículo
![Adicionar Veículo](https://github.com/ItaloRochaj/trilha-net-desafio-hospedagem/blob/v1.1/Images/Assets/resorte2.png)
*Interface de cadastro com informações do veículo*

### 3. Seleção do Tipo de Vaga
![Tipo de Vaga](https://github.com/ItaloRochaj/trilha-net-desafio-hospedagem/blob/v1.1/Images/Assets/resorte3.png)
*Escolha entre vaga rotativa ou reservada*
>>>>>>> fead25a0e2b75c479210ca93af2f5fcb8a813353

## 🛠️ Tecnologias

- C# (.NET 8.0)
- Orientação a Objetos
- Visual Studio Code
- Git/GitHub
  
## ⚙️ Como Executar

1. Clone o repositório:
   ```bash
   git clone https://github.com/ItaloRochaj/trilha-net-desafio-hospedagem.git
   ```

2. Navegue até a pasta do projeto:
   ```bash
   cd trilha-net-desafio-hospedagem
   ```

3. Execute o projeto:
   ```bash
   dotnet run --project DesafioProjetoHospedagem.csproj
   ```


## 🎯 Principais Características

### Classes Principais

- **Suite**
  - Tipo e capacidade da suíte
  - Valor da diária
  - Validações de ocupação

- **Reserva**
  - Gestão de hóspedes
  - Cálculo de valores
  - Aplicação de descontos
  - Validações de capacidade

- **HistoricoReservas**
  - Gerenciamento de reservas
  - Cálculo de faturamento
  - Relatórios e resumos

### Especificações Técnicas

- Interface via console interativa
- Validações robustas de entrada
- Cálculos precisos de valores
- Uso de estruturas como `if/else`, `foreach` e `List<T>`
- Implementação orientada a objetos
- Tratamento de exceções

### 👨🏻‍💻 Autor:
<table style="border=0">
  <tr>
    <td align="left">
      <a href="https://github.com/ItaloRochaj">
        <span><b>Italo Rocha</b></span>
      </a>
      <br>
      <span>Full-Stack Development</span>
    </td>
  </tr>
</table>

---
<div align="center">Desenvolvido com 👽 por <a href="https://github.com/ItaloRochaj">Italo Rocha</a></div>
