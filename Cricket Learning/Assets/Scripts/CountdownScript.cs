using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownScript : MonoBehaviour

{
    [SerializeField] private Text uiText;
    [SerializeField] private float mainTimer;

    private float timer;
    private bool canCount = true;
    private bool doOnce = false;

    public GameObject Ad;
    public GameObject Bug2;
    // Start is called before the first frame update
    void Start()
    {
        timer = mainTimer;
        Ad.SetActive(false);
        Bug2.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (timer >= 0.0f && canCount)
        {
            timer -= Time.deltaTime;
            uiText.text = timer.ToString("F");
        }
        else if (timer <= 0.0f && !doOnce) 
        {
            canCount = false;
            doOnce = true;
            uiText.text = "0.00";
            timer = 0.0f;
            GameOver();
        }

        if (timer <= 24.0f) 
        {
            Ad.SetActive(true);
            //Debug.Log("ad 1 shows");
        }
        if (timer <= 15.0f)
        {
            Bug2.SetActive(true);
           //Debug.Log("bug boi shows");
        }



    }

    void GameOver() 
    {
        SceneManager.LoadScene("Bug");
    }

}
