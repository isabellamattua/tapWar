using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class splashDelay : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(loadMainMenu()); //part of the spalsh screen timer/delay
    }
    public IEnumerator loadMainMenu()
    {
        yield return new WaitForSeconds(3f); //the spash Screen timer delay set too 3 seconds
        SceneManager.LoadScene(1);
    }
}
