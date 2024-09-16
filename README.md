# AP-BK-GestaoImobiliaria
### História de John Wick e sua Imobili?ria em Lages

---

**Cen?rio:**

John Wick, depois de uma longa carreira em Nova York, decidiu se estabelecer em Lages, uma cidade tranquila e charmosa no sul do Brasil. Com uma vista para as montanhas e um clima acolhedor, Lages parecia o lugar perfeito para come?ar de novo. Ao caminhar pelas ruas hist?ricas da cidade, John percebeu o potencial do mercado imobili?rio local e decidiu abrir uma imobili?ria. Assim nasceu a **Wick Realty Lages**, uma empresa focada em im?veis de alto padr?o e em proporcionar um servi?o personalizado para seus clientes.

Para garantir que sua imobili?ria fosse um sucesso, John precisava de um sistema de gest?o moderno e eficiente. Ele queria algo que fosse t?o bem organizado quanto ele, sem espa?o para erros ou dados desnecess?rios. Ele convocou sua equipe de desenvolvedores e explicou sua vis?o para o sistema:

?Precisamos de um sistema que garanta a precis?o e a integridade dos dados. Cada im?vel deve ter um corretor respons?vel e um cliente como dono. Al?m disso, n?o quero dados duplicados. Se um cliente j? est? registrado ou um im?vel j? foi cadastrado, o sistema deve alertar sobre isso. E mais, quero que meus corretores possam entrar em contato com clientes que favoritaram im?veis que eles gerenciam, para que possamos ser proativos na prospec??o.?

---

### Requisitos Funcionais do Sistema de Gest?o da Wick Realty Lages

1. **Gest?o de Im?veis**:
   - **Cadastro de Im?veis**: O sistema deve permitir o cadastro de novos im?veis, incluindo detalhes como endere?o, tipo (casa, apartamento, terreno), ?rea em metros quadrados, valor de venda ou loca??o, e uma descri??o detalhada. Al?m disso, ? obrigat?rio que cada im?vel tenha um corretor respons?vel e um cliente como dono. Esses campos n?o podem ser deixados em branco.
   - **Edi??o e Exclus?o de Im?veis**: A equipe precisa editar os detalhes de im?veis existentes e excluir aqueles que n?o est?o mais dispon?veis. Durante a edi??o, o sistema deve verificar se h? duplica??o de informa??es, como endere?os j? cadastrados.
   - **Visualiza??o de Im?veis**: Deve ser poss?vel visualizar uma lista de im?veis com filtros por tipo, valor, localiza??o e disponibilidade. A lista deve indicar claramente o corretor respons?vel por cada im?vel.
   - **Upload de Fotos**: Cada im?vel deve ter a op??o de upload de fotos, permitindo que os clientes vejam detalhes visuais dos im?veis.
   - **Controle de Duplica??o**: Ao cadastrar um im?vel, o sistema deve verificar se j? existe um im?vel com o mesmo endere?o ou descri??o. Em caso afirmativo, deve alertar o usu?rio e impedir o cadastro duplicado.

2. **Gest?o de Clientes**:
   - **Cadastro de Clientes**: O sistema deve permitir o cadastro de clientes com informa??es como nome, CPF (?nico), telefone, e-mail e suas prefer?ncias de im?vel. O CPF deve ser ?nico e obrigat?rio.
   - **Edi??o e Exclus?o de Clientes**: A equipe deve poder atualizar as informa??es dos clientes e remover registros quando necess?rio. O sistema deve garantir que n?o haja CPFs duplicados.
   - **Hist?rico de Intera??es**: Cada cliente deve ter um hist?rico de intera??es, incluindo im?veis visualizados e contatos feitos.

