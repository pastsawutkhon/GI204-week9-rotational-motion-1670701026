using UnityEngine;
using UnityEngine.InputSystem;

public class AddTorque : MonoBehaviour
{
    public float torquePower;
    Rigidbody rb;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.dKey.isPressed)
        {
            rb.AddTorque(Vector3.right * torquePower * Time.deltaTime);
        }
    }
}
