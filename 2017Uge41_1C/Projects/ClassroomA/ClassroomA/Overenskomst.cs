namespace ClassroomA
{
    public class Overenskomst
    {
        private string _gruppe;
        private int _aar;
        private bool _offentlig;

        public Overenskomst(string gruppe, int aar, bool offentlig)
        {
            _gruppe = gruppe;
            _aar = aar;
            _offentlig = offentlig;
        }

        public string Gruppe
        {
            get { return _gruppe; }
        }

        public int Aar
        {
            get { return _aar; }
        }

        public bool Offentlig
        {
            get { return _offentlig; }
        }

        public override int GetHashCode()
        {
            return _gruppe.GetHashCode() + _aar.GetHashCode() * 23 + _offentlig.GetHashCode() * 47;
        }

        public override bool Equals(object obj)
        {
            Overenskomst other = (Overenskomst)obj;

            if (other != null)
            {
                return (_gruppe == other.Gruppe &&
                        _aar == other.Aar &&
                        _offentlig == other.Offentlig);
            }

            return false;
        }
    }
}