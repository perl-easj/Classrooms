namespace ClassroomA
{
    public class DVD : DomainBase<int>
    {
        private int _id;
        private string _title;
        private int _runningTime;

        public DVD(int id, string title, int runningTime) 
            : base(id)
        {
            _id = id;
            _title = title;
            _runningTime = runningTime;
        }

        public int ID { get { return _id; } }
        public string Title { get { return _title; } }
        public int RunningTime { get { return _runningTime; } }
    }
}