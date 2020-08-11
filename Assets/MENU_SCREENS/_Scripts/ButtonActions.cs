using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonActions : MonoBehaviour
{
    public void BUTTON_ACTION_LOAD_UPGRADE_SCENE()
    {
        int sceneNumber = 2;
        SceneManager.LoadScene(sceneNumber);
    }

    public void BUTTON_ACTION_PLAY()
    {
        int sceneNumber = 3;
        SceneManager.LoadScene(sceneNumber);
    }

    public void BUTTON_ACTION_MENU()
    {
        Cursor.visible = true;
        
        int sceneNumber = 1;
        SceneManager.LoadScene(sceneNumber);
    }

}