3. **Gest?o de Corretores**:
   - **Cadastro de Corretores**: Deve ser poss?vel cadastrar corretores, incluindo nome, CPF (?nico), registro CRECI, telefone e e-mail. Cada corretor ser? respons?vel por um conjunto de im?veis, e o sistema deve impedir CPFs ou CRECIs duplicados.
   - **Atribui??o de Im?veis**: Corretores precisam ser atribu?dos a im?veis espec?ficos. Um im?vel n?o pode ser cadastrado sem um corretor respons?vel. A aplica??o deve permitir que os gestores da imobili?ria atribuam ou reatribuam corretores a im?veis conforme necess?rio.
   - **Prospec??o de Im?veis**: Corretores devem ter acesso ? lista de clientes que favoritaram im?veis sob sua gest?o. Eles podem entrar em contato diretamente com esses clientes para discutir mais detalhes e potencialmente fechar neg?cios.

4. **Perfil de Cliente**:
   - **Visualiza??o de Im?veis Dispon?veis**: Clientes logados podem visualizar uma lista de im?veis dispon?veis para venda ou loca??o, com filtros por tipo, valor, localiza??o e outros crit?rios relevantes.
   - **Detalhes do Im?vel**: Clientes podem acessar uma p?gina de detalhes do im?vel, que inclui uma descri??o completa, fotos, pre?o, e dados de contato do corretor respons?vel.
   - **Favoritar Im?veis**: Clientes podem marcar im?veis como favoritos. A lista de im?veis favoritos ? acess?vel no perfil do cliente e ser? usada pelos corretores para prospec??o.
   - **Entrar em Contato**: Os clientes podem enviar mensagens diretamente aos corretores a partir da p?gina de detalhes do im?vel, solicitando mais informa??es ou agendando visitas.

5. **Seguran?a e Autentica??o**:
   - **Autentica??o de Usu?rios**: O sistema deve incluir um mecanismo de login seguro para corretores e clientes. Somente usu?rios autenticados podem acessar funcionalidades sens?veis.
   - **Controle de Acesso**: Deve haver diferentes n?veis de acesso para garantir que corretores possam gerenciar seus im?veis e clientes, enquanto os clientes s? t?m acesso ?s funcionalidades de visualiza??o e contato.

6. **Relat?rios e An?lises**:
   - **Relat?rios de Vendas e Loca??o**: John quer relat?rios que mostrem o desempenho da imobili?ria, incluindo n?mero de vendas e loca??es por per?odo, e desempenho de cada corretor.
   - **An?lise de Prefer?ncias de Clientes**: O sistema deve gerar an?lises sobre as prefer?ncias dos clientes, como tipos de im?veis mais procurados, faixas de pre?o e localiza??es mais populares.

7. **Perfil Anonimo**:

   - Visualizar 5 imoveis recentes.
   - Espa?o para cria??o de usuario.

### Tecnologias Utilizadas
- **Backend**: ASP.NET Core, C#
- **Frontend**: ASP.NET MVC, HTML, CSS
- **Banco de Dados**: SQL Server
- **ORM**: Entity Framework Core
- **Autentica??o**: Iremos construir nossa pr?pria autentica??o por cookie

### Estrutura em Camadas (N-layer)
1. **Camada de Apresenta??o (Presentation Layer)**:
   - Respons?vel pela interface do usu?rio, utilizando  MVC Views, interage com a camada de dominio.
   
2. **Camada de Dom?nio (Domain Layer)**:

   - Cont?m a l?gica de neg?cio e os servi?os, como valida??es e regras espec?ficas
   - Modelos de dom?nio e regras de neg?cios centrais.

3. **Camada de acceso a dados DAO(Data Access Object) **:
   - Intera??o com o banco de dados atrav?s do Entity Framework Core.
	
4. **Testes**
   
  - Local para realizar testes da solu??o, unitario, integra??o e automa??o.
  - Iremos usar xunit 

5. **Docs**

  - Pasta de documenta??o, como scripts de banco

Comando para gerar modelos de classe baseado nas tabelas.

  dotnet ef dbcontext scaffold "Server=localhost,1433;Database=ImobiliariaDB;User Id=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer 
