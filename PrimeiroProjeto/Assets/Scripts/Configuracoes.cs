using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Configuracoes : MonoBehaviour {

    //Variaveis
    public bool     isFullScreen;
    public int      resolutionIndex;
    public int      qualityTexture;
    public float    musicVolume;

    //Objetos
    public Toggle   fullScreenToggle;
    public TMP_Dropdown resolutionDropDown;
    public TMP_Dropdown qualityTextureDropDown;
    public Slider   musicVolumeSlider;

    public Resolution[] resolutions;


    private void OnEnable()
    {
        resolutions = Screen.resolutions;
        foreach (Resolution res in resolutions)
        {
            resolutionDropDown.options.Add(new TMP_Dropdown.OptionData(res.ToString()));
        }

        //Adicionando funções aos itens do menu
        fullScreenToggle.onValueChanged.AddListener(delegate { OnFullScreenToggle(); });
        resolutionDropDown.onValueChanged.AddListener(delegate { OnResolutionChange(); });
        qualityTextureDropDown.onValueChanged.AddListener(delegate { OnTextureQualityChange(); });
        musicVolumeSlider.onValueChanged.AddListener(delegate { OnMusicVolumeChange(); });


    }

    // Use this for initialization
    void Start () {
       
	}

	// Update is called once per frame
	void Update () {
		
	}

    public void OnFullScreenToggle()
    {
        isFullScreen = fullScreenToggle.isOn;
        Screen.fullScreen = fullScreenToggle.isOn;
        OnResolutionChange();
        //Debug.Log(isFullScreen);
    }

    public void OnResolutionChange()
    {
        Screen.SetResolution(resolutions[resolutionDropDown.value].width,resolutions[resolutionDropDown.value].height, fullScreenToggle.isOn);
    }

    public void OnTextureQualityChange()
    {
        QualitySettings.SetQualityLevel(qualityTextureDropDown.value);
    }

    public void OnMusicVolumeChange()
    {

    }
}
