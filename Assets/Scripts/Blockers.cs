using System.Runtime.CompilerServices;
using UnityEngine;

public class Blockers : MonoBehaviour
{
    private int speed;   

    private void Update()
    {
        
        speed = GameController.level * 2 + 5;
        transform.Translate(-speed * Time.deltaTime, 0, 0);
       
        if (transform.position.x < -12)
            Destroy(gameObject);        
    }  
}
