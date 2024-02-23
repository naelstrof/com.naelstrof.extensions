using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TransformExtensions {
    public static void CoupleWith(this Transform source, Transform child, Transform childTarget) {
        source.GetCoupleRotationAndPosition(child, childTarget, out Quaternion desiredRotation, out Vector3 desiredPosition);
        source.rotation = desiredRotation;
        source.position = desiredPosition;
    }
    public static void GetCoupleRotationAndPosition(this Transform source, Transform child, Transform childTarget,
        out Quaternion rotation, out Vector3 position) {
        Quaternion angleCorrection = childTarget.rotation * Quaternion.Inverse(child.rotation);
        rotation = angleCorrection * source.rotation;
        position = source.position + (childTarget.position - child.position);
    }
}
