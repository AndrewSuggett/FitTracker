using Xunit;
using FitTracker.Models;

namespace FitTracker.Tests.UnitTests
{
    public class UserStatisticsTests
    {
        [Fact]
        public void UserWeightKg_Input1_ReturnKg()
        {

            UserBodyStatistics userStatsModel = new UserBodyStatistics { UserHeight = 1, UserWeight = 1};

            GetUserStatisitcs userStats = new GetUserStatisitcs(userStatsModel);

            Assert.Equal(userStats.GetUserWeightKg(), 1 * 2.20462);
        }
    }
}
