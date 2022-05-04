using PKHeX.Core;

public static class PokeLogger
{
    public const string RecordsFileName = "SeedRecords.txt";

    public static void OutputToRecords(IEnumerable<PKM> data, ulong groupSeed, int numR1 = -1, int numR2 = -1)
    {
        static void getInfo(PKM source, ref List<string> refList)
        {
            string[] arr = source.FileNameWithoutExtension.Split(" - ");

            if (arr.Length < 2)
                refList.Add(source.FileNameWithoutExtension);

            refList.Add(string.Format("{0} - {1}", arr[0].Trim(), arr[1].Trim()));
        }

        List<string> pokemons = new();
        foreach (var item in data)
        {
            getInfo(item, ref pokemons);
        }

        System.Text.StringBuilder sb = new();
        sb.Append(string.Format("[{0}] ", DateTime.Now));
        sb.AppendJoin('|', pokemons);
        sb.Append(string.Format(", seed:{0}", groupSeed));

        if (numR1 > 0)
        {
            sb.Append(string.Format(", R1:{0}", numR1));
        }
        if (numR2 > 0)
        {
            sb.Append(string.Format(", R2:{0}", numR2));
        }

        using StreamWriter sw = new(RecordsFileName, true);
        sw.WriteLine(sb.ToString());
    }
}