using UnityEngine;

public class MazeMovement : MonoBehaviour
{
    float xAxis = 0.0f;
    float zAxis = 0.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    xAxis = Input.GetAxis("Vertical") * 10;
    zAxis = Input.GetAxis("Horizontal") * 10;
    transform.rotation = Quaternion.Euler(xAxis, 0.0f, -zAxis);    
    }
}
