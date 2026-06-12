# 🎮 WallBound

[![Unity Version](https://img.shields.io/badge/Unity-2022.3+-black?logo=unity)](https://unity.com/)
[![License](https://img.shields.io/badge/License-MIT-green)](LICENSE)

## 📖 Sobre o Jogo

**WallBound** é um jogo de plataforma 2D desenvolvido como trabalho para a faculdade. O jogador controla um personagem que precisa coletar itens, desviar de armadilhas e inimigos, utilizando pulos normais e **wall jump** (pulo na parede) para escalar cenários e avançar pelas fases.

O jogo possui **3 fases**, sistema de **pontuação**, **vidas**, **efeitos sonoros** e **transição entre fases**.

---

## 🎯 Objetivo

Coletar todos os itens disponíveis em cada fase, desviar ou destruir obstáculos, e chegar ao **troféu** no final de cada fase para avançar para a próxima.

---

## 🕹️ Comandos

| Ação | Tecla |
|------|-------|
| Movimentar para esquerda/direita | `←` / `→` ou `A` / `D` |
| Pular / Wall Jump | `Espaço` |
| Voltar ao menu | `ESC` |

---

## ⚙️ Mecânicas

| Mecânica | Descrição |
|----------|-----------|
| **Pulo simples** | Pulo normal quando o jogador está no chão |
| **Wall Jump** | Pulo na parede que impulsiona o jogador na direção oposta |
| **Coletáveis** | Itens espalhados pelas fases que aumentam a pontuação |
| **Armadilhas** | Objetos que causam dano ao jogador ao toque |
| **Inimigos** | Se movem entre pontos pré-definidos e causam dano |
| **Plataformas armadilha** | Se desintegram após o jogador pisar |
| **Molas** | Impulsionam o jogador para cima com força extra |
| **Sistema de vida** | Jogador começa com 3 vidas; ao morrer, o score zera |

---

## 🧱 Estrutura do Projeto
Assets/
├── Scripts/
│   ├── Coletavel.cs
│   ├── DestroyGameObject.cs
│   ├── Enemys.cs
│   ├── FinalStageTrophy.cs
│   ├── GameManager.cs
│   ├── GameMenu.cs
│   ├── LetalObject.cs
│   ├── MusicManager.cs
│   ├── PlayerLife.cs
│   ├── PlayerMovement.cs
│   ├── SFXManager.cs
│   ├── Spring.cs
│   ├── TrapChecker.cs
│   └── TrapPlataform.cs
├── Scenes/
│   ├── Menu.unity
│   ├── Fase01.unity
│   ├── Fase02.unity
│   └── Fase03.unity
├── Prefabs/
├── Animations/
├── Sprites/
└── Audio/


---

## 📋 Scripts Principais

| Script | Função |
|--------|--------|
| `GameManager` | Gerencia score, transição entre fases, reload, e persistência entre cenas |
| `PlayerMovement` | Controla movimento horizontal, pulo, wall jump e animações |
| `PlayerLife` | Gerencia vida do jogador, dano e morte |
| `Coletavel` | Incrementa o score ao ser coletado |
| `LetalObject` | Causa dano ao jogador |
| `Enemys` | Movimenta inimigos entre waypoints |
| `FinalStageTrophy` | Ativa a transição para a próxima fase |
| `GameMenu` | Controla os painéis do menu principal |
| `SFXManager` | Gerencia os efeitos sonoros |
| `MusicManager` | Gerencia a música de fundo |
| `Spring` | Aplica força de impulso no jogador |
| `TrapPlataform` | Destroi a plataforma após um tempo |

---
## 🖼️ Imagens do Jogo

### Fase 01
<img width="898" height="495" alt="image" src="https://github.com/user-attachments/assets/1e71dea7-e951-4cc0-a0da-ab510812e30e" />


### Fase 02
<img width="890" height="493" alt="image" src="https://github.com/user-attachments/assets/6b484c90-6528-4c15-ab01-70384ded4e27" />


### Fase 03
<img width="898" height="490" alt="image" src="https://github.com/user-attachments/assets/dfe15240-9d69-4bde-b606-9f1fd779ac78" />


### Menu Principal
<img width="905" height="499" alt="image" src="https://github.com/user-attachments/assets/f6e42e7e-1946-4846-afbd-5ee0a727cc0c" />

---

## 🚀 Como Jogar

1. **Clone o repositório**
```bash
git clone https://github.com/dilok5/Jogo-WallBound.git
```
## 🚀 Como Jogar

1. Abra o projeto na Unity (versão 2022.3 ou superior)
2. Execute a cena `Menu.unity`
3. Divirta-se! 🎮

---

## 🛠️ Build do Jogo

Para gerar um executável:

1. `File → Build Settings`
2. Adicione as cenas na ordem: `Menu`, `Fase01`, `Fase02`, `Fase03`
3. Clique em `Build`

---

## 📄 Licença

Este projeto está sob a licença MIT. Consulte o arquivo [LICENSE](LICENSE) para mais informações.

---

## 🙏 Créditos

- **Desenvolvimento:** Carlos Di Loco
- **Font:** Upheaval [Ænigma] ```https://www.dafont.com/upheaval.font```
- **Gráficos:** Pixel Adventure [Pixel Frog] ```https://pixelfrog-assets.itch.io/pixel-adventure-1```,  Pixel Adventure 2 [Pixel Frog] ```https://pixelfrog-assets.itch.io/pixel-adventure-2```
- **Música:** The Heroines Theme [Adam Haynes] ``` https://www.youtube.com/c/AdamHaynesMusic``` 
- **Inspiração:** Jogos de plataforma 2D clássicos

---

## 🔗 Repositório

[https://github.com/dilok5/Jogo-WallBound](https://github.com/dilok5/Jogo-WallBound)
