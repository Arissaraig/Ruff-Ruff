using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Controller : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKey(KeyCode.N))
        {
            SceneManager.LoadScene(3);
        }

    }
}