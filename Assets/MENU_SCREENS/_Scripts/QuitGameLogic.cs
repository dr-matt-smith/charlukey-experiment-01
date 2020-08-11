using UnityEngine;

public class QuitGameLogic : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }        
    }
}
