using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Vector2Extensions {

	public static Vector2 With(this Vector2 original, float? x = null, float? y = null) {
		return new Vector2(x ?? original.x, y ?? original.y);
	}

	public static Vector2 MagnitudeClamped(this Vector2 original, float? min = null, float? max = null) {
		float magnitude = original.magnitude;
		magnitude = Mathf.Max(magnitude, min ?? magnitude);
		magnitude = Mathf.Min(magnitude, max ?? magnitude);
		return original.normalized * magnitude;
	}

    public static Vector2 ExpDecay(this Vector2 a, Vector2 b, float decay, float dt) {
        return b + (a - b) * Mathf.Exp(-decay * dt);
    }
}
