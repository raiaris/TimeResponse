# TimeResponse
## API para controle de tempo de inserção de videos.

Primeiramente peço perdão pelos commits, tive bastante problema com o tempo devido ao meu trabalho atual e o
banco local tendo que alterar a versão do dotnet para adaptar 
para o desafio.
### Condfiguração
* 
  * Instalar o dotnet versão 2.2 caso não tenha instalado, que se encontra nesse link.
   > https://dotnet.microsoft.com/download/dotnet-core/2.2
* 
  * Executar o comando via terminal para iniciar a API localmente na maquina.
   > dotnet run
### Testes
* 
  * Todos os metodos solicitados (e uns que fiz de padrão) estão no Swagger da api nesse link local na maquina.
   > http://localhost:5000/api
* 
  *  Testar todos os metodos na ordem:
  *  Post api/Video : Onde voce pode inserir os dados do novo video. O timestamp pode ser gerado nesse link que me ajudou
     bastante nos testes realizados para gerar a conversão do metodo de tempo.
     > https://www.unixtimestamp.com/index.php
  *  Get api/Video : Nesse metodo retornamos todos os video inseridos no documento. (Não foi solicitado porém achei valido para
     testes do Banco Local)
  *  Delete api/Video : Deleta os videos, não precisa passar a ID.
* 
  * Gerar as estatisticas de retorno contendo os dados dos ultimos segundos inseridos. Essa parte foi complicada devido a conversão
    de valores de timestamp pra datetime para gerar o calculo necessario dos 60 segundos.
  * Após a inclusão de dados de videos podemos testar o Get api/Statistics onde pelo teste ele retorna os dados solicitados.
    
### Considerações
 Foi uma das primeiras API's que fiz, tem alguns defeitos pelo falta de tempo e falta de experiência maior. Começei a utilizar C#
 a pouco tempo e estou focando na parte de Back-End, busco a oportunidade de entrar na área e me desenvolver e dedicar a cada dia 
 mais.
