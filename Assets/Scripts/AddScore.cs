using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    private int hitpoints = 1;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (hitpoints > 0)
        {
            ScoreManager.Instance.Score += 1;
            Destroy(gameObject);
            hitpoints--;
        }
    }
}
