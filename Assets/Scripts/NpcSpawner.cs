using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] NpcReference;
    private GameObject spawnedNpc;
    [SerializeField]
    private Transform leftPos, rightPos;
    private int randomIndex;
    private int randomSide;

    void Start()
    {
        StartCoroutine(SpawnNpc());
    }

    IEnumerator SpawnNpc()
    {
        while(true)
        {

            yield return new WaitForSeconds(Random.Range(1,10));
        randomIndex = Random.Range(0, NpcReference.Length);
        randomSide = Random.Range(0,2);

        spawnedNpc = Instantiate(NpcReference[randomIndex]);

        if(randomSide == 0)
        {

            spawnedNpc.transform.position = leftPos.position;
            spawnedNpc.GetComponent<NPC>().speed = Random.Range(4,10);


        } else
        {

            spawnedNpc.transform.position = rightPos.position;
            spawnedNpc.GetComponent<NPC>().speed = Random.Range(4,10);
            spawnedNpc.transform.localScale = new Vector3(-1f,1f,1f);
        }


      }






    }
}
