using UnityEngine;

public class OufOfBoundsDestroy : MonoBehaviour
{
    private float upperBound = 30.0f;
    private float lowerBound = -5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //If an object goes past the players view in the game, remove that object
        if (transform.position.z > upperBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!!!");
            Destroy(gameObject);
        }

    }
}
