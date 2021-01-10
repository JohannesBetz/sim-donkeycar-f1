using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakLight : MonoBehaviour
{
    public Material[] OffMaterials = new Material[4];
    public Material[] OnMaterials = new Material[4];
    public Renderer rend;
    public Car carObj;
    // Start is called before the first frame update
    void Start()
    {
        carObj = GameObject.FindObjectOfType(typeof(Car)) as Car;
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        float isBrake = carObj.GetThrottle();
        Debug.Log("Break value is: " + isBrake);
        if (isBrake < 0f){
            //Break lights activate when S is pressed
            rend.materials = OnMaterials;
        } else {
            rend.materials = OffMaterials;
        }
    }
}
