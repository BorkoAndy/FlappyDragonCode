using System.Collections;
using UnityEngine;

public class BlockersSpawner : MonoBehaviour
{
    [SerializeField] public GameObject blockers;   

    void Start() => StartCoroutine(Blockers());    
    private IEnumerator Blockers()
    {
        while (true)
        {            
            Instantiate(blockers, new Vector3(12, Random.Range(-4f, 3.5f), 0), Quaternion.identity);
            if (GameController.level < 3)
                yield return new WaitForSeconds(3 - GameController.level);
            else
                yield return new WaitForSeconds(1);
        }
    }
}
