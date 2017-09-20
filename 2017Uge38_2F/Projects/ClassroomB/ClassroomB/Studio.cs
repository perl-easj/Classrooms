namespace ClassroomB
{
    public class Studio
    {
        private string _studioName;
        private string _hqCity;
        private int _noOfEmployees;

        public Studio(string studioName, string hqCity, int noOfEmployees)
        {
            _studioName = studioName;
            _hqCity = hqCity;
            _noOfEmployees = noOfEmployees;
        }

        public string StudioName
        {
            get { return _studioName; }
        }

        public string HqCity
        {
            get { return _hqCity; }
        }

        public int NoOfEmployees
        {
            get { return _noOfEmployees; }
        }
    }
}