using System.Collections;
using UnityEngine;

public class BlockersSpawner : MonoBehaviour
{
    [SerializeField] public GameObject blockers;
    private int level;

    private void OnEnable() => Counter.OnLevelUp += LevelUp;
    private void OnDisable() => Counter.OnLevelUp -= LevelUp;

    void Start()
    {
        level = GameController.level;
        StartCoroutine(Blockers());
    }
    private void LevelUp() => level++;

    private IEnumerator Blockers()
    {
        while (true)
        {
            Instantiate(blockers, new Vector3(12, Random.Range(-4f, 3.5f), 0), Quaternion.identity);
            if (level < 3)
                yield return new WaitForSeconds(3 - level);
            else
                yield return new WaitForSeconds(1);
        }
    }
}
