using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WordDespawner : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        Destroy(collision.gameObject);
        Debug.Log("destroy word");
        Debug.Log("game end");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
