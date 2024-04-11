using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


public class mm2 : MonoBehaviour
{
    public void d1()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
