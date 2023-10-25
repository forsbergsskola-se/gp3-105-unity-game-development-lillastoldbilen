using UnityEngine;
using UnityEngine.Events;

public class Cops : MonoBehaviour
{
    public int Health = 150;
    public float MovementSpeed;
    public UnityEvent OnDeath;

    private void OnDestroy()
    {
        this.OnDeath.Invoke();
    }
}