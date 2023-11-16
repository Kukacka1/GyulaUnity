using UnityEngine;

public class Forgatás : MonoBehaviour
{

    [SerializeField] float angularSpeed = 360;


    void Update()
    {
        transform.Rotate(0, angularSpeed * Time.deltaTime, 0);
    }
}
