using UnityEngine;

public class CameraControl : MonoBehaviour
{

    [SerializeField] public float cameraSpeed = 2f;
    [SerializeField] public float cameraHeight = 1f;
    public Transform target;

    /*
     * @Modifed: Sahil
     * Udpate each frame to move camera to target 
     * **/
    private void Update()
    {
        Vector3 newPos = new Vector3(target.position.x, target.position.y + cameraHeight, -10f);
        transform.position = Vector3.Slerp(transform.position, newPos, cameraSpeed*Time.deltaTime);
    }
}
