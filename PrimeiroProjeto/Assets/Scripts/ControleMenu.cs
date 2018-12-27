using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class ControleMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChamaScena(string nome)
    {
        SceneManager.LoadScene(nome);
    }

    public void Sair()
    {
        Application.Quit();
    }
}
