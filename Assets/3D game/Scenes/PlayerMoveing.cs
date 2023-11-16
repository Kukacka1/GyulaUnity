using UnityEngine;

public class PlayerMoveing : MonoBehaviour
{

    [SerializeField] float speed = 10;
    [SerializeField] float angularSpeed = 360;





    void Update()
    {

        bool upInput = Input.GetKey(KeyCode.UpArrow);
        bool downInput = Input.GetKey(KeyCode.DownArrow);
        bool RightInput = Input.GetKey(KeyCode.RightArrow);
        bool LeftInput = Input.GetKey(KeyCode.LeftArrow);

        float xInput = 0;
        if (RightInput)
            xInput += 1;
        if (LeftInput)
            xInput -= 1;


        float yInput = 0;
        if (upInput)
            yInput += 1;
        if (downInput)
            yInput -= 1;


        Vector3 inputVector = new Vector3(xInput, 0, yInput);
        inputVector.Normalize();

        Vector3 velocity = inputVector * speed;
        transform.position += velocity * Time.deltaTime;

        // FORGATÁS
        if (inputVector != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(inputVector);
            float stepRotation = angularSpeed * Time.deltaTime;
            transform.rotation =
                Quaternion.RotateTowards(transform.rotation, targetRotation, stepRotation);
        }

    }
}