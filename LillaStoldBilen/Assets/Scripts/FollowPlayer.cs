using UnityEngine;
public class FollowPlayer : MonoBehaviour
{
    private void LateUpdate()
    {
        GameObject player = GameObject.Find("Player");
        GameObject camera = GameObject.Find("Main Camera");
        camera.transform.parent = player.transform;
        if (player == null)
        {
            return;
        }

        Vector3 target = player.transform.position + new Vector3(0, 10f, -10);
        Quaternion camRotation = player.transform.rotation * Quaternion.Euler(40f, 0, 0);
        transform.position = target;
        transform.rotation = camRotation;
    }
}
