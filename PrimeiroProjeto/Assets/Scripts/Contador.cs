using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Contador : MonoBehaviour {

    public float tempoInicial = 60f;
    public float tempoInicialCronometro = 0f;

    public TextMeshProUGUI txtContador;
    public TextMeshProUGUI txtCronometro;
    public TextMeshProUGUI txtBotao;

    private bool cronometroAtivo = false;

    // Use this for initialization
    void Start () {
        if (txtCronometro != null)
        {
            txtCronometro.text = tempoInicialCronometro.ToString("F2") + "m";
        }
        else
        {
            txtBotao.enabled = false;
        }

        if (txtContador != null)
            txtContador.text = tempoInicial.ToString("00");
    }
	
	// Update is called once per frame
	void Update () {
		if(txtContador!=null && tempoInicial >= 0f)
        {
            tempoInicial -= Time.deltaTime;
            txtContador.text = Mathf.Round(tempoInicial).ToString("00");
        }

        if (txtCronometro != null)
        {
            if (cronometroAtivo)
            {
                tempoInicialCronometro += Time.deltaTime;
                txtCronometro.text = tempoInicialCronometro.ToString("F2") + "m";
            }
        }


    }

    public void BotaoTempo()
    {
        if (txtBotao != null)
        {
            cronometroAtivo = !cronometroAtivo;
            txtBotao.text = cronometroAtivo ? "Parar" : "Continuar";
        }
    }
}
