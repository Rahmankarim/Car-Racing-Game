using UnityEngine;

public class CameraScript : MonoBehaviour
{    public Vector3 offset;
    public GameObject car;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
               offset = transform.position - car.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = offset + car.transform.position;
    }
}
