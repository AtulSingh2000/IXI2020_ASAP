using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSetter : MonoBehaviour
{
    public GameObject HelloARController;
    public GameObject FPSCam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 camDisplacement = new Vector3((FPSCam.transform.position.x + 0.5f), 0, (FPSCam.transform.position.z + 0.5f));
        Vector3 displacement = new Vector3(0, HelloARController.GetComponent<GoogleARCore.Examples.HelloAR.HelloARController>().targetY, 0);
        gameObject.transform.position = displacement + camDisplacement;
    }
}
