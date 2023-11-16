

using UnityEngine;

class FizzBuzz : MonoBehaviour
{
    [SerializeField] int number = 10;
    void Start()
    {



        for (int i = 1; i <= number; i++)
        {
            bool devidableWith5 = i % 5 == 0;
            bool devidableWith3 = i % 3 == 0;
            
            if (devidableWith3)
            {
                Debug.Log("Fizz");
            }
            else if (devidableWith5)
                Debug.Log("Buzz");

            else if (devidableWith3 && devidableWith5)

                Debug.Log("FizzBuzz");
            else

                Debug.Log(i);

        }
    }







}
