using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;

public class MoveToGoalAgent : Agent
{

    //Mlagents Starting Point
    public GameObject spawnPoint;

    //Mlagent Target Reward
    [SerializeField] private Transform targetTransfrom;
  
   
    //Mlagent Rotation
    public float rotationSpeed;

    public override void OnEpisodeBegin()
    {
      transform.localPosition = spawnPoint.transform.localPosition;


    }

    //Mlagents Reward Observation
    public override void CollectObservations(VectorSensor sensor)
    {
        sensor.AddObservation(transform.localPosition);
        sensor.AddObservation(targetTransfrom.localPosition);
    }

    //Mlagents Movement
    public override void OnActionReceived(ActionBuffers actions)
    {

        float moveX = actions.ContinuousActions[0];
        float moveZ = actions.ContinuousActions[1];
        float moveSpeed = 10f;
        transform.localPosition += new Vector3(moveX, 0, moveZ) * Time.deltaTime * moveSpeed;

        Vector3 movementDirection = new Vector3(moveX, 0, moveZ);
        movementDirection.Normalize();

        //Look to Direction
        if (movementDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }

    }

    //Mlagents Manual Movement
    public override void Heuristic(in ActionBuffers actionsOut)
    {
        ActionSegment<float> continuousActions = actionsOut.ContinuousActions;
        continuousActions[0] = Input.GetAxisRaw("Horizontal");
        continuousActions[1] = Input.GetAxisRaw("Vertical");
    }

    //Mlagents Objectives: Reward and Final Reward
    private void OnTriggerEnter(Collider other)
    {
        
        if(other.TryGetComponent<FinalGoal>(out FinalGoal finalGoal))
        {
         
            AddReward(+150f);
            EndEpisode();
        } 
        
        if(other.TryGetComponent<Wall>(out Wall wall))
        {
        
            SetReward(-1f);
            EndEpisode();
        }
   
    }



}
