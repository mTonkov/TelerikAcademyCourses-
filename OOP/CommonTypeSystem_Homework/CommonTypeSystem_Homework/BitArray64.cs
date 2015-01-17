
namespace CommonTypeSystem_Homework
{//TASK 05
    /*Define a class BitArray64 to hold 64 bit values inside an ulong value. 
     * Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=*/
    using System;
    using System.Collections;
    using System.Collections.Generic;
    public class BitArray64 : IEnumerable<int>
    {
        private int[] bitArr = new int[64];
        private ulong InputNumber { get; set; } // automatic property for the input

        //constructor
        public BitArray64(ulong number)
        {
            this.InputNumber = number;

            for (int i = 0; i < 64; i++)
            {
                bitArr[i] = (int)(number % 2);
                number /= 2;
            }
        }


        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < bitArr.Length; i++) //bitArr is a variable of type int[] which is not accessible from the outside,
            //so we can use it directly, relying on the code inside the class
            {
                yield return bitArr[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override bool Equals(object obj)
        {
            var newArr = obj as BitArray64;
            if (newArr != null)
            {
                return this.InputNumber.Equals(newArr.InputNumber);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return this.InputNumber.GetHashCode() ^ this.bitArr.GetHashCode();
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= bitArr.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                return bitArr[index];
            }
        }

        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !(first.Equals(second));
        }

    }
}
