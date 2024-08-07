using UnityEngine;

public class WalkMovement : IMovement
{
    private float speed;

    public WalkMovement(float speed)
    {
        this.speed = speed;
    }

    public void Move(Transform transform, Vector3 direction)
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
