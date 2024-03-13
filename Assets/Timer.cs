using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timer = 0f; 
    public int counter = 0; 
    public float interval = 1f; 

    void Update()
    {
        
        timer += Time.deltaTime;

        
        if (timer >= interval)
        {
            counter++; 
            Debug.Log("Counter: " + counter); 
            timer = 0f; 
        }
    }
}

