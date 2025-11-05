using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public GameObject CurrentCheckponit;
    public Transform Player;
    // Start is called before the first frame update
    void Start()
    {
        CurrentCheckponit=null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerEnter2D (Collider2D other){
        if(other.tag== "Player"){
        FindObjectOfType<LevelManager>().CurrentCheckponit=this.gameObject;
     }   
}
}