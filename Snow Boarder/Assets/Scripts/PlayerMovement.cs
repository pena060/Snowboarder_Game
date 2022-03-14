using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
     [SerializeField]float torqueAmount = 1f ;
     [SerializeField] float playerSpeed = 20f;
     [SerializeField] float basePlayerSpeed = 15f;
     SurfaceEffector2D surfaceEffector2D;
     Rigidbody2D rb2d;

     bool canMove = true;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A) && canMove){
            rb2d.AddTorque(torqueAmount);
        }else if(Input.GetKey(KeyCode.D) && canMove){
            rb2d.AddTorque(-torqueAmount);
        }

        if(Input.GetKey(KeyCode.W) && canMove){
            surfaceEffector2D.speed = playerSpeed;
        }else{
            surfaceEffector2D.speed = basePlayerSpeed;
        }
    }


    public void disableController(){
        canMove = false;
    }
}
