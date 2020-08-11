using System.Runtime.CompilerServices;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class LoaderProgress : MonoBehaviour
{
    
    public AudioSource music;
    public AudioSource finsihedSound;
    public Slider slider;
    public float speed=0.5f;

    private float _proportion = 0;
    private bool _completed = false;

    private bool playingCompletedSound = false;
  
    void Start()
    {
	  
        slider = GetComponent<Slider>();
    }

    void Update()
    {
        _proportion += Time.deltaTime * speed;
        slider.value = _proportion;
        _completed = (_proportion > 1);

        if (_completed && !playingCompletedSound)
        {
            finsihedSound.Play();
            music.Stop();
            playingCompletedSound = true;
        }

        if (_completed && !finsihedSound.isPlaying)
        {
            // finished playing, so can load level mow
            int sceneNumber = 1;
            SceneManager.LoadScene(sceneNumber);
        }
    }
}
