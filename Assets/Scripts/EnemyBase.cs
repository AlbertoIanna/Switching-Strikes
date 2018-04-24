using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour{

    public ColorType color;

    bool GotoRight ;
    bool GoDown ;

    float speed;

    private static float RandomColor;
    private Color EnemyColor;
    private Vector3 respawnposition;
    private Vector3 Arriveposition = new Vector3(0,0,0);
  
    
    private void Start()
    {
        respawnposition = transform.position;
        gameObject.GetComponent<MeshRenderer>().material.color = EnemyColor;
        RandomColor = Random.Range(0f,2f);
        if(RandomColor <= 1f)
        {
            EnemyColor = Color.red;
            color = ColorType.red;
        }
        else if (RandomColor >1) 
        {
            EnemyColor = Color.blue;
            color = ColorType.blue;
        }
    }

    private void Update()
    {
        if(transform.position.x!=0 || transform.position.z!=0)
        Movement(new Vector3(0,0,0), 1.0f);
    }

    public void Movement(Vector3 destination, float speed)
    {
        transform.position = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);

    }
    public void Die()
    {
        Destroy(gameObject);
    }



}
