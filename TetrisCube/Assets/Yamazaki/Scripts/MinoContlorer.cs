using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinoContlorer : MonoBehaviour
{
    public float speed = 1.0f;
    private float timeleft;
    // Start is called before the first frame update
    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        /*
        timeleft -= Time.deltaTime;
        if(timeleft <= 0.0)
        {
            timeleft = 0.5f;

            
        }
        */
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-1, 0, 0);
            Debug.Log(transform.position);

            if (this.transform.position.x == -5.0f)
            {
                transform.position += new Vector3(1, 0, 0);
                Debug.Log("これ以上進めません");
            }
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += new Vector3(1, 0, 0);
            Debug.Log(transform.position);

            if (this.transform.position.x == 5.0f)
            {
                transform.position += new Vector3(-1, 0, 0);
                Debug.Log("これ以上進めません");
            }
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, -1, 0);

            Debug.Log(transform.position);
        }

        if (Input.GetKeyDown("a"))
        {
            transform.Rotate(0, 0, -90);

            Debug.Log(transform.position);
        }

        if (Input.GetKeyDown("d"))
        {
            transform.Rotate(0, 0, 90);

            Debug.Log(transform.position);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.LeftAlt) && Input.GetKeyDown(KeyCode.Backspace))
        {
            transform.position = new Vector3(0, 4.5f, 0);

            Debug.Log("リセット");
        }


    }
}
