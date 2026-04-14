namespace Lab1
{
    public class Box : MyNumbers
    {
        public Box(int length, int width, int height)
            : base(length, width, height)
        {
        }

        public int GetVolume()
        {
            return A * B * C;
        }

        public bool IsCube()
        {
            return (A == B && B == C);
        }

        public override string ToString()
        {
            return base.ToString() + " | V: " + GetVolume();
        }
    }
}
