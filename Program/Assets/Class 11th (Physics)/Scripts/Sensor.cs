using UnityEngine;

public class Sensor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Authorize"))
        {
            Debug.Log(other.gameObject.name + " Trigger Enter");

            other.GetComponent<Control>().Soar();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Authorize"))
        {
            Debug.Log(other.gameObject.name + " Trigger Stay");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Authorize"))
        {
            Debug.Log(other.gameObject.name + " Trigger Exit");

            other.GetComponent<Control>().Revert();
        }
    }
}