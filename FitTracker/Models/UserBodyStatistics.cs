namespace FitTracker.Models
{
    //Model
    public class UserBodyStatistics
    {
        public int UserBodyStatisticsId { get; set; }

        public double UserWeight { get; set; }

        public double UserHeight { get; set; }

    }


    //
    public class GetUserStatisitcs
    {

        private UserBodyStatistics userStats;
        private double UserWeight { get; set; }
        private double UserHeight { get; set; }

        public GetUserStatisitcs(UserBodyStatistics userStats)
        { 
            this.userStats = userStats;
            this.UserWeight = userStats.UserWeight;
            this.UserHeight = userStats.UserHeight; 
        }

        public double GetUserWeightKg()
        {
            return UserWeight * 2.20462;
        }


    }
}
