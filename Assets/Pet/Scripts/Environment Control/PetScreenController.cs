using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PetScreenController : MonoBehaviour
{
    private GameObject Pet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Pet = GameObject.Find("SaberTooth(Clone)");
    }

    public void Action1()
    {
        Debug.Log("Button1 Pressed");
        Pet.GetComponent<AnimalStateControl>().Action1();
    }
    /*
    public void Action2()
    {
        Debug.Log("Button2 Pressed");
        Pet.GetComponent<AnimalStateControl>().Action2();
    }
    */
    public void SwitchSCene(string arg)
    {
        SceneManager.LoadScene(arg);
    }
}