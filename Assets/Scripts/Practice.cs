using UnityEngine;

class Practice : MonoBehaviour
{
    [SerializeField] int number = 10;

    void Start()
    {
        int sum = 0;

        for (int i = 1; i <= number * 2; i+= 2)
        {
            sum += i;
        }

        Debug.Log(sum);

        // --------------------------------------------

        float n1 = Mathf.Abs(-34);
        float n2 = Mathf.Min(5, 55, -2);
        float n3 = Mathf.Max(3, 12, -4);
        float n4 = Mathf.Round(44.67f);
        float n6 = Mathf.Sign(-337);
    }

   
}





