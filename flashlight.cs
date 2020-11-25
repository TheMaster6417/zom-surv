 using UnityEngine;
 using System.Collections;
 
 public class flashlight : MonoBehaviour {
 
     public Light light;    //assign gameobject with light component attached
 
     void Update () {
         if (Input.GetMouseButtonDown (1)) {      //Right mouse
             light.enabled = !light.enabled;      //changes light on/off
         }
     }
 }