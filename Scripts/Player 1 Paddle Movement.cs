using UnityEngine;

public class Paddlemover : MonoBehaviour
{
    private float speed = 25.0f;
    public float verticalInput;
    private float topLimit = 2.6f;
    private float bottomLimit = -2.7f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.up * speed * Time.deltaTime * verticalInput);

        // Keep the paddle positions
        Vector3 pos = transform.position;

        pos.y = Mathf.Clamp(pos.y, bottomLimit, topLimit);

        transform.position = pos;
    }
}
