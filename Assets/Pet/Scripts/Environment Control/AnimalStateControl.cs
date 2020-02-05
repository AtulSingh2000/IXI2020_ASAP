using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalStateControl : MonoBehaviour
{
    public Animator animator;
    public GameObject FPSCam;

    private float moveSpeed = 0.5f;
    private GameObject Target;
    private bool follow = false;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponentInChildren<Animator>();
        Target = GameObject.FindGameObjectWithTag("Player");
        FPSCam = GameObject.Find("First Person Camera");
    }
    // Update is called once per frame
    void Update()
    {
        
        if (transform.position != Target.transform.position && follow == true)
        {
            Debug.Log("IsFollowing");
            animator.SetTrigger("IsFolowing");
            PositionRelocator();
        }
        
    }
    public void Action1()
    {
        follow = true;
    }
    public void Action2()
    {
        /*Debug.Log("Action2");
        animator.SetTrigger("Jump");
        if(animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 1 && !animator.IsInTransition(0))
        {
            animator.ResetTrigger("Jump");
        }*/
    }
    void PositionRelocator()
    {
        if (transform.position != Target.transform.position)
        {
            gameObject.transform.LookAt(new Vector3(0, Target.transform.position.y, 0));
        }
        transform.position += transform.forward * Time.deltaTime * moveSpeed;
        /*
        if (transform.position.x == Target.transform.position.x && transform.position.z == Target.transform.position.z)
        {
            Debug.Log("Destination");
            animator.ResetTrigger("IsFolowing");
            gameObject.transform.LookAt(new Vector3(0, FPSCam.transform.position.y, 0));
            follow = false;
        }
        */
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("reached");
            follow = false;
            gameObject.transform.LookAt(Target.transform.position);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("reached");
            follow = false;
            gameObject.transform.LookAt(FPSCam.transform);
        }
    }
}
