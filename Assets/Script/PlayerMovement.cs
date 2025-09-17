using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float controlSpeed = 10f;
    [SerializeField] float xClampRange = 5f;
    [SerializeField] float yClampRange = 5f;

    Vector2 movement;

    void Update()
    {
        ProcessTranslation();
    }

    public void OnMove(InputValue value)
    {
        movement = value.Get<Vector2>();
    }
    private void ProcessTranslation()
    {
        float xOffset = movement.x * controlSpeed * Time.deltaTime;
        float rawXpos = transform.localPosition.x + -xOffset;
        float clampedXpos = Mathf.Clamp(rawXpos, -xClampRange, xClampRange);

        float yOffset = movement.y * controlSpeed * Time.deltaTime;
        float rawYpos = transform.localPosition.y + yOffset;
        float clampedYpos = Mathf.Clamp(rawYpos, -yClampRange, yClampRange);

        transform.localPosition = new Vector3(clampedXpos, clampedYpos, 0f);
    }
}
