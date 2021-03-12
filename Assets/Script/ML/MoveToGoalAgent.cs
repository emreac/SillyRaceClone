using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;

public class MoveToGoalAgent : Agent
{
    public GameObject spawnPoint;
    [SerializeField] private Transform targetTransfrom;
    [SerializeField] private Material winMaterial;
    [SerializeField] private Material winMaterial2;
    [SerializeField] private Material winMaterial3;
    [SerializeField] private Material winMaterial4;
    [SerializeField] private Material winMaterial5;
    [SerializeField] private Material winMaterial6;
    [SerializeField] private Material winMaterial7;
    [SerializeField] private Material winMaterial8;
    [SerializeField] private Material finishMaterial;
    [SerializeField] private Material loseMaterial;
    [SerializeField] private MeshRenderer floorMeshRenderer;
    public float rotationSpeed;



    public override void OnEpisodeBegin()
    {
      transform.localPosition = spawnPoint.transform.localPosition;
     // transform.localPosition = Vector3.zero;

    }


    public override void CollectObservations(VectorSensor sensor)
    {
        sensor.AddObservation(transform.localPosition);
        sensor.AddObservation(targetTransfrom.localPosition);
    }
    public override void OnActionReceived(ActionBuffers actions)
    {

        float moveX = actions.ContinuousActions[0];
        float moveZ = actions.ContinuousActions[1];
        float moveSpeed = 10f;
        transform.localPosition += new Vector3(moveX, 0, moveZ) * Time.deltaTime * moveSpeed;

        Vector3 movementDirection = new Vector3(moveX, 0, moveZ);
        movementDirection.Normalize();

        if (movementDirection != Vector3.zero)
        {
      
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        
        }

    }
    public override void Heuristic(in ActionBuffers actionsOut)
    {
        ActionSegment<float> continuousActions = actionsOut.ContinuousActions;
        continuousActions[0] = Input.GetAxisRaw("Horizontal");
        continuousActions[1] = Input.GetAxisRaw("Vertical");
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<Goal>(out Goal goal))
        {
            floorMeshRenderer.material = winMaterial;
            AddReward(+1f);
       
          
        }
        if (other.TryGetComponent<Goal1>(out Goal1 goal1))
        {
            floorMeshRenderer.material = winMaterial2;
            AddReward(+3f);


        }
        if (other.TryGetComponent<Goal2>(out Goal2 goal2))
        {
            floorMeshRenderer.material = winMaterial2;
            AddReward(+5f);
            
          
        }  if(other.TryGetComponent<Goal3>(out Goal3 goal3))
        {
            floorMeshRenderer.material = winMaterial3;
            AddReward(+15f);
            
          
        } 
        
         if(other.TryGetComponent<Goal4>(out Goal4 goal4))
        {
            floorMeshRenderer.material = winMaterial4;
            AddReward(+25f);
            
          
        } 
         
         if(other.TryGetComponent<Goal5>(out Goal5 goal5))
        {
            floorMeshRenderer.material = winMaterial5;
            AddReward(+45f);
            
          
        } 
          if(other.TryGetComponent<Goal6>(out Goal6 goal6))
        {
            floorMeshRenderer.material = winMaterial6;
            AddReward(+75f);
            
          
        } 
         if(other.TryGetComponent<Goal7>(out Goal7 goal7))
        {
            floorMeshRenderer.material = winMaterial7;
            AddReward(+85f);
            
          
        } 
        if(other.TryGetComponent<Goal8>(out Goal8 goal8))
        {
            floorMeshRenderer.material = winMaterial8;
            AddReward(+95f);
            
          
        } 
        
        
        
        
        
        if(other.TryGetComponent<FinalGoal>(out FinalGoal finalGoal))
        {
            floorMeshRenderer.material = finishMaterial;
            AddReward(+150f);
            EndEpisode();
        } 
        
        if(other.TryGetComponent<Wall>(out Wall wall))
        {
            floorMeshRenderer.material = loseMaterial;
            SetReward(-1f);
            EndEpisode();
        }
   
    }



}
