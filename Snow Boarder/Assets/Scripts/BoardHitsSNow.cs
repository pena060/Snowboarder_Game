using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardHitsSNow : MonoBehaviour
{
    [SerializeField] ParticleSystem snowBoardEffect;

    private void OnCollisionStay2D(Collision2D other) {
        if(other.gameObject.tag == "Ground"){
            snowBoardEffect.Play();
        }
    }
    private void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.tag == "Ground"){
            snowBoardEffect.Stop();
        }
    }
}
