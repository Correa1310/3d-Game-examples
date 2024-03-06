using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Collectibles : MonoBehaviour
{
     public int score = 0;
     public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
         scoreText.text = "Score" + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnTriggerEnter(Collider other)
    {
    if(other.gameObject.CompareTag("Player"))
    {
        score++;
        scoreText.text = "Score" + score.ToString();
        Destroy(this.gameObject);
    }
    }
}