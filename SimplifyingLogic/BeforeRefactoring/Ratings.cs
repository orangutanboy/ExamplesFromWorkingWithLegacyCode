public static class Ratings
{
    public static int GetRating(bool male, bool ginger, bool hasGlasses)
    {
        int value = 4;

        if (male)
        {
            value -= 2;

            if (!ginger)
            {
                if (hasGlasses)
                {
                    value += 7;
                }
            }
            else
            {
                if (!hasGlasses)
                {
                    value += 1;
                }
                else
                {
                    value += 3;
                }
            }
            value *= 2;
        }
        else
        {
            if (hasGlasses)
            {
                value += 10;
                if (ginger)
                {
                    value -= 4;
                }
            }
            else if (ginger)
            {
                value /= 3;
            }
        }
        return value;

    }
}
