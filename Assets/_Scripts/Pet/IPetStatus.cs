using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPetStatus
{
    string Name { get; set; }
    float Hunger { get; set; }
    float Love { get; set; }
    float Sleep { get; set; }
    float Play { get; set; }
}
