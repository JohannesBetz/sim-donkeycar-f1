using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedSwitch : MonoBehaviour
{
    public Material[] materials = new Material[2];
    public Renderer rend;
    private int LightState = 0;
    // Start is called before the first frame update
    void Start()
    {
        
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)){
             LightState++;
             if(LightState > 3){
                 LightState = 0;
             }
        }
        
        if(LightState == 1){
            rend.sharedMaterial = materials[0];
        } else {
            rend.sharedMaterial = materials[1];
        }
    }
}
