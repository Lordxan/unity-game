using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : Singleton<ScoreManager>
{
    private int _score = 0;
    public int Score
    {
        get => _score;
        set
        {
            var textField = GameObject.Find("Score").GetComponent<Text>();
            textField.text = value.ToString();
            _score = value;
        }
    }
}
