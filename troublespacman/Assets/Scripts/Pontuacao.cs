using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Pontuacao : MonoBehaviour
{
    public static int pontos;
    public Text pontosTXT;

    public static int current;

    void Start()
    {
        //inicializador das variaveis de contagem
        pontos = 0;  //pontos totais/current high score
        current = 0; //pontos torais/high score
    }

    void Update()
    {
        //atualiza o contado a cada frame e
        //incremento da variavel ponto
        pontosTXT.text = pontos.ToString();
    }
}
