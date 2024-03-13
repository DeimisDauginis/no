using UnityEngine;
using TMPro;

public class ScoreUpdater : MonoBehaviour
{
    public int score = 0; 
    public TextMeshProUGUI scoreText; 

    void Start()
    {
        
        scoreText = GetComponent<TextMeshProUGUI>();

        
        if (scoreText == null)
        {
            Debug.LogError("TextMeshPro component not found. Make sure this script is attached to a GameObject with a TextMeshPro component.");
        }
    }

    void Update()
    {
        
        score++;

        
        scoreText.text = "Score: " + score.ToString();
    }
}
