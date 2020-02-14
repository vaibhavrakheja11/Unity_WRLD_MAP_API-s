using System.Collections;
using Wrld;
using Wrld.Space;
using UnityEngine;

public class CameraTransitionMovingCamera : MonoBehaviour
{
    private void OnEnable()
    {
        StartCoroutine(Example());
    }

    IEnumerator Example()
    {
        var startLocation = LatLong.FromDegrees(53.495, -113.5210);
        Api.Instance.CameraApi.MoveTo(startLocation, distanceFromInterest: 800, headingDegrees: 0, tiltDegrees: 50);

        yield return new WaitForSeconds(4.0f);

        var destLocation = LatLong.FromDegrees(53.515, -113.5276);
        Api.Instance.CameraApi.MoveTo(destLocation, distanceFromInterest: 500);
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }
}
