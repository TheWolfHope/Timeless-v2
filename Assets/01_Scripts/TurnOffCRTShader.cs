using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class TurnOffCRTShader : MonoBehaviour
{
    public int isShaderTurnOn = 1;
    public ScriptableRendererFeature crtShader;
    public Volume volume;
    public VolumeProfile noFilterProfile;
    public VolumeProfile filterProfile;

    void Awake()
    {
        isShaderTurnOn = PlayerPrefs.GetInt("isShaderTurnOn", 1);        
    }
    public void ToggleShader()
    {
        if(isShaderTurnOn == 1)
        {
            crtShader.SetActive(false);
            isShaderTurnOn = 0;
            volume.profile = noFilterProfile;
            PlayerPrefs.SetInt("isShaderTurnOn", 0);
            PlayerPrefs.Save();
        }
        else if(isShaderTurnOn == 0)
        {
            crtShader.SetActive(true);
            isShaderTurnOn = 1;
            volume.profile = filterProfile;
            PlayerPrefs.SetInt("isShaderTurnOn", 1);
            PlayerPrefs.Save();
        }
    }

}
