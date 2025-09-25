using System.Collections;
namespace Extension_Methods;

static class Delegates
{
    static Random _rnd = new Random();

    public static void Mixlist(this IList list)
    {
        for (int i = list.Count - 1; i > 0; i--)
        {
            int j = _rnd.Next(i + 1);
            (list[i], list[j]) = (list[j], list[i]);
        }
    }
}