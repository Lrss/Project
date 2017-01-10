using UnityEngine;

namespace UnityStandardAssets.Utility
{
    public class DragRigidbody : MonoBehaviour
    {
        public static bool isTurning;
        float multiplier = 1;
        float deltaReduce = 1;

        float deltaRotation;
        private float newAngle;
        private Rigidbody2D body;

        private bool overobject;

        void Start()
        {
            body = GetComponent<Rigidbody2D>();
        }

        private int cooldown = 100;
        private int currentCooldown = 100;
        private bool cooling;

        void Update()
        {
            float prevAngle = newAngle;
            newAngle = GetMouseAngleDiff();

            //Vector2 offset = new Vector2();
            //Vector2 stretching = new Vector2();
            //float circleDiameter = 500;
            //float distance = Vector2.Distance(new Vector2(body.position.x * stretching.x + offset.x, body.position.y * stretching.y + offset.y), Input.mousePosition);
            //Debug.Log(distance);
            //overobject = distance < circleDiameter;
            //Debug.Log(overobject);

            if (Input.GetMouseButton(0))
            {
                deltaRotation = Mathf.DeltaAngle(prevAngle, newAngle);
                body.AddTorque(deltaRotation * 9999 * multiplier);
            }
            else
            {
                deltaRotation = Mathf.LerpAngle(0, deltaRotation, deltaReduce *Time.deltaTime);
                body.AddTorque(deltaRotation);
            }

            
            //Debug.Log(body.angularVelocity);
            if (body.angularVelocity < 1 && body.angularVelocity > -1)
            {
                //Debug.Log(currentCooldown);
                if (cooling && isTurning)
                {
                    if (currentCooldown < 1)
                    {
                        isTurning = false;
                        cooling = false;
                    }
                    else
                    {
                        currentCooldown--;
                    }
                    
                }
                else
                {
                    currentCooldown = cooldown;
                    cooling = true;
                }
            }
            else
            {
                currentCooldown = cooldown;
                isTurning = true;
            }
        }


        float GetMouseAngleDiff()
        {
            Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            float absAngle = Vector2.Angle(body.position, mouse);

            //Negative angle?
            var cross = Vector3.Cross(body.position, mouse);
            if (cross.z < 0)
                absAngle *= -1;
            //Debug.Log(absAngle);
            return absAngle;
        }
    }
}
