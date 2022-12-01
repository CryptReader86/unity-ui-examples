using UnityEngine;
using System;
using System.Collections.Generic;

public enum ParameterType
{
    FloatParameter,
    IntParameter,
    BoolParameter,
    TriggerParameter
}

[Serializable]
public class ParameterProperties
{
    public string name;
    public string state;
    public ParameterType type;
    public int intValue;
    public float floatValue;
    public bool boolValue;
}

[Serializable]
public class AnimatorProperties
{
    public string name;
    public Animator animator;
    public List<ParameterProperties> parameters;
}

public class ChestAnimControls : MonoBehaviour
{
    [SerializeField]
    private List<AnimatorProperties> _animatedItems;
}
