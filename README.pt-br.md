# Unity Code Workflow

 O objetivo deste projeto é armazenar e compartilhar ideias e/ou práticas na codificação em C# para Unity que facilitam o desenvolvimento de projetos nesta engine.

 ## Organização das pastas

 As pastas devem ser organizadas conforme a necessidade do projeto, mas na maioria dos casos não fogem de duas possibilidades:

 - Pastas separadas por tipos de arquivos
 - Pastas separadas por aglomerados de conteúdo.

 É interessante numerar as pastas por ordem de imposrtância fazendo com que assim, as pastas mais importantes fiquem enfileirados em sua respectiva ordem.

 ### Pastas por tipo de arquivos:

 As pastas separadas por tipos de arquivos são organizadas geralmente nomeando-as em referência ao seu tipo ou extensão de arquivo.

  #### Ordem
 
```text
> 01-Scenes
> 02-Scrips
v 03-2D
    > Atlas
    v Images
        > Maps
        > SpritSheets
        > UI
v 04-3D
    > FBX
    > OBJ
v 05-Sounds
    > MP3
> 06-Animations
> 07-Prefabs
```

 #### Vantagens

 As pastas separadas por tipos de arquivos permite uma organização maior já que há uma facilidade em inserir um arquivo novo em uma pasta já existente - na maioria das vezes -  e também, é bem intuitivo em se localizar um arquivo pelo tipo já que a maioria desses arquivos encontram-se em sua pasta pré determinada.

 #### Desvantagens

A sua vantagem também é a sua desvantagem! Já que os arquivos devem ser separadas por tipos, dependendo do tamanho do projeto, pode se tornar um pouco massante sempre que se cria ou insere um arquivo novo, já que é preciso navegar entre as pastas para alocar o arquivo de forma organizada.

### Pastas por conteúdo

#### Vantagens

A principal vantagem se se organizar os arquivos por conteúdo é 