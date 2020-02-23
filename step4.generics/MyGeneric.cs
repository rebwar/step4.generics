using System;

namespace step4.generics
{
    class MyGeneric<T>
    {
        private readonly T genericMember;
        public T GenericProperty { get; set; }
        public MyGeneric(T value)
        {
            genericMember = value;
        }
        public T genericMethod(T genericParameter)
        {
            Console.WriteLine($"Parameter type{typeof(T).ToString()} , value : {genericParameter}");
            Console.WriteLine($"Return  type{typeof(T).ToString()} , value : {genericMember}");
            return genericMember;
        }
    }
}
