using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadMenu()
    {
        //Debug.Log("Loading Menu");
        SceneManager.LoadScene("Menu");
    }

    public void LoadOptions()
    {
        SceneManager.LoadScene("Credits");
    }

    public void nextlevel() 
    {
        SceneManager.LoadScene("lvl 1");
    }
}
