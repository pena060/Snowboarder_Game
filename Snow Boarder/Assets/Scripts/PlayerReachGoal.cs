using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReachGoal : MonoBehaviour
{
        void OnTriggerExit2D(Collider2D other) {
          if(other.tag == "Band"){
              Destroy(other.gameObject);
          } 
    
        }
        
}
