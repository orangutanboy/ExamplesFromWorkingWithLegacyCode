namespace Database
{
    public class Sql
    {
        public string ExecutedSql { get; private set; }

        public void UpdateTable1(string t, string[] ws, IDatabaseWrapper databaseWrapper)
        {
            var w = "where t1.id=";
            var s = " set t1.name = " + t + ".name";

            if (ws != null)
            {
                foreach (var clause in ws)
                {
                    w += clause + " and ";
                }
                w = w.Substring(0, w.Length - 5);
            }
            ExecutedSql = consts.update + t + s + w;
            databaseWrapper.Execute(ExecutedSql);
        }
    }
}
