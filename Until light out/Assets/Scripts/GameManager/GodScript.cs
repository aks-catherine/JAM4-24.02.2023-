using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    // Start is called before the first frame update
    private int AlCount;
    void Start()
    {
        AlCount = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void altars(int a, AltarScript _altar)
    {
        if (AlCount == a)
        {
            _altar.huiOn();
            AlCount += 1;
        }
        else if (AlCount > a)
        { }
        else
        {
            Altar1.huiOff();
            Altar2.huiOff();
            Altar3.huiOff();
            Altar4.huiOff();
            AlCount = 1;
            Debug.Log("хах");
        }
        if (AlCount == 5)
        {
            Debug.Log("Победа");
        }
    }
}
