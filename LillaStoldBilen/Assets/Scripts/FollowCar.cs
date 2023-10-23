using UnityEngine;

namespace DefaultNamespace
{
    public class FollowCar : MonoBehaviour
    {
        public GameObject orangeCar;
        public float smoothSpeed = 5;
        private void LateUpdate()
        {
            if (this.orangeCar == null)
            {
                return;
            }
            GameObject orangeCar = GameObject.Find("Orange car");
            GameObject camera = GameObject.Find("Main Camera");

            Vector3 target = this.orangeCar.transform.position + orangeCar.transform.TransformDirection(new Vector3(0, 10f, -10));
            Quaternion camRotation = this.orangeCar.transform.rotation * Quaternion.Euler(40f, 0, 0);
            transform.position = Vector3.Lerp(transform.position, target, smoothSpeed * Time.deltaTime);
            transform.rotation = Quaternion.Lerp(transform.rotation, camRotation, smoothSpeed * Time.deltaTime);
    }
}
    
}