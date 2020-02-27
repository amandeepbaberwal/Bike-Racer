using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class NavAgent : MonoBehaviour
{
    public AIWaypointNetwork WayPointNetwork = null;
    public int               CurrentIndex = 1;

    private NavMeshAgent _navAgent = null;
    // Start is called before the first frame update
    void Start()
    {
        WayPointNetwork = FindObjectOfType<AIWaypointNetwork>();
        _navAgent = GetComponent<NavMeshAgent>();
        _navAgent.speed = 3.5f;
        _navAgent.baseOffset = .6f;
        if (WayPointNetwork == null) return;
        if(WayPointNetwork.waypoints[CurrentIndex] != null)
        {
            _navAgent.destination = WayPointNetwork.waypoints[CurrentIndex].position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //ransform.rotation = _navAgent.transform.rotation;
    }
}
