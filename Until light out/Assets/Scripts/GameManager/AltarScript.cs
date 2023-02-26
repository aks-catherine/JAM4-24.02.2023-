using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltarScript : MonoBehaviour
{
    [SerializeField]
    private int number;
    [SerializeField]
    private GodScript godScript;
    [SerializeField]
    private Material OnMaterial;
    [SerializeField]
    private Material OffMaterial;
    [SerializeField]
    private GameObject AltMaterial;
    private Renderer renderer;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void activate()
    {
        godScript.altars(number, this);
        Debug.Log("ÂÇÀÈÌÎÄÅÉÑÒÂÈÅ");
    }

    public void huiOn()
    {
        renderer = AltMaterial.GetComponent<Renderer>();
        renderer.material = OnMaterial;
    }
    public void huiOff()
    {
        renderer = AltMaterial.GetComponent<Renderer>();
        renderer.material = OffMaterial;
    }
}
