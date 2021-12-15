using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{

    public GameObject platform;

    private Vector3 water_1 = new Vector3(45, 25, 5);
    private Vector3 water_2 = new Vector3(55, 25, 95);


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawning());
    }

    IEnumerator Spawning(){
        yield return new WaitForSeconds(Random.Range(3f,6f));

        if(Random.Range(0,2)==1){
            Instantiate(platform,water_1,Quaternion.identity);
        }

        if(Random.Range(0,2)==1){
            Instantiate(platform,water_2,Quaternion.Euler(0.0f, 180.0f, 0.0f));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
