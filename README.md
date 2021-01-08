# desafio-softplan

# Observações

Executar docker compose que esta na raiz. Configurado para inicializar gateway, firstapi e secondapi. Esta rodando em http://localhost:7000

Endpoints

API 1 - http://localhost:7000/api/firstapi/taxajuros (GET)
  
API 2 - http://localhost:7000/api/secondapi/calculajuros?valorinicial=100&meses=5 (POST)

API 2 - http://localhost:7000/api/secondapi/showmethecode (GET)

Para criar um gateway de API, foi utilizado a biblioteca Ocelot, https://github.com/ThreeMammals/Ocelot, o mesmo oferece para um Gateway de documentação do swagger

Para acessar o swagger, http://localhost:7000/swagger

Foi criado uma camada de CrossCutting para criação do serviço de chamada externas de apis, visto que a API 2 precisa executar uma consulta na API 1.
