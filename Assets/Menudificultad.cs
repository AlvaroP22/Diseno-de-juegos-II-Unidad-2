using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menudifi : MonoBehaviour
{
     public void Cambiarscenee(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
