using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float loadDelay = 1f;    
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;
    private bool gameEnded = false;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Ground" && !gameEnded){
            FindObjectOfType<PlayerController>().DisableControls();
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadScene", loadDelay);
            gameEnded = true;
        }
    }
 
    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
