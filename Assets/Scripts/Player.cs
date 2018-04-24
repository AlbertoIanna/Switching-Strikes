using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    float timer;
    public Color ColorStart;

    
    private Transform myTransform;
    float speed = 2.0f;
    ColorType color;

    private void Start()
    {
        gameObject.GetComponent<Renderer>().material.color = ColorStart;
        ColorStart = Color.red;
        color = ColorType.red;
        myTransform = gameObject.GetComponent<Transform>();
    }

    private void Update()
    {

        Movement();
        if (Input.GetKeyDown(KeyCode.Space))
            ChangeColor();

        timer += Time.deltaTime;
    }
    
    void Movement()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            myTransform.position += new Vector3(-7, 0, 0);
            ChangeColor();
            Debug.Log("sinistra");
           
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {

            myTransform.position += new Vector3(7, 0, 0);
            ChangeColor();
            Debug.Log("destra");
           
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            myTransform.position += new Vector3(0, 0, 7);
            ChangeColor();
            Debug.Log("su!");
           
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            myTransform.position += new Vector3(0, 0, -7);
            ChangeColor();
            Debug.Log("Giù!");
            
        }
        CenterPlayer(new Vector3(0,0,0), 0.02f);
    }


    private void CenterPlayer(Vector3 destination, float speed)
    {
        
            myTransform.position = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);
        

    }

    void ChangeColor()
    {
        if (ColorStart != Color.blue)
        {
            gameObject.GetComponent<Renderer>().material.color = ColorStart;
            ColorStart = Color.blue;
        }
        else if (ColorStart != Color.red)
        {
            gameObject.GetComponent<Renderer>().material.color = ColorStart;
            ColorStart = Color.red;
        }
    }

    public void Die()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        EnemyBase enemy = other.GetComponent<EnemyBase>();
        if (enemy)
        {
            Fight(enemy);
        }
    }

    void Fight(EnemyBase enemy)
    {
        if (color == enemy.color)
            enemy.Die();
        else
            Die();
    }


    
}

public enum ColorType
{
    blue, red
}

