using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D playerRB;
    private SpriteRenderer playerSprite;
    public float velocidade;
    public bool flipX;

    void Start()
    {
        // Executando apenas uma vez
        playerRB = GetComponent<Rigidbody2D>();
        playerSprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Executado durante toda a execução do game.
        if (Input.GetMouseButtonDown(0))
        //reponsável pela direção no eixo que o sprite irá se movimentar
        //quando o botão do mouse for acionado [clicado]
        {
            //velocidade recebe valor negativo p/ para um lado
            velocidade *= -1;
            //valor invertido novamente p/ mudar novamente o lado
            flipX = !flipX;
            //valor alterado aplicado ao eixo do aprite (mudando o lado)
            playerSprite.flipX = flipX;
        }
        //aplica a velocidade no RB do GO do pac
        playerRB.velocity = new Vector2(velocidade, 0);
    }

    void OnCollisionEnter2D(Collision2D colisao)
    //reponsável pela direção no eixo que o sprite irá se movimentar
    //quando colidir com a parede [bordas da area de jogo]
    {
        if (colisao.gameObject.tag == "fimDaRua_tela")
        {
            //mesmo esquema da movimentação, só que aplicada
            //ao contado com as paredes
            velocidade = velocidade * -1;
            flipX = !flipX;
            playerSprite.flipX = flipX;
        }
    }

    void OnTriggerEnter2D(Collider2D colisao)
    //reponsável pela mudança de tela e operacao com pontos
    //quando o pacman colide com qualque red-ghost
    {
        //em caso de colisão com o prefab de tag 'ghost'
        if (colisao.gameObject.tag == "ghost")
        {
            //salva o score da partida na variavel-chave 'current'
            PlayerPrefs.SetInt("current", Pontuacao.current);
            //verifica se pontos é maior ou menor que o
            //inteiro carregado em 'recorde'
            if (Pontuacao.pontos > PlayerPrefs.GetInt("recorde"))
            {
                //caso verdadeiro, seta pontos na chave recorde
                PlayerPrefs.SetInt("recorde", Pontuacao.pontos);
            }
            //muda pra tela e game over
            SceneManager.LoadScene(sceneName: "gameover");
        }
    }
}
