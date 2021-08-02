<img src="https://img.shields.io/static/v1?label=GitHub&message=GuilhermeYoshikawa&color=7159c1&style=for-the-badge&logo=GitHub"/>

[![NPM](https://img.shields.io/npm/l/react)](https://github.com/GuilhermeYoshikawa/tcec_proj/blob/main/LICENSE) 

<h1 align="left">Projeto da Matéria de Teoria da Computação e Compiladores</h1>

# 🚀 Sobre o projeto
O projeto consiste no desenvolvimento de uma aplicação que demonstre alguns exemplos de Autômato Finito Determinístico (AFD), implementando uma animação (como se fosse um jogo).

A aplicação conta com um Menu que permita o usuário escolher entre a execução do Case 1 (máquina de doces) e o Case 2 (elevador).

## Layout
![Image_1](https://github.com/GuilhermeYoshikawa/Assets/blob/main/Assets/Menu.PNG) 

![Image_2](https://github.com/GuilhermeYoshikawa/Assets/blob/main/Assets/MaquinaDeDoces.PNG) 

![Image_3](https://github.com/GuilhermeYoshikawa/Assets/blob/main/Assets/elevador.PNG)

# 👉 Case 1 (Máquina de Doces)
O Case 1 é uma máquina de doces que possui três tipos de doces (Doce A = R$ 6,00, Doce B = R$ 7,00 e Doce C = R$ 8,00). Podendo ser inserida somente três tipos de Nota/moeda (R$1,00, R$ 2,00 e R$ 5,00).

O usuário deverá inserir as notas/moedas e a máquina deverá permitir que o usuário compre determinado doce, caso o valor do doce escolhido seja atingido. 

Obs: o limite de dinheiro aceito na máquina é de R$ 10,00.

Possíveis finais: Doce A sem troco, Doce B sem troco, Doce C sem troco, Doce A com troco, Doce B com troco, Doce C com troco.

## Prints da tela
![Image_4](https://github.com/GuilhermeYoshikawa/Assets/blob/main/Assets/maquinaDoceA.PNG)

![Image_5](https://github.com/GuilhermeYoshikawa/Assets/blob/main/Assets/maquinaDoceB.PNG)

![Image_6](https://github.com/GuilhermeYoshikawa/Assets/blob/main/Assets/maquinaDoceC.PNG)

![Image_7](https://github.com/GuilhermeYoshikawa/Assets/blob/main/Assets/maquinaDoceC1.PNG)

![Image_8](https://github.com/GuilhermeYoshikawa/Assets/blob/main/Assets/maquinaDoceC2.PNG)

![Image_9](https://github.com/GuilhermeYoshikawa/Assets/blob/main/Assets/maquinaDoceA.PNG)

![Image_10](https://github.com/GuilhermeYoshikawa/Assets/blob/main/Assets/maquinaDoceA1.PNG)

![Image_11](https://github.com/GuilhermeYoshikawa/Assets/blob/main/Assets/maquinaDoceA2.PNG)

![Image_12](https://github.com/GuilhermeYoshikawa/Assets/blob/main/Assets/maquinaDoceA3.PNG)

![Image_13](https://github.com/GuilhermeYoshikawa/Assets/blob/main/Assets/maquinaDoceA4.PNG)

# 👉 Case 2 (Elevador)
O Case 2 é um elevador que atende o térreo e mais 3 andares. As portas do elevador podem estar fechadas ou abertas e ele se desloca linearmente de um piso para o outro: se elevador está no térreo e precisa ir até o 3° andar terá de passar necessariamente pelo 2° andar. Enquanto o elevador estiver em movimento, as portas estarão fechadas. Ao parar no andar desejado, elas se abrem.

O autômato construído representa o controle do funcionamento do elevador.

## Prints da tela
![Image_14](https://github.com/GuilhermeYoshikawa/Assets/blob/main/Assets/ElevadorPortaAberta.PNG)

![Image_15](https://github.com/GuilhermeYoshikawa/Assets/blob/main/Assets/ElevadorPortaFechada.PNG)

![Image_16](https://github.com/GuilhermeYoshikawa/Assets/blob/main/Assets/ElevadorEscolhendoAndar.PNG)

![Image_17](https://github.com/GuilhermeYoshikawa/Assets/blob/main/Assets/ElevadorEscolhendoAndar1.PNG)

![Image_18](https://github.com/GuilhermeYoshikawa/Assets/blob/main/Assets/ElevadorEscolhendoAndar2.PNG)

![Image_19](https://github.com/GuilhermeYoshikawa/Assets/blob/main/Assets/ElevadorDescendo.PNG)

![Image_20](https://github.com/GuilhermeYoshikawa/Assets/blob/main/Assets/ElevadorDescendo1.PNG)

![Image_21](https://github.com/GuilhermeYoshikawa/Assets/blob/main/Assets/ElevadorDescendo2.PNG)

# 📋 Modelo conceitual
## Diagrama de estados do Case 1 (Máquina de Doces)
![Image_22](https://github.com/GuilhermeYoshikawa/Assets/blob/main/Assets/DiagramaMaquinaDeDoces.png)

## Diagrama de estados do Case 2 (Elevador)
![Image_23](https://github.com/GuilhermeYoshikawa/Assets/blob/main/Assets/DiagramaElevador.png)

# 🛠 Tecnologias utilizadas
- C#
- Windows Forms
- Visual Studio 2019

# 🔧 Como executar o projeto

Pré-requisitos: 
- Visual Studio 2019

```bash
# clonar repositório
git clone https://github.com/GuilhermeYoshikawa/tcec_proj.git

# entrar na pasta do projeto no terminal/cmd
cd tcec_proj

# executar o projeto
start afd/afd.sln
```

# 🧑‍💻 Autor

Guilherme Yoshikawa da Silva

https://www.linkedin.com/in/guilherme-yoshi/
