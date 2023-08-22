# Cabeçalhos

## Título 2

### Título 3

#### Título 4

##### Título 5

###### Título 6

Título 1
========

Título 2
--------

# Título 1 #

## Título 2 ##

<hr>

# Parágrafos

Lorem ipsum dolor sit amet, consectetur adipiscing elit.

# Título

Lorem ipsum dolor sit amet, consectetur adipiscing elit. Lorem ipsum dolor sit amet, consectetur adipiscing elit.  
Lorem ipsum dolor sit amet, consectetur adipiscing elit.

Lorem ipsum dolor sit amet, consectetur adipiscing elit.

<hr>

# Ênfase

## Negrito 1

**Lorem** ipsum dolor sit amet, consectetur.

## Negrito 2

__Lorem__ ipsum dolor sit amet, consectetur.

## Itálico 1

*Lorem* ipsum dolor sit amet, consectetur.

## Itálico 2

_Lorem_ ipsum dolor sit amet, consectetur.

# Negrito e Itálico 1

**_Lorem_** ipsum dolor sit amet, consectetur.

# Negrito e Itálico 2

__*Lorem*__ ipsum dolor sit amet, consectetur.

# Riscado

~~Lorem~~ ipsum dolor sit amet, consectetur.

# Citação

> Lorem ipsum dolor sit amet, consectetur.

# Citação com negrito e itálico

> **Lorem** _ipsum_ dolor sit amet, consectetur.  


<hr>


# Linhas horizontais

## Exemplo 1

***
---

## Exemplo 2

* * *
- - -

## Exemplo 3

********************
--------------------


<hr>


# Listas não-ordenadas 1

* Item 01
* Item 02
* Item 03

# Listas não-ordenadas 2

- Item 01
- Item 02
- Item 03

# Listas não-ordenadas 3

+ Item 01
+ Item 02
+ Item 03

# Listas não-ordenadas 4

* Item 01
  + Subitem 01
  + Subitem 02
  + Subitem 03
* Item 02
* Item 03

# Listas não-ordenadas 5

* Item 01

* Item 02

* Item 03


<hr>


# Listas ordenadas 1

1. Item 01
2. Item 02
3. Item 03

# Listas ordenadas 2

1. Item 01
1. Item 02
1. Item 03

# Listas ordenadas 3

8. Item 01
5. Item 02
3. Item 03

# Listas ordenadas 4

1994\. Brasil  
1998\. França  
2002\. Brasil


<hr>


# Links

## Link 1

