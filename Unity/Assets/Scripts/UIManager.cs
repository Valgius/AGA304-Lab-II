using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;

public class UIManager : MonoBehaviour
{
    public GameObject blackScreen;
    
    public float delayTime;
   

    // Start is called before the first frame update
    void Start()
    {
        blackScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BeginCountDown()
    {
        StartCoroutine(BlackScreen());
    }

    IEnumerator BlackScreen()
    {
        yield return new WaitForSecondsRealtime(delayTime);
        blackScreen.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();

    }
}
