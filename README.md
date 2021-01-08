# desafio-softplan

# Executar aplicação

Executar docker compose que esta na raiz. Configurado para inicializar gateway, firstapi e secondapi. Esta rodando em http://localhost:7000

Endpoiints
  API 1
    - Get
      - http://localhost:7000/firstapi/taxajuros
  API 2
    - POST
      - http://localhost:7000/api/secondapi/calculajuros?valorinicial=100&meses=5
