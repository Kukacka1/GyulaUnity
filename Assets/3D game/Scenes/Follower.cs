using UnityEngine;

public class Follower : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Transform target;

    void Update()
    {
        float stepLength = speed * Time.deltaTime;

        transform.position = Vector3.MoveTowards(transform.position, target.position, stepLength);
        


        transform.LookAt(target);
        
        
    }
}