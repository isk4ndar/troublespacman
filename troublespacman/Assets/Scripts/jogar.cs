using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jogar : MonoBehaviour {

	void Start () {

	}

	void Update () {

		//verifica click do botão do mouse (desktop)
		//verifica toque duplo na tela (mobile)
		if(Input.GetMouseButtonDown(1))
		{
			//muda pra tela de jogo
			SceneManager.LoadScene("pacmanproject");
		}
	}
}
