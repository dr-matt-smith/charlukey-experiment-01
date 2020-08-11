using UnityEngine;

public class DoorLogic : MonoBehaviour
{
    private Animator _animatorController;
    private AudioSource _audioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        _animatorController = transform.parent.GetComponent<Animator>();
        _audioSource = this.GetComponent<AudioSource>();

    }

    void OnTriggerEnter(Collider hit)
    {
        _animatorController.SetTrigger("Open");

        if (!_audioSource.isPlaying)
        {
            _audioSource.Play();            
        }
       
    }
    
    void OnTriggerExit(Collider hit)
    {
        _animatorController.SetTrigger("Close");

        if (!_audioSource.isPlaying)
        {
            _audioSource.Play();            
        }
    }
}
