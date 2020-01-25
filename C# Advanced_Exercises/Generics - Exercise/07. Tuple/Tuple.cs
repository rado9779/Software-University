namespace _07.Tuple
{
    public class Tuple<T1, T2>
    {

        private T1 tupleOne;
        private T2 tupleTwo;

        public Tuple(T1 tuple1, T2 tuple2)
        {
            this.tupleOne = tuple1;
            this.tupleTwo = tuple2;
        }

        public override string ToString()
        {
            return $"{this.tupleOne} -> {this.tupleTwo}";
        }

    }
}
