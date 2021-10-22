using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField]
    public Object scene;
    private int hitpoints = 1;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (hitpoints > 0)
        {
            if (Application.isEditor)
                SceneManager.LoadScene(scene.name, LoadSceneMode.Additive);
            else 
                SceneManager.LoadScene(2, LoadSceneMode.Additive);
            hitpoints--;
        }
    }
}
