using UnityEngine;
using System.Collections;

public class SpawnController : MonoBehaviour
{
    [SerializeField] GameObject pipePrefab;
    [SerializeField] float heightOffset = 1f;  //диапазон смещения по вертикали
    [SerializeField] float spawnRate = 2f;  //частота появления труб

    void Start()
    {
        StartCoroutine( SpawnPipeRountine() );
    }
    IEnumerator SpawnPipeRountine()
    {
        while (true)
        {
            yield return new WaitForSeconds( spawnRate );
            float yPos = Random.Range(-heightOffset, heightOffset);
            Vector2 spawnPosition = new Vector2(transform.position.x, yPos);
            Instantiate(pipePrefab, spawnPosition, Quaternion.identity);
        }
    }

}
