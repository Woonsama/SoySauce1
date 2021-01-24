using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MobState
{
    public interface IMove
    {
        void Move();
    }

    public interface IStop
    {
        void Stop();
    }

    public interface IAttack
    {
        void Attack();
    }

    public interface IRayDistance
    {
        void DrawRay();
    }
}