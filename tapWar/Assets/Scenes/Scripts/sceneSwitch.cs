/* 
Kingsley Notes:
Learning how to use scenemanager and add a 
scirpt to go from one scene to other.
    There are four simple scenes:
    ~Splash 
    ~Main Menu
    ~Payers
    ~Game

Note before moving on need to clean up nameing
of the sceneswitches.

 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class sceneSwitch : MonoBehaviour{

    public void sceneSwitcher(){
        SceneManager.LoadScene(1);
    }
    public void sceneSwitcher2(){
        SceneManager.LoadScene(2);
    }

     public void sceneSwitcher3(){
        SceneManager.LoadScene(3);
    }

     public void sceneSwitcher4(){
        SceneManager.LoadScene(2);
    }
}
