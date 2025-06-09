# Catálogo de Imóveis + Locatários (Front-end)

Este projeto é um front-end desenvolvido com **HTML**, **Bootstrap 5** e **JavaScript puro** (Vanilla JS), que se conecta a uma API REST criada em **C# (ASP.NET)** para gerenciar informações de **Imóveis** e **Locatários**.

---

## Arquivos principais

- `index.html`: Página que exibe o catálogo de imóveis cadastrados.
- `locatarios.html`: Página que mostra a lista de locatários associados aos imóveis.

---

## Funcionalidades

### index.html – Imóveis

- Exibe todos os imóveis registrados através da API (`GET /api/imoveis`)
- Permite realizar operações de:
  - Criação de novo imóvel
  - Edição de imóvel existente
  - Exclusão de imóvel
- Cada imóvel possui os seguintes campos:
  - `endereco`: texto com o endereço do imóvel
  - `valorAluguel`: valor mensal do aluguel
  - `metragem`: metragem quadrada do imóvel
- As requisições são feitas utilizando os métodos:
  - `POST /api/imoveis` (criação)
  - `PUT /api/imoveis/{id}` (edição)
  - `DELETE /api/imoveis/{id}` (remoção)

### locatarios.html – Locatários

- Exibe todos os locatários existentes (`GET /api/alugueis`)
- Também permite realizar as operações:
  - Cadastrar novo locatário
  - Editar locatário existente
  - Excluir locatário
- Campos utilizados para cada locatário:
  - `nome`
  - `sobrenome`
  - `cpf`
  - `idImovel`: ID do imóvel alugado
- Requisições:
  - `POST /api/alugueis`
  - `PUT /api/alugueis/{id}`
  - `DELETE /api/alugueis/{id}`

---

## Tecnologias utilizadas

- **HTML5**: estrutura básica das páginas.
- **Bootstrap 5.3.3**:
  - Utilizado via CDN (sem instalação local).
  - Responsável por estilização e responsividade.
  - Foram usados componentes como Navbar, Botões, Formulários e Modais.
  - Facilita o desenvolvimento rápido com visual limpo e moderno.
- **JavaScript**:
  - Faz requisições assíncronas usando `fetch`.
  - Manipula o DOM para exibir, editar e excluir dados.
  - Controla a lógica dos modais e ações dos botões.

---

## Como rodar o projeto

1. Suba a API C# localmente (por padrão em `http://localhost:5217/api`).
2. Abra o arquivo `index.html` ou `locatarios.html` diretamente no navegador.
3. Os dados da API serão carregados e exibidos automaticamente nas tabelas.

---

## Filtro (index.html)

Na página de imóveis (`index.html`), é possível filtrar os imóveis pelo campo de endereço.  
O campo de busca está localizado acima da tabela e permite digitação livre.  
À medida que o usuário digita, a tabela é atualizada dinamicamente para exibir apenas os imóveis cujo endereço contenha o texto informado (filtro por substring, sem distinção de maiúsculas/minúsculas).

---

Desenvolvido como parte de um sistema de gerenciamento básico de imóveis e locatários.
