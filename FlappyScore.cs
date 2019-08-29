using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyScore : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score.score++;
    }
}
