# api_pdv_change
API responsável por entregar o troco com as menores cédulas e/ou moedas possíveis

Após subir a aplicação usando o docker-compose pelo Visual Studio ou no terminal

basta chamar a URL abaixo:
https://localhost:3200/api/change/getchange/

E passar os seguintes os parâmetros: total da venda e total dado pelo cliente

Como é exibido no Swagger;

Ex:

total da venda: 47.53
total dado pelo cliente: 50

https://localhost:3200/api/change/getchange/47.53/50