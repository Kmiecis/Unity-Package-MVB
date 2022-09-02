using UnityEngine;

namespace Common.MVB
{
    public sealed class Vector4Value : DynamicValue<Vector4>
    {
        public Vector4Value() :
            base()
        {
        }

        public Vector4Value(Vector4 value) :
            base(value)
        {
        }
    }
}
