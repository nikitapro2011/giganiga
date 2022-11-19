using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{
    //hp
    public int health = 5;
    //level
    public int level = 1;
    //speed
    public float speed = 1.2f;
    // Start is called before the first frame update
    void Start()
    {
        health = health + level;
        print("жизней;  + health");
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;




    }
}
