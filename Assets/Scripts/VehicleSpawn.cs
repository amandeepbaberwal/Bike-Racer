using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class VehicleSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject[] vehicles;
    [Tooltip("Spawn object every given time in seconds")]
    public float SpawnEvery = 3;
    private IEnumerator coroutine;
    // Start is called before the first frame update
    void Start()
    {
        coroutine = SpawnVehicles();
        StartCoroutine(coroutine);
    }

    private IEnumerator SpawnVehicles()
    {
        while (true)
        {
            yield return new WaitForSeconds(SpawnEvery);
            int ran = Random.Range(0, 2);
            GameObject ob = Instantiate(vehicles[ran], transform.position, Quaternion.identity) as GameObject;
            ob.AddComponent<NavAgent>();
            float spd = Random.Range(30, 50);
            ob.GetComponent<NavMeshAgent>().speed = spd;
            ob.transform.position = new Vector3(ob.transform.position.x, ob.transform.position.y + 5.0f, ob.transform.position.z);
            ob.transform.parent = gameObject.transform;
        }
    }
}
