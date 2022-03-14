using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EndLevel : MonoBehaviour
{
    [SerializeField] ParticleSystem particleSystem;
    private void OnTriggerExit2D(Collider2D other) {
        if(other.GetType() == typeof(CapsuleCollider2D) && other.tag == "Player"){
            particleSystem.Play();
            GetComponent<AudioSource>().Play();
            Invoke("reloadScene", 1.5f);
        }
    }


    void reloadScene(){
        SceneManager.LoadScene("Level1",0);
    }
}
