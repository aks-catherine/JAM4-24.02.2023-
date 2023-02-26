using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class GodScript : MonoBehaviour
{
    [SerializeField]
    AltarScript Altar1;
    [SerializeField]
    AltarScript Altar2;
    [SerializeField]
    AltarScript Altar3;
    [SerializeField]
    AltarScript Altar4;
    
    private int AlCount;
    private bool win;

    //public PostProcessVolume ourVolume;
    

    void Start()
    {
        win = false;
        AlCount = 1;    
    }

    // Update is called once per frame
    void Update()
    {
        if (win == true)
        {

        }
    }
    public void altars(int whatNumberOfThisAltar, AltarScript _thisAltarObject)
    {
        if (AlCount == whatNumberOfThisAltar)
        {
            _thisAltarObject.NewLight();
            AlCount += 1;
        }
        else if (AlCount > whatNumberOfThisAltar)
        { }
        else
        {
            Altar1.DisActivate();
            Altar2.DisActivate();
            Altar3.DisActivate();
            Altar4.DisActivate();
            AlCount = 1;
            Debug.Log("хах");
        }

        if (AlCount == 5)
        {
            Win();
            Debug.Log("Победа");
        }
    }
    private void Win()
    {
        win = true;
    }

}
