using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKey(KeyCode.O))
        {
            SceneManager.LoadScene(2);
        }

    }
}
