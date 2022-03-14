using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerHitsHead : MonoBehaviour
{
    [SerializeField] ParticleSystem hurtEffect;
    [SerializeField] AudioClip crashFX;

    bool isHurt = false;
   private void OnTriggerEnter2D(Collider2D other) {
       if(other.tag == "Ground" && other.GetType() == typeof(EdgeCollider2D) && isHurt == false){
           hurtEffect.Play();
           GetComponent<AudioSource>().PlayOneShot(crashFX);
           FindObjectOfType<PlayerMovement>().disableController();
           isHurt = true;
           Invoke("reloadScene", 0.8f);
       }
   }

   private void reloadScene(){
        SceneManager.LoadScene("Level1",0);
    }
}
