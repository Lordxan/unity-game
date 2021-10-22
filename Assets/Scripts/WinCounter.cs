using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateCounter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ScoreManager.Instance.Score += 0;
    }
}
