using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour{

    bool GotoRight ;
    bool GoDown ;
    float speed;
    private static float RandomColor;
    private Color EnemyColor;
    private Vector3 respawnposition;
    private Vector3 Arriveposition = new Vector3(0,0,0);

    
    private void Start()
    {
        transform.position = respawnposition;
        gameObject.GetComponent<Renderer>().material.color = EnemyColor;
        RandomColor = Random.Range(0f,2f);
        if(RandomColor < 1f)
        {
            EnemyColor = Color.red;
        }
        else
        {
            EnemyColor = Color.blue;
        }
    }

    private void Update()
    {
        Movement();
    }

    public  void DealDamage() {

    }

    public void Movement()
    {
        if (transform.position.x > 0)
            GotoRight = false;
        if (transform.position.z < 0)
            GoDown = false;

        if (GotoRight == true)
        {
            transform.Translate(Vector3.right * Time.deltaTime);
            if (transform.position.x <= Arriveposition.x)
                transform.position = respawnposition;
        }
        else
        {
            transform.Translate(Vector3.left * Time.deltaTime);
            if (transform.position.x >= Arriveposition.x)
                transform.position = respawnposition;
        }

        if (GoDown == true)
        {
            transform.Translate(Vector3.down* Time.deltaTime);
            if (transform.position.z <= Arriveposition.z)
                transform.position = respawnposition;
        }
        else
        {
            transform.Translate(Vector3.up* Time.deltaTime);
            if (transform.position.x >= Arriveposition.z)
                transform.position = respawnposition;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        
    }


}
