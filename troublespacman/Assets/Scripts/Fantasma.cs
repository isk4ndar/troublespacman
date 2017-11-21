using System.Collections;
using UnityEngine;

public class Fantasma : MonoBehaviour
{
    private Rigidbody2D fantasmaRB;
    private int atrito;
    public int atritoMax, atritoMin;
    public Vector3 posicao;
    public GameObject ghostPreFab;

    void Start()
    {
        //adiciona in code o rigidbody2D
        fantasmaRB = GetComponent<Rigidbody2D>();
        //define a velocidade que o fantasma vai cair
        atrito = Random.Range(atritoMin, atritoMax);

        fantasmaRB.drag = atrito;
        posicao = transform.position;
    }

    void Update()
    {
        //sempre que o fantasma passa da linha do ground
        if (fantasmaRB.transform.position.y < -5)
        {
            //intancia um novo fantasma com base na
            //posição que ele apareceu
            Instantiate(ghostPreFab, posicao, transform.localRotation);
            //adiciona +1 ao contador geral
            Pontuacao.pontos += 1;
            //adiciona +1 ao contador da partida
            Pontuacao.current += 1;
            //destroi o fantasma do prefab
            Destroy(this.gameObject);
        }
    }
}
