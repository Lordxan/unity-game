using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    [SerializeField]
    public Object scene;
    private int hitpoints = 1;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (hitpoints > 0)
        {
            if (Application.isEditor)
                SceneManager.LoadScene(scene.name, LoadSceneMode.Single);
            else 
                SceneManager.LoadScene(1, LoadSceneMode.Single);
            hitpoints--;
        }
    }
}