[Clique aqui](https://showmethecode.com.br)

## Link 2

[Show Me The Code](https://showmethecode.com.br "Blog")

## Link 3

[Clique aqui][site-url]

[site-url]: https://showmethecode.com.br


<hr>


# Imagens

## Imagem 1

![Markdown](images/photo.png)

## Imagem 2

![Markdown][image]

[image]: images/photo.png

## Imagem com link 1

[![Markdown](images/photo.png)](https://showmethecode.com.br)

## Imagem com link 2

[![Markdown][image-thumbs]][image-url]

[image-thumbs]: images/photo.png
[image-url]: https://showmethecode.com.br


<hr>

# Tabelas

# Exemplo 1

| Nome | Idade |
| ---- | ----- |
| Roberto | 36 |

# Exemplo 2

| Nome | Idade | Profissão |
| ---- | ----- | --------- |
| Roberto | 36 | Analista de Sistemas |
| Rodrigo | 35 | Professor |
| Renan | 33 | Músico |

# Exemplo 3

| Nome | Idade | Profissão |
| :--- | :---: | --------: |
| Roberto | 36 | Analista de Sistemas |
| Rodrigo | 35 | Professor |
| Renan | 33 | Músico |


<hr>

# Códigos

# Exemplo em linha

Informe os parâmetros `username` e `password` para a função `login()`.

``const message = `My name is ${name}`;``

# Exemplo em bloco 1

    // login.js

    const username = 'robertoachar';
    const password = 'secret';

    login(username, password);

# Exemplo em bloco 2

```
// login.js

const username = 'robertoachar';
const password = 'secret';

login(username, password);
```

# Syntax Highlighting

```javascript
// login.js

const username = 'robertoachar';
const password = 'secret';

login(username, password);
```

```js
// login.js

const username = 'robertoachar';
const password = 'secret';

login(username, password);
```

<hr>

# Lista de tarefas

* [ ] Item 1
* [ ] Item 2
* [ ] Item 3

* [x] Item 1
* [x] Item 2
* [x] Item 3

* [X] Item 1
* [X] Item 2
* [X] Item 3

# Issues e PR

#1

# Pessoas

@coveralls

# Emojis

:smile: :+1: :shit:

[Emoji Cheat Sheet](http://www.emoji-cheat-sheet.com/)


<hr>

# Mundo Real
# OSS Project Generator

[![Travis Status][travis-badge]][travis-url]
[![AppVeyor Status][appveyor-badge]][appveyor-url]
[![CircleCI Status][circleci-badge]][circleci-url]
[![Coveralls Status][coveralls-badge]][coveralls-url]
[![NPM Version][npm-badge]][npm-url]
[![License][license-badge]][license-url]

> Yeoman generator for open source projects.

This generator provides the following features:

* **src** and **test** folder as a starter point to build your project.
* **EditorConfig** to help you define and maintain consistent coding styles between different editors.
* **ESLint** to provide a pluggable linting utility for JavaScript.
* **Jest** as a complete and easy to set-up JavaScript testing solution used by Facebook.
* **Travis** and **CircleCI** as a continuous integration and delivery platform.
* **Appveyor** as a continuous delivery service for Windows.
* **Coveralls** to help you track your code coverage over time, and ensure that all your new code is fully covered.
* **README.md** and **CHANGELOG.md** with information about the project, installation, usage, development, author and license.
* **Badges** for Travis, Appveyor, CircleCI, Coveralls, NPM and License.

## Project files

```text
.
|--- src
|    |--- index.js
|--- test
|    |--- test.js
|--- .editorconfig
|--- .eslintignore
|--- .eslintrc
|--- .gitattributes
|--- .gitignore
|--- .npmrc
|--- .travis.yml
|--- appveyor.yml
|--- CHANGELOG.md
|--- circle.yml
|--- LICENSE
|--- package.json
|--- README.md
```

## Installation

* Install Yeoman

```bash
$ npm install -g yo
```

* Install Generator

```bash
$ npm install -g generator-oss-project
```

## Usage

* Creating a project

```bash
# Create a directory for your project
$ mkdir awesome-project

# Change into directory
$ cd awesome-project

# Generate a project
$ yo oss-project
```

* Running project

Action | Usage
---    | ---
Starting development mode                | `npm start`
Linting code                             | `npm run lint`
Running unit tests                       | `npm run jest`
Running code coverage                    | `npm run coverage`
Running lint + tests                     | `npm test`
Sending coverage results to Coveralls.io | `npm run coveralls`

## Development

### Prerequisites

* Install [Node.js](https://nodejs.org)
* Install [npm](https://www.npmjs.com/)
* Install Yeoman CLI

```bash
$ npm install -g yo
```

### Clone the repo

```bash
$ git clone https://github.com/robertoachar/generator-oss-project.git
```

### Run generator

```bash
# Change into directory
$ cd generator-oss-project

# Link generator
$ npm link

# Run generator
$ yo oss-project
```

## Author
[Roberto Achar](https://twitter.com/robertoachar)

## License
[MIT](https://github.com/robertoachar/generator-oss-project/blob/master/LICENSE)

[travis-badge]: https://travis-ci.org/robertoachar/generator-oss-project.svg?branch=master
[travis-url]: https://travis-ci.org/robertoachar/generator-oss-project

[appveyor-badge]: https://ci.appveyor.com/api/projects/status/github/robertoachar/generator-oss-project?branch=master&svg=true
[appveyor-url]: https://ci.appveyor.com/project/robertoachar/generator-oss-project

[circleci-badge]: https://circleci.com/gh/robertoachar/generator-oss-project/tree/master.svg?style=shield
[circleci-url]: https://circleci.com/gh/robertoachar/generator-oss-project

[coveralls-badge]: https://coveralls.io/repos/github/robertoachar/generator-oss-project/badge.svg?branch=master
[coveralls-url]: https://coveralls.io/github/robertoachar/generator-oss-project?branch=master

[npm-badge]: https://img.shields.io/npm/v/generator-oss-project.svg
[npm-url]: https://www.npmjs.com/package/generator-oss-project

[license-badge]: https://img.shields.io/github/license/robertoachar/generator-oss-project.svg
[license-url]: https://opensource.org/licenses/MIT