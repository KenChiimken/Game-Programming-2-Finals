using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish_LVL2 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
   {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("Level 3");
        }
   }
}
