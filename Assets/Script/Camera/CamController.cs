using UnityEngine;
using Cinemachine;

public class CamController : MonoBehaviour
{

    [SerializeField]
    private CinemachineVirtualCamera vcam1;// player Camera
    [SerializeField]
    private CinemachineVirtualCamera vcam2;// wall Camera

    

    public void switchPriority()
    {
        vcam2.Priority = 20;
        vcam1.Priority = 10;
    }
}
