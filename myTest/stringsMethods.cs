namespace Hello_world
{
    class StringsMethods
    {
        public static void strings_()
        {
            string a = "hola";
            string c = a.Substring(1);

            // ToLower();
            // ToUpper();
            // Trim();

            bool check = String.IsNullOrWhiteSpace(a);

            int i = a.IndexOf("o");
                
            a = "Hola";
            string b = String.Format("Un texto {0}", a);

        }
    }
}