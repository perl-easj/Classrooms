namespace ClassroomC
{
    public class Die
    {
        private int _faceValue;

        public Die(int faceValue)
        {
            _faceValue = faceValue;
        }

        public int FaceValue
        {
            get { return _faceValue; }
        }
    }
}