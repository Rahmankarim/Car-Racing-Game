using UnityEngine;

public class carScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0,0,1.0f);
        } 
         if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0,1.0f,0);
        } 
         if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -1.0f, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -1.0f);
        }
        Vector3 carpos = transform.position; //Game Loop
        if(carpos.z >= 30)
        {
            carpos.z = -145;
            transform.position = carpos;
        }
        else if(carpos.z <= -145)
        {
            carpos.z = 30;
            transform.position = carpos;
        }

    }

}
