using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{  
    public static event Action OnBlockerPass, OnGameOver;
    [SerializeField] private int gravity, clickImpulse, touchImpulse;    
    
    void Update()
    {
        if (Input.GetMouseButton(0))      
            transform.Translate(0, clickImpulse * Time.deltaTime, 0);
       
        if (Input.touchCount > 0)       
            transform.Translate(0, touchImpulse * Time.deltaTime, 0);
      
       transform.Translate(0, - gravity * Time.deltaTime, 0);         
    }
    private void OnTriggerEnter(Collider other) => OnBlockerPass?.Invoke();
   
    private void OnCollisionEnter(Collision collision) => OnGameOver?.Invoke();   
}
