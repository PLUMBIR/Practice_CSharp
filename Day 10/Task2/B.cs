namespace Task2
{
    public class B : A
    {
        public int d;

        public int c2
        {
            get
            {
                int counter = 0;
                int result = 0;

                while (counter < 1)
                {
                    result = a + b + d;

                    counter++;
                }

                return result;
            }
            set { }
        }

        public B(int a, int b, int d) : base(a, b)
        {
            this.d = d;
        }
    }
}
