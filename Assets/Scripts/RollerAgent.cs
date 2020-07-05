using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Sensors;

public class RollerAgent : Agent
{
    Rigidbody rBody;
    void Start()
    {
        rBody = GetComponent<Rigidbody>();
    }
    // To move the targetX (Cube), we nee to reference to to its Transform. 
    public Transform TargetX;
    public override void OnEpisodeBegin() {
        if (this.transform.localPosition.y < 0) {
            // If the Agent fell, zero its momemtum
            this.rBody.angularVelocity = Vector3.zero;
            this.rBody.velocity = Vector3.zero;
            this.transform.localPosition = new Vector3(0, 0.5f, 0);
        }

        // Move the targetX to a new spot
        TargetX.localPosition = new Vector3(Random.value * 8 - 4, 0.5f,
                                            Random.value * 8 - 4);
    }
}
