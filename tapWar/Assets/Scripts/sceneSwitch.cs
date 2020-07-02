/* 
Kingsley Notes:
Learning how to use scenemanager and add a 
scirpt to go from one scene to other.
    There are four simple scenes:
    ~Splash 
    ~Main Menu
    ~Payers
    ~Game
The splash scene is one big button
Note before moving on need to clean up nameing
of the sceneswitches.

 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class sceneSwitch : MonoBehaviour{


 public void loadBack(){
        SceneManager.LoadScene(-1);
    }
    public void loadPlayerScene(){
        SceneManager.LoadScene(2);
    }

     public void loadGamScene(){
        SceneManager.LoadScene(3);
    }

     public void goBackToPlayScene(){
        SceneManager.LoadScene(2);
    }
}
