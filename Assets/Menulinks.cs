using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menulinks : MonoBehaviour
{
    public void Jugar(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Abrirlink()
    {
        Application.OpenURL("https://www.udgvirtual.udg.mx/");
    }
}
