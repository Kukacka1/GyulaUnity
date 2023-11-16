using UnityEngine;

public class PathMover : MonoBehaviour
{
    // [SerializeField] Vector3 p1, p2;
    [SerializeField] float speed;
    [SerializeField] Transform t1, t2;

    Transform targetTransform;

    // Gizmos.color = Color.magenta;
    // Gizmos.DrawWireSphere(p1, 0.5f);
    // Gizmos.DrawWireSphere(p2, 0.5f);
    // Gizmos.DrawLine(p1, p2);
    void Start()
    {
        transform.position = t1.position;
        targetTransform = t2;
    }
    void Update()
    {
        float stepLength = speed * Time.deltaTime;
        Vector3 targetPoint = targetTransform.position;

        transform.position = Vector3.MoveTowards(transform.position, targetPoint, stepLength);
        if (transform.position == targetPoint)
        {

            targetTransform = targetTransform == t1 ? t2 : t1 ;

        }
    }

    void OnDrawGizmos()
    {

        if (t1 == null) return;
        if (t2 == null) return;



        Vector3 p1 = t1.position;
        Vector3 p2 = t2.position;


        Gizmos.color = Color.magenta;
        Gizmos.DrawWireSphere(p1, 0.5f);
        Gizmos.DrawWireSphere(p2, 0.5f);
        Gizmos.DrawLine(p1, p2);


    }


}
