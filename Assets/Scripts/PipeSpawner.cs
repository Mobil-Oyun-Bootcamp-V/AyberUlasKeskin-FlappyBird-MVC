using System.Collections;
using System.Collections.Generic;
using MVC;
using UnityEngine;
using Random = UnityEngine.Random;
public class PipeSpawner : MonoBehaviour
{
    
    public PlayerController ControllerScript;
    public GameObject Pipes;

    
    
    public float height;

    public float time;
    // Start is called before the first frame update

    private void Start()
    {
        StartCoroutine(SpawnObject(time));
        
    }

    public IEnumerator SpawnObject(float time)
    {
        
        while (true)
        {
           
            Instantiate(Pipes, new Vector3(3, Random.Range(-height, height), 0), Quaternion.identity);
            yield return new WaitForSeconds(time);
            
        }
    }
}
