using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using TMPro;

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

    [SerializeField]
    private TextMeshProUGUI _text;


    [SerializeField]
    private int _time;
    private int c;

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
    private void FixedUpdate()
    {
        if (win != true)
        {
            c -= 1;
            if (c == 0)
            {
                _text.text = "";
            }
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

    public void rooktext(int num)
    {
        c = _time;
        switch (num)
        {
            case 1:
                _text.text = "первым делом иди на северо-восток";
                break;
            case 2:
                _text.text = "первым делом иди на северо-восток";
                break;
            case 3:
                _text.text = "первым делом иди на северо-восток";
                break;
            case 4:
                _text.text = "первым делом иди на северо-восток";
                break;
        }
    }

    private void Win()
    {
        win = true;
    }

}
