using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCounter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ScoreManager.Instance.Score += 0;
    }
}