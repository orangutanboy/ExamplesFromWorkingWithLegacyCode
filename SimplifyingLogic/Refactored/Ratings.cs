public static class Ratings
{
    public static int GetRating(bool male, bool ginger, bool hasGlasses)
    {
        int value = 4;

        if (male)
        {
            value -= 2;
        }

        if (male && !ginger && hasGlasses)
        {
            value += 7;
        }

        if (male && ginger && !hasGlasses)
        {
            value += 1;
        }

        if (male && ginger && hasGlasses)
        {
            value += 3;
        }

        if (male)
        {
            value *= 2;
        }

        if (!male && hasGlasses)
        {
            value += 10;
        }

        if (!male && hasGlasses && ginger)
        {
            value -= 4;
        }

        if (!male && !hasGlasses && ginger)
        {
            value /= 3;
        }
        
        return value;
    }
}
