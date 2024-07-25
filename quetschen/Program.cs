namespace logik
{
    public class Programm
    {
        [STAThread]
        public static string Quetschen(string bilddaten)
        {
            int i = 0;
            int j = 0;
            int k;
            char[] daten = bilddaten.ToCharArray();
            string kompStr = "";
            char z;
            while (i < (daten).Length)
            {
                z = daten[i];
                while (i < (daten).Length && z == daten[i])
                {
                    i++;
                    j++;
                }
                if (j < 4)
                {
                    for (k = 1; k <= j; k++)
                    {
                        kompStr += z;
                    }
                }
                else
                {
                    kompStr += "§" + j + z;
                }
                j = 0;
            }
            return kompStr;
        }
        static void Main()
        {
            Application.EnableVisualStyles();
            ApplicationConfiguration.Initialize();
            Application.Run(new quetschen.Form1());
        }
    }
}