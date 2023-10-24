using UnityEngine;
public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public float smoothSpeed = 5;
    private void LateUpdate()
    {
        if (this.player == null)
        {
            return;
        }

        Vector3 target = player.transform.position + player.transform.TransformDirection(new Vector3(0, 10f, -10));
        Quaternion camRotation = player.transform.rotation * Quaternion.Euler(40f, 0, 0);
        transform.position = Vector3.Lerp(transform.position, target, smoothSpeed * Time.deltaTime);
        transform.rotation = Quaternion.Lerp(transform.rotation, camRotation, smoothSpeed * Time.deltaTime);
    }
}