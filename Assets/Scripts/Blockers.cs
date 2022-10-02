using UnityEngine;

public class Blockers : MonoBehaviour
{
    private int speed;
    private void Start() => speed = (GameController.level * 2) + 5;
    private void Update()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);
       
        if (transform.position.x < -12)
            Destroy(gameObject);        
    }  
}
