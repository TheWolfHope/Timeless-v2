using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class TurnOffCRTShader : MonoBehaviour
{
    public bool isShaderToggleOn = true;
    public ScriptableRendererFeature crtShader;
    public Volume volume;
    public VolumeProfile noFilterProfile;
    public VolumeProfile filterProfile;
    public Toggle crtToggle;

    void Awake()
    {
        isShaderToggleOn = PlayerPrefs.GetInt("isShaderToggleOn", 1) == 1;      
        crtToggle.isOn = isShaderToggleOn;
        ToggleShader(isShaderToggleOn);
        crtToggle.onValueChanged.AddListener(OnToggleValueChanged);
    }
    private void OnToggleValueChanged(bool isOn)
    {
        PlayerPrefs.SetInt("isShaderToggleOn", isOn ? 1 : 0);
        PlayerPrefs.Save();
        ToggleShader(isOn);
    }
    
    private void ToggleShader(bool isOn)
    {
        if(!isOn) 
        {
            crtShader.SetActive(false);
            volume.profile = noFilterProfile;
        }
        else
        {
            crtShader.SetActive(true);           
            volume.profile = filterProfile;
        }
    }
}
