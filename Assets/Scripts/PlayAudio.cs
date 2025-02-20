using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    [SerializeField] private AudioSource _damageSound;
    [SerializeField] private AudioSource _jumpSound;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayDamageSound()
    {
        if (_damageSound != null)
        {
            _damageSound.Play();
        }
    }

    public void PlayJumpSound()
    {
        if (_jumpSound != null)
        {
            _jumpSound.Play();
        }
    }

}
