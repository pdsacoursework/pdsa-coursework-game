namespace PDSACourseWork.Helper
{
    public class EightQueenHelper
    {
        public static bool CompareLists(List<string> playerList, List<string> possibilityList)
        {
            bool isEqual = false;

            foreach (var item in possibilityList)
            {
                var dbPosibility = item.Split('-').OrderBy(x => x).ToList();

                isEqual = Enumerable.SequenceEqual(playerList, dbPosibility);

                if (isEqual == true)
                {
                    break;
                }
            }

            return isEqual;
        }
    }
}
