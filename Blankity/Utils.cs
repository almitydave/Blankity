namespace Blankity
{
    class Utils
    {
        //Get a standardized string describing screen n
        public static string GetScreenName(int screenNumber)
        {
            return "Monitor " + GetScreenNumber(screenNumber);
        }

        //Get a standardized numerical reference to a screen.
        //All this does is add one and convert to string, do we really need this function?
        public static string GetScreenNumber(int screenNumber)
        {
            return (screenNumber + 1).ToString();
        }
    }
}
