using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Sensors;

public class RollerAgent : Agent
{
    /**
     * Initialization and Resetting the Agent.
     */
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

    /**
     * Observing the Environement
     * 
     * The agent sends the information we collect to the brain. 
     * The data will be fed to a neural network as a feature vector. 
     * - Position of the target
     * - Position of Agent itself
     * - Velocity of the agent
     */
    public override void CollectObservations(VectorSensor sensor)
    {
        // Target and Agent positions
        sensor.AddObservation(TargetX.localPosition);
        sensor.AddObservation(this.transform.localPosition);

        // Agent velocity
        sensor.AddObservation(rBody.velocity.x);
        sensor.AddObservation(rBody.velocity.z);
    }

    /**
     * Taking Actions and Assigning Rewards
     * 
     */
    public float speed = 10;
    public override void OnActionReceived(float[] action)
    {
        //Action size = 2
        Vector3 controlSignal = Vector3.zero;
        controlSignal.x = action[0];
        controlSignal.z = action[1];
        rBody.AddForce(controlSignal * speed);

        // Rewards
        float distanceToTarget = Vector3.Distance(this.transform.localPosition, TargetX.localPosition);

        // Reached target
        if (distanceToTarget < 1.42f)
        {
            // Assign a reward of 1.0 
            SetReward(1.0f);
            // marks the agent as finished
            EndEpisode();
        }

        // If agent falls off platform
        if (this.transform.localPosition.y < 0) {
            EndEpisode();
        }
    }


}
