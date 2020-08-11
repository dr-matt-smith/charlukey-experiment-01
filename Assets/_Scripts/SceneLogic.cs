using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLogic : MonoBehaviour
{
    public string sceneName;
    private AudioSource _audioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        _audioSource = this.GetComponent<AudioSource>();
        
    }

    void OnTriggerEnter(Collider hit)
    {
        Debug.Log("trying to go into NAV mode");

//        if (!_audioSource.isPlaying)
//        {
//            _audioSource.Play();            
//        }
        
        SceneManager.LoadScene(sceneName);

        
    }
}
