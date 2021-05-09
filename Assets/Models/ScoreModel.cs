namespace Models
{
    public class ScoreModel
    {
        private const int Point = 10;
        private static ScoreModel Instance = new ScoreModel();
        public int Total { get; private set; }

        private ScoreModel()
        {
            Total = 0;
        }

        public static ScoreModel GetInstance()
        {
           return Instance;
        }

        public void AddPoint()
        {
            Total += Point;
        }

        public void ResetPoint()
        {
            Total = 0;
        }
    }
}
