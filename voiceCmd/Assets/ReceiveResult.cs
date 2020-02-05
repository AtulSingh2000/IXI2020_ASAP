using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReceiveResult : MonoBehaviour {

    public string[] result;
    public string res;

    CharacterController characterController;


     public float speed = 6.0F;
     public float jumpSpeed = 8.0F;
     public float rotSpeed = 90.0f; // turn at 90 degrees/second
     public float gravity = 20.0F;
     private Vector3 moveDirection = Vector3.zero;

        void Start()
    {
        characterController = GetComponent<CharacterController>();
        
    }



     void Update() {
         // rotate character with Horizontal keys:
         transform.Rotate(0, Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime, 0);
         CharacterController controller = GetComponent<CharacterController>();
         if (controller.isGrounded) {
             moveDirection = new Vector3(0, 0, Input.GetAxis("Vertical"));
             moveDirection = transform.TransformDirection(moveDirection);
             moveDirection *= speed;
             if (Input.GetButton("Jump")){
                 moveDirection.y = jumpSpeed;
             }
         }
         moveDirection.y -= gravity * Time.deltaTime;
         controller.Move(moveDirection * Time.deltaTime);
     }





/*
 
    void Update()
    {   Debug.Log(res + " asdf");

        
         if (res == "jump")
            {
                Vector3 temp = new Vector3(0,10,0);
                //rb.transform.position += temp; 
                Debug.Log("Here");
            }
        

       // moveDirection.y -= gravity * Time.deltaTime;


        characterController.Move(moveDirection * Time.deltaTime);
    }
*/
    void onActivityResult(string recognizedText){
        char[] delimiterChars = {'~'};
        result = recognizedText.Split(delimiterChars);
        GameObject.Find("Text").GetComponent<Text>().text = result[0];
        //characterController = GetComponent<CharacterController>();
        res = result[1];

    }

}
