﻿namespace orabs
{
    class GlobalStatus
    {
        public static bool login = false;
        public static string userName = "";
        public static int userId = -1;

        public static string AppendPercent(string str)
        {
            return "%" + str + "%";
        }
    }
}
