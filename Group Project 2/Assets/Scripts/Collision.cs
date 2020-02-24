using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider Col)
    {
        if(Col.tag == "Enemy")
        {
            SceneManager.LoadScene(2);
        }
        if(Col.tag == "Mcguffin")
        {
            SceneManager.LoadScene(3);
        }
    }
}
