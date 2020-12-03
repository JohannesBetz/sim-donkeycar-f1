 using UnityEngine;
 using System.Collections;
 

 public class ToggleLights : MonoBehaviour
 {
     //Start traffic light in off state
     public int LightState = 0;
     void Start()
     {
     }
    //Change state when 'E' is pressed
     void Update()
     {
         //Toggles between traffic light states: 0=Off, 1=Red, 2=Yellow, 3=Green
         if (Input.GetKeyDown(KeyCode.E)){
             LightState++;
             if(LightState > 3){
                 LightState = 0;
             }
        }
     }  

 }