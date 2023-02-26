using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rook : MonoBehaviour
{
    [SerializeField]
    private GodScript godScript;
    [SerializeField]
    private int number;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }
    public void activateRook()
    {
        Debug.Log("υσι");
        godScript.rooktext(number);
    }
}
