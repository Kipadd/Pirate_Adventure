using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private IMovement movement;

    public CharacterMovement(IMovement movement)
    {
        this.movement = movement;
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(h, 0, v);

        movement.Move(transform, direction);
    }
}
