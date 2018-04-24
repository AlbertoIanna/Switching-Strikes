using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    float timer;
    public Color ColorStart;

    private void Start()
    {
        gameObject.GetComponent<Renderer>().material.color = ColorStart;
        ColorStart = Color.red;
    }

    private void FixedUpdate()
    {
        Movement();
        if (timer >= 2.5)
            CenterPlayer();
    }

    void Movement()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            transform.position += new Vector3(-3, 0, 0);
            ChangeColor();
            Debug.Log("sinistra");
        }
        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            transform.position += new Vector3(3, 0, 0);
            ChangeColor();
            Debug.Log("destra");
        }
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            transform.position += new Vector3(0, 0, 3);
            ChangeColor();
            Debug.Log("su!");
            }
        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            transform.position += new Vector3(0, 0, -3);
            ChangeColor();
            Debug.Log("Giù!");
        }
        if (Input.GetKeyDown(KeyCode.Space))
            ChangeColor();
        timer += Time.deltaTime;
    }

    void CenterPlayer()
    {
        if (transform.position.x == 3 || transform.position.x ==-3)
            transform.position = new Vector3(0,0,0);
        if (transform.position.z == 3 || transform.position.z == -3)
            transform.position = new Vector3(0, 0, 0);

    }

    void ChangeColor()
    {
        if (ColorStart != Color.blue)
            ColorStart = Color.blue;
        else if (ColorStart != Color.red)
            ColorStart = Color.red;
            
    } 
  
}
