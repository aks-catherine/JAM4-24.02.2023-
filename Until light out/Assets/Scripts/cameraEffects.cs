using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class cameraEffects : MonoBehaviour
{
    PostProcessVolume m_Volume;
    Vignette m_Vignette;


    void Start()
    {
        var vignette = ScriptableObject.CreateInstance<Vignette>();
        vignette.enabled.Override(true);
        vignette.intensity.Override(1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
