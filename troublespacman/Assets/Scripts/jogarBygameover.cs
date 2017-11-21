using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class jogarBygameover : MonoBehaviour
{
    public TextMesh recorde;
    public TextMesh current;

    void Start()
    {
        recorde.text = PlayerPrefs.GetInt("recorde").ToString();
        current.text = PlayerPrefs.GetInt("current").ToString();
    }

    void Update()
    {
        //verifica click do botão do mouse (desktop)
        //verifica toque duplo na tela (mobile)
        if (Input.GetMouseButtonDown(1)){
            //muda para tela de jogo
            SceneManager.LoadScene("pacmanproject");
        }
    }
}
